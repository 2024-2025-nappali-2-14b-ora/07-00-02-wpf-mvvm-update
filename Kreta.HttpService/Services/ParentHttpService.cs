using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Entites.SchoolCitizens;
using Kreta.Shared.Models;


namespace Kreta.HttpService.Services
{
    public class ParentHttpService : BaseService<Parent, ParentDto>, IParentHttpService
    {
        public ParentHttpService(IHttpClientFactory? httpClientFactory,ParentAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
