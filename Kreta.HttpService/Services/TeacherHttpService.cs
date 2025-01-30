using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Kreta.Shared.Models;

namespace Kreta.HttpService.Services
{
    public class TeacherHttpService : BaseService<Teacher, TeacherDto>, ITeacherHttpService
    {
        public TeacherHttpService(IHttpClientFactory? httpClientFactory, TeacherAssambler assambler) : base (httpClientFactory, assambler) { }
    }
}
