using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using bl.Model;

namespace bl.Api
{
    public interface IBLoginSignUpl
    {
        public void Login(User user);
        public void SignUp(User user);

    }
}
