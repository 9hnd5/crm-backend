using crm_backend.DataAccessLayer.Entities;
using crm_backend.Repository.Interface;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace crm_backend.Controller.DailyJob
{
    public class ChangeStatusLeadPrevMonth : IHostedService
    {
        private Timer _timer;
        public ChangeStatusLeadPrevMonth(IServiceProvider services)
        {
            Services = services;
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(ChangeStatus, null, TimeSpan.FromSeconds(0), TimeSpan.FromHours(24));
            return Task.CompletedTask;
        }
        public IServiceProvider Services { get; }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _timer?.Change(Timeout.Infinite, 0);
            return Task.CompletedTask;
        }
        public async void ChangeStatus(object state)
        {
            using (var scope = Services.CreateScope())
            {
                Console.WriteLine("---------------Start Timer----------------");
                var currentMonths = DateTime.Today;
                var prevMonth = new DateTime(currentMonths.Year, currentMonths.Month, currentMonths.Day).AddMonths(-1).ToString("yyyy/MM/dd");
                var _baseRepository = scope.ServiceProvider.GetService<IBaseRepository<Lead>>();
                var leads = await _baseRepository.GetAll();
                var queryLeads = (from lead in leads
                         where lead.CreateDate == prevMonth
                         select lead);
                foreach(var lead in queryLeads)
                {
                    if(lead.Status.ToLower() == "Do not call".ToLower())
                    {
                        lead.Status = "Archive";
                    }
                    _baseRepository.Update(lead);
                }
                _baseRepository.SaveChanges();
            }
            
        }
    }
}
