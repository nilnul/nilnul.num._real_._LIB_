using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;



namespace nilnul.num.real.ext.border
{
	public class Duo : nilnul.border.Duo1<ExtI, Border>
	{
		

		public Duo(Border lower, Border upper) : base(lower, upper)
		{
		}

		static public Duo CreateClopen(R lower, R upper) {
			return new Duo(
				Border.CreateClose(lower)
				,
				Border.CreateOpen(upper)
			);
		}

		public static Duo CreateClopen(R lower)
		{

			return new Duo(
				Border.CreateClose(lower)
				,
				Border.CreateOpen(nilnul.num.real.ext_.inf_.Pos.Singleton)
			);

		}
	}
}
