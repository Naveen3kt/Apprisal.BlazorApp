using Apprisal.BlazorApp.Model;
using Apprisal.BlazorApp.ServiceRepository;
using Microsoft.AspNetCore.Components;

namespace Apprisal.BlazorApp.ApprisalPages
{
    public partial class Apprisallist : ComponentBase
    {
        private IApprisalService? service;
        private List<ApprisalModel>? apprisalModels;

        public Apprisallist(IApprisalService Service)
        {
            service = Service;
        }
        protected override async Task OnInitializedAsync()
        {
            apprisalModels = await service.GetAll();
            _ = base.OnInitializedAsync();
        }




    }
}
