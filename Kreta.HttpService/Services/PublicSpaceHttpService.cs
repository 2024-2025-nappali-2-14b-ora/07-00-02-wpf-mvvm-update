using Kreta.HttpService.Services.Base;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites;

namespace Kreta.HttpService.Services
{
    public class PublicSpaceHttpService : BaseService<PublicSpace, PublicSpaceDto>, IPublicSpaceHttpService
    {
        public PublicSpaceHttpService(IHttpClientFactory? httpClientFactory, PublicSpaceAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
