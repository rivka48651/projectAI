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
            GetListorders().Add(order);  
        }
        public List<Order> GetListorders() 
        {
            //צריך פה לשנות וללכת לDAL ולקחת משם את הרשימה 
            Movie m=new Movie(7767,"הפונציקים","סרט לילדים","www.ch.il","הצגות",100,12/12/2000,AgeGroup.Children);
            User u=new User(21321,"tmp","tmp@","password",54,eGender.male);
            Order o=new Order(21123,u,);
                List<Order>lst=new List<Order>();
                return
        }
    }
}
