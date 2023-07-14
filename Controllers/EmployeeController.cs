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
    public class EmployeeController : ApiController
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeService companyService, IMapper mapper)
        {
            _employeeService = companyService;
            _mapper = mapper;
        }

        public async Task <IEnumerable<EmployeeDto>> GetAll()
        {
            var items = _employeeService.GetAllEmployees();
            return await Task.Run(() => _mapper.Map<IEnumerable<EmployeeDto>>(items));
        }


        public async Task <EmployeeDto> Get(string employeeCode)
        {
            var item = _employeeService.GetByCodeEmployee(employeeCode);
            return await Task.Run(() => _mapper.Map<EmployeeDto>(item));
        }

        






    }
}