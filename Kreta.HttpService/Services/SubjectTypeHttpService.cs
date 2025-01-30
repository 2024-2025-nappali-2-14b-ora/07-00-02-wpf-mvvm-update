using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;

namespace Kreta.HttpService.Services
{
    public class SubjectTypeHttpService : BaseService<SubjectType, SubjectTypeDto>, ISubjectTypeHttpService
    {
        public SubjectTypeHttpService(IHttpClientFactory? httpClientFactory, SubjectTypeAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
