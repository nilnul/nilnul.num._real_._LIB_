using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.bound_.closed.re_.sup_
{
	/// <summary>
	/// 
	/// </summary>
	public class Proper : closed.Re4dblI
	{
		

		public bool re(ClosedDbl a, ClosedDbl b)
		{
			return a.avowed.lower.mark < b.avowed.lower.mark && a.avowed.upper.mark > b.avowed.upper.mark;
			//throw new NotImplementedException();
		}


		static public Proper Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Proper>.Instance;
			}
		}

	}
}
