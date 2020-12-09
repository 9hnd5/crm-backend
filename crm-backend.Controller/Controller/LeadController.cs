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
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IBaseRepository<Lead> _baseRepository;
        public LeadController(ILeadRepository leadRepository, IBaseRepository<Lead> baseRepository)
        {
            _leadRepository = leadRepository;
            _baseRepository = baseRepository;
        }
        //GET ALL LEADS IN DATABASE
        [Route("api/leads")]
        [HttpGet]
        public async Task<ActionResult<List<Lead>>> GetLeads()
        {
            var leads = await _baseRepository.GetAll();
            return Ok(leads);
        }

        //UPDATE LEAD BY ID
        [Route("api/lead/{id}")]
        [HttpPut]
        public ActionResult<int> UpdateLeadById(int id, LeadModelUpdate lead)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Lead prevLead = _baseRepository.GetById(id);
            prevLead.FirstName = lead.FirstName;
            prevLead.LastName = lead.LastName;
            prevLead.Email = lead.Email;
            prevLead.Phone = lead.Phone;
            prevLead.Source = lead.Source;
            prevLead.Status = lead.Status;
            prevLead.CreateDate = lead.CreateDate;
            prevLead.UpdateDate = lead.UpdateDate;
            _baseRepository.Update(prevLead);
            _baseRepository.SaveChanges();
            return Ok();
        }

        //REPORT LEADS BY STATUS GROUP
        [Route("api/lead/report")]
        [HttpGet]
        public ActionResult<List<KeyValuePair<string, int>>> ReportLeadByStatus()
        {
            var result = _leadRepository.ReportLeadByStatus();
            return Ok(result);
        }

        //REPORT LEADS FROM CREATE DATE TO CREATE DATE USE STORE PROCEDURE
        [HttpPost]
        [Route("api/lead/report")]
        public ActionResult<List<Lead>> ReportLeadByDate(ReportLeadModel rpLeadModel)
        {
            var leads = _leadRepository.ReportLeadByDate(rpLeadModel.from, rpLeadModel.to);
            return Ok(leads);
        }

        //PAGING BY PAGEINDEX AND PAGESIZE
        [HttpPost]
        [Route("api/leads/{pageIndex}/{pageSize}")]
        public ActionResult<int> Paging(int pageIndex, int pageSize)
        {
            var leads = _leadRepository.Paging(pageIndex, pageSize);
            return Ok(leads);
        }
    }
}
