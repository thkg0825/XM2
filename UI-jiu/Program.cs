using Application.AppService.IUser;
using Application.AppService.User;
using Application.Profiles;
using Domain.Repository;
using EFCore;
using EFCore.Repository.User;

namespace UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            {
                builder.Services.AddDbContext<MyDbContext>();

				builder.Services.AddTransient<IUserRepository, UserRepository>();
				builder.Services.AddTransient<IUsersAppService, UsersAppService>();

                //builder.Services.AddTransient<IUserRepository, UserRepository>();
                //builder.Services.AddTransient<IUserAppService, UserAppService>();

                //builder.Services.AddTransient<Iconfig_file_first_kindRepository, config_file_first_kindRepository>();
                //builder.Services.AddTransient<Iconfig_file_first_kindAppService, config_file_first_kindAppService>();

                //builder.Services.AddTransient<Iconfig_file_second_kindRepository, config_file_second_kindRepository>();
                //builder.Services.AddTransient<Iconfig_file_second_kindAppService, config_file_second_kindAppService>();

                //builder.Services.AddTransient<Iconfig_file_third_kindRepository, config_file_third_kindRepository>();
                //builder.Services.AddTransient<Iconfig_file_third_kindAppService, config_file_third_kindAppService>();

                builder.Services.AddAutoMapper(typeof(UserProfile));
            }

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/HR/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=User}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
