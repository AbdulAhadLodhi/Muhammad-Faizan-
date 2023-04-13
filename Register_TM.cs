using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    [TestClass]
    public class Register_TM : Base
    {
        RegisterLoc obj = new RegisterLoc();

        [TestMethod]
        public void LoginWithPresentCredentials()
        {
            Base.SetDriver("Chrome");

            obj.sendSignDetails("mianfizanch175@gmail.com", "3114203350");


        }
    }
}
