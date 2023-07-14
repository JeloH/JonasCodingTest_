using System;
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using BusinessLayer.Model.Interfaces;
using WebApi.Models;
using System.Threading.Tasks;
using System.Threading;

namespace WebApi.Controllers
{
    public class CompanyController : ApiController
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public  CompanyController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }
        
        
        // GET api/<controller>
        public async Task <IEnumerable<CompanyDto>> GetAll()
        {
            var items = _companyService.GetAllCompanies();
            return await Task.Run(() => _mapper.Map<IEnumerable<CompanyDto>>(items));
        }

        
        // GET api/<controller>/5
        public async Task <CompanyDto> Get(string companyCode)
        {
            var item = _companyService.GetCompanyByCode(companyCode);
            return await Task.Run(()=> _mapper.Map<CompanyDto>(item));
        }



        // POST api/<controller>
        public async Task Post([FromBody] string value)
        {

            await Task.Run
            (() =>
            {
                
            });

        }

        // PUT api/<controller>/5
        public async Task Put(int id, [FromBody]string value)
        {
            await Task.Run
            (() =>
            {

            });

        }


        // DELETE api/<controller>/5
        public async Task Delete(int id)
        {
            await Task.Run
          (() =>
          {

          });

        }
    }
}