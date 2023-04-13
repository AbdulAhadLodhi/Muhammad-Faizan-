using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    [TestClass]
    public class Login_TM:Base
    {
        LoginLOC obj = new LoginLOC();

        [TestMethod]
        public void LoginWithValidCredentials()
        {
            Base.SetDriver("Chrome");

            obj.sendLoginDetails("mianfizanch175@gmail.com", "Fiz@n4202");


        }
    }
}
