using Dal.Api;
using BL.Api;
using Microsoft.Extensions.DependencyInjection;
using Dal;
using BL.Services;

namespace BL
{
    public class BlManager :IBL
    {

        public IBLCustomer Customer { get; }
        public IBLOrders Order { get;}

        public BlManager()
        {
            ServiceCollection serCollection = new ServiceCollection();
            serCollection.AddSingleton<IDal, DalManager>();
            serCollection.AddScoped<IBLCustomer, BLCustomerService>();
            serCollection.AddScoped<IBLOrders, BLOrderService>();

            //הגדרת ספק מחלקות שרות
            ServiceProvider p = serCollection.BuildServiceProvider();
            Customer = p.GetRequiredService<IBLCustomer>();
            Order = p.GetRequiredService<IBLOrders>();
        }
    }
}
