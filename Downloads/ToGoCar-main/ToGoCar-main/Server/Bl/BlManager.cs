using Bl.BlApi;
using Bl.BlServices;
using Dal;
using Microsoft.Extensions.DependencyInjection;
using project;

namespace Bl
{
    public class BlManager
    {
       
        public BlSubscribersServices blSubscribersServices { get; }
        public BlCarsServices blCarsServices { get; }
        public BlRentalsServices blRentalsServices { get; }
        public BlParkingServices blParkingServices { get; }
        public BlManager()
        {
            ServiceCollection services = new();

            services.AddScoped<DalManger>();
            services.AddScoped<IBlSubscribers, BlSubscribersServices>();
            services.AddScoped<IBlCars, BlCarsServices>();
            services.AddScoped<IBlRentals, BlRentalsServices>();
            services.AddScoped<IBlParking, BlParkingServices>();
            ServiceProvider provider= services.BuildServiceProvider();
            blSubscribersServices = (BlSubscribersServices)provider.GetRequiredService<IBlSubscribers>();
            blCarsServices = (BlCarsServices)provider.GetRequiredService<IBlCars>();
            blRentalsServices = (BlRentalsServices)provider.GetRequiredService<IBlRentals>();
            blParkingServices = (BlParkingServices)provider.GetRequiredService<IBlParking>();
        }
    }
    }
    
  
