using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bl.Model
{
    public static class Orders
    {
        public static List<Order> Listorders = new List<Order>();

        //public Orders() {
        //    Listorders = new List<Order>();
        //}
        public static List<Order> GetListorders() { return Listorders; }
    }
}
