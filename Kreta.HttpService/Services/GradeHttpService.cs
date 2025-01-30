using Kreta.HttpService.Services.Base;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites;

namespace Kreta.HttpService.Services
{
    public class GradeHttpService : BaseService<Grade, GradeDto>, IGradeHttpService
    {
        public GradeHttpService(IHttpClientFactory? httpClientFactory, GradeAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
