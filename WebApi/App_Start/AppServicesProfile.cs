using AutoMapper;
using BusinessLayer.Model.Models;
using WebApi.Models;



namespace WebApi
{
    public class AppServicesProfile : Profile
    {
        public AppServicesProfile()
        {
            CreateMapper();
        }

        private void CreateMapper()
        {
            try
            {

           
                    CreateMap<BaseInfo, BaseDto>();
                    CreateMap<CompanyInfo, CompanyDto>();
                    CreateMap<EmployeeInfo, EmployeeDto>();
                    CreateMap<ArSubledgerInfo, ArSubledgerDto>();
            }
            catch (System.Exception ex)
            {

                WebApi.App_Start.LoggerTools.LogException(ex, "Error : " + ex);
            }

        }





    }
}