using Apprisal.BlazorApp.Model;

namespace Apprisal.BlazorApp.ServiceRepository
{
    public interface IApprisalService
    {
        Task<List<ApprisalModel>> GetAll();
        Task<ApprisalModel?> GetbyId(int Id);
        Task<string> AddApprisal(ApprisalModel apprisalform);
        Task<string> EditApprisal(ApprisalModel form);
        Task<bool> Delete(int Id);
    }
}
