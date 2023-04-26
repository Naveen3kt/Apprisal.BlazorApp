using Apprisal.BlazorApp.Model;

namespace Apprisal.BlazorApp.ServiceRepository
{
    public interface IApprisalService
    {
        Task<List<ApprisalModel>> GetAll();
        Task<ApprisalModel> GetbyId();
        Task<string> AddApprisal();
        Task<string> EditApprisal();
        Task<bool> Delete();
    }
}
