using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_AdacPOM
{
	[TestClass]
	public class search_Tm : Base
	{
		searchloc obj = new searchloc();

		[TestMethod]
		public void Searchvaliditem()
		{
			Base.SetDriver("Chrome");


			obj.Searchkey("Mocassino");


		}
	}
}