using Apprisal.BlazorApp.Data;
using Apprisal.BlazorApp.Model;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Apprisal.BlazorApp.ServiceRepository
{
    public class ApprisalService : IApprisalService
    {
        public readonly ApplicationContext context;
        public ApprisalService(ApplicationContext appContext)
        {
            context = appContext;
        }

        public async Task<string> AddApprisal(ApprisalModel apprisal)
        {
            try
            {
                var entity = new ApprisalEntity
                {
                    EvoluvationPeriod = apprisal.EvoluvationPeriod,
                    Name = apprisal.Name,
                    DateOfJoin = apprisal.DateOfJoin,
                    NumberOfLeavesTaken = apprisal.NumberOfLeavesTaken,
                    ClientDelivery = (Data.ClientDelivery)apprisal.ClientDelivery,
                    ClientDeliveryFeed = apprisal.ClientDeliveryFeed,
                    Responsibility = (Data.Responsibilities)apprisal.Responsibility,
                    ResponsibilitiesFeed = apprisal.ResponsibilitiesFeed,
                    Skills = (Data.Skills)apprisal.Skills,
                    SkillsFeed = apprisal.SkillsFeed,
                    Certifiate = apprisal.Certifiate,
                    AboutCourse = apprisal.AboutCourse,
                    Feedback = apprisal.Feedback
                };
                await context.Apprisals.AddAsync(entity);
                await context.SaveChangesAsync();

                return $"Apprisal {entity.Name} Added Sucessfully";
            }
            catch (Exception ex)
            {
                return $"Apprisal {apprisal.Name} Failed to Added" + ex;
            }
        }


        public async Task<bool> Delete(int Id)
        {
            var data = await context.Apprisals.FindAsync(Id);
            if (data == null) { return true; }
            context.Remove(data);
            await context.SaveChangesAsync();
            return true;

        }

        public async Task<string> EditApprisal(ApprisalModel form)
        {
            var data = await context.Apprisals.FindAsync(form.ApprisalId);
            if (data != null)
            {
                data.ApprisalId = form.ApprisalId;
                data.EvoluvationPeriod = form.EvoluvationPeriod;
                data.Name = form.Name;
                data.NumberOfLeavesTaken = form.NumberOfLeavesTaken;
                data.DateOfJoin = form.DateOfJoin;
                data.ClientDelivery = (Data.ClientDelivery)form.ClientDelivery;
                data.ClientDeliveryFeed = form.ClientDeliveryFeed;
                data.Responsibility = (Data.Responsibilities)form.Responsibility;
                data.ResponsibilitiesFeed = form.ResponsibilitiesFeed;
                data.Skills = (Data.Skills)form.Skills;
                data.SkillsFeed = form.SkillsFeed;
                data.Certifiate = form.Certifiate;
                data.AboutCourse = form.AboutCourse;
                data.Feedback = form.Feedback;

                context.Apprisals.Update(data);
                await context.SaveChangesAsync();
                return $"{form.Name} Edited Sucessfully";
            }
            else
            {
                return $"{form.Name} Unable to Updated";
            }
        }

        public async Task<List<ApprisalModel>> GetAll()
        {
            var data = await context.Apprisals.Select(app => new ApprisalModel()
            {
                ApprisalId = app.ApprisalId,
                EvoluvationPeriod = app.EvoluvationPeriod,
                Name = app.Name,
                NumberOfLeavesTaken = app.NumberOfLeavesTaken,
                DateOfJoin = app.DateOfJoin,
                ClientDelivery = (Model.ClientDelivery)app.ClientDelivery,
                ClientDeliveryFeed = app.ClientDeliveryFeed,
                Responsibility = (Model.Responsibilities)app.ApprisalId,
                ResponsibilitiesFeed = app.ResponsibilitiesFeed,
                Skills = (Model.Skills)app.Skills,
                SkillsFeed = app.SkillsFeed,
                Certifiate = app.Certifiate,
                AboutCourse = app.AboutCourse,
                Feedback = app.Feedback

            }).ToListAsync();

            return data;
        }

        public async Task<ApprisalModel?> GetbyId(int Id)
        {
            var app = await context.Apprisals.FindAsync(Id);
            if (app == null) { return null; }
            var data = new ApprisalModel()
            {
                ApprisalId = app.ApprisalId,
                EvoluvationPeriod = app.EvoluvationPeriod,
                Name = app.Name,
                NumberOfLeavesTaken = app.NumberOfLeavesTaken,
                DateOfJoin = app.DateOfJoin,
                ClientDelivery = (Model.ClientDelivery)app.ClientDelivery,
                ClientDeliveryFeed = app.ClientDeliveryFeed,
                Responsibility = (Model.Responsibilities)app.Responsibility,
                ResponsibilitiesFeed = app.ResponsibilitiesFeed,
                Skills = (Model.Skills)app.Skills,
                SkillsFeed = app.SkillsFeed,
                Certifiate = app.Certifiate,
                AboutCourse = app.AboutCourse,
                Feedback = app.Feedback
            };
            return data;
        }
    }
}

