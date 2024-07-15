using Dal.DalApi;
using Dal.DalServices;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

namespace Dal
{
    public class DalManger
    {

    
    public DalSubscribersServices dalSubscribersServices { get; }
    public DalCarsServices dalCarsServices { get; }
    public DalRentalsServices dalRentalsServices { get; }
    public DalParkingServices dalParkingServices { get; }
        public DalManger()
    {
        ServiceCollection services = new();

        services.AddDbContext<BridalContext>(options => options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\user1\\Downloads\\__MyDataBase - עותק.mdf\";Integrated Security=True;Connect Timeout=30"));

        services.AddScoped<IDalSubscribers, DalSubscribersServices>();
        services.AddScoped<IDalCars, DalCarsServices>();
        services.AddScoped<IDalRentals, DalRentalsServices>();
        services.AddScoped<IDalParking, DalParkingServices>();
        ServiceProvider Provider = services.BuildServiceProvider();
        dalSubscribersServices = (DalSubscribersServices)Provider.GetService<IDalSubscribers>();
        dalCarsServices = (DalCarsServices)Provider.GetService<IDalCars>();
        dalRentalsServices = (DalRentalsServices)Provider.GetService<IDalRentals>();
        dalParkingServices = (DalParkingServices)Provider.GetService<IDalParking>();
        }
    }
}