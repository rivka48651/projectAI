using bl.Api;
using bl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bl;
namespace bl.Services
{
    public class BlServicesOreder : IBlAddOreder
    {
        public void AddOreder(Order order)
        {
            Orders.GetListorders().Add(order);  
        }
    }
}
