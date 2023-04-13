using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
    [TestClass]
    public class FilterMtd
    {
        filterloc obj2 = new filterloc();
        [TestMethod]
        public void applyfilter()
        {
            Base.SetDriver("chrome");
            obj2.MoveToElement();
        }
    }
}