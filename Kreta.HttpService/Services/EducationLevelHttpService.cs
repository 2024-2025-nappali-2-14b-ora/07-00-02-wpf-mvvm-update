using Kreta.HttpService.Services.Base;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites;

namespace Kreta.HttpService.Services
{
    public class EducationLevelHttpService : BaseService<EducationLevel, EducationLevelDto>, IEducationLavelService
    {
        public EducationLevelHttpService(IHttpClientFactory? httpClientFactory, EducationLevelAssambler assambler, StudentAssambler studentAssambler) : base(httpClientFactory, assambler)
        {
        }


    }
}
