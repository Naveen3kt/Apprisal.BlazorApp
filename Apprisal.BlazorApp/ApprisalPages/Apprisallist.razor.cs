using Apprisal.BlazorApp.Model;
using Apprisal.BlazorApp.ServiceRepository;
using Microsoft.AspNetCore.Components;

namespace Apprisal.BlazorApp.ApprisalPages
{
    public partial class Apprisallist : ComponentBase
    {
        public List<ApprisalModel>? apprisalModels;
        protected override async Task OnInitializedAsync()
        {
            apprisalModels = await service.GetAll();
            _ = base.OnInitializedAsync();
        }




    }
}
