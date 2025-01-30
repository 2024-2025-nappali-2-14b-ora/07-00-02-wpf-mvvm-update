using Kreta.HttpService.Services.Base;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models.Dtos;
using Kreta.Shared.Models.Entites;

namespace Kreta.HttpService.Services
{
    public class TypleOfEducationHttpService : BaseService<TypeOfEducation, TypeOfEducationDto>, ITypeOfEducationHttpService
    {
        public TypleOfEducationHttpService(IHttpClientFactory? httpClientFactory, TypeOfEducationAssambler assambler) : base(httpClientFactory, assambler)
        {
        }
    }
}
