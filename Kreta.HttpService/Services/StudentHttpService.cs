using Kreta.HttpService.Services.Base;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites.SchoolCitizens;

namespace Kreta.HttpService.Services
{
    public class StudentHttpService : BaseService<Student, StudentDto>, IStudentHttpService
    {
        public StudentHttpService()
        {
            
        }
        public StudentHttpService(IHttpClientFactory? httpClientFactory, StudentAssambler studentAssambler) : base(httpClientFactory, studentAssambler)
        {
        }
    }
}
