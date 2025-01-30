using Kreta.Shared.Models.Entites.SwitchTable;
using Kreta.Shared.Models.Responses;

namespace Kreta.HttpService.Services
{
    public interface ISchoolClassSubjectsHttpService
    {
        public Task<List<SchoolClassSubjects>> SelectAllIncludedAsync();
        public Task<Response> MoveToNotStudyingAsync(SchoolClassSubjects schoolClassSubjectsIdsDto);
        public Task<Response> MoveToStudyingAsync(SchoolClassSubjects schoolClassSubjects);
    }
}
