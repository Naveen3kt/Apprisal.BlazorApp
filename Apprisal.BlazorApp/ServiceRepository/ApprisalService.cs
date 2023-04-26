using Apprisal.BlazorApp.Data;
using Apprisal.BlazorApp.Model;

namespace Apprisal.BlazorApp.ServiceRepository
{
    public class ApprisalService : IApprisalService
    {
        public readonly ApplicationContext Appcontext;
        public ApprisalService(ApplicationContext appContext)
        {
            Appcontext = appContext;
        }
        public Task<string> AddApprisal()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<string> EditApprisal()
        {
            throw new NotImplementedException();
        }

        public Task<List<ApprisalModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ApprisalModel> GetbyId()
        {
            throw new NotImplementedException();
        }
    }
}
