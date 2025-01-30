using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Kreta.Shared.Models.Dtos;
using Kreta.HttpService.Services.Base;


namespace Kreta.HttpService.Services
{
    public class ParentHttpService : BaseService<Parent, ParentDto>, IParentHttpService
    {
        public ParentHttpService(IHttpClientFactory? httpClientFactory,ParentAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
