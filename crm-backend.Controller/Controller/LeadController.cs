using crm_backend.Controller.ViewModel;
using crm_backend.DataAccessLayer.Entities;
using crm_backend.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crm_backend.Controller.Controller
{
    [Route("api/lead")]
    [ApiController]
    public class LeadController: ControllerBase
    {
        private readonly ILeadRepository _leadRepository;     
        public LeadController(ILeadRepository leadRepository)
        {
            _leadRepository = leadRepository;
        }
        [HttpGet]
        public ActionResult<List<Lead>> GetAllLead()
        {
            var leads = _leadRepository.GetAllLead();
            return Ok(leads);
        }
        [HttpPut("{id}")]
        public ActionResult<int> UpdateLeadById(int id, LeadModelUpdate lead)
        {
            Lead newLead = new Lead()
            {
                FirstName = lead.FirstName,
                LastName = lead.LastName,
                Email = lead.Email,
                Phone = lead.Phone,
                Source = lead.Source,
                Status = lead.Status,
                CreateDate = lead.CreateDate,
                UpdateDate = lead.UpdateDate
            };
            _leadRepository.UpdateLeadById(id, newLead);
            _leadRepository.SaveChanges();
            return Ok(_leadRepository.GetLeadById(id));
        }
    }
}
