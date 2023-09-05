using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = System.Double;



namespace nilnul.num.real.ext.border
{
	public class Co4dbl : nilnul.obj.Co< Border4dbl>
	{
		

		public Co4dbl(Border4dbl lower, Border4dbl upper) : base(lower, upper)
		{
		}

		static public implicit operator (Border4dbl, Border4dbl)(Co4dbl x) {

			return (x.component,x.component1);
		}
		static public implicit operator (Border4dblI, Border4dblI)(Co4dbl x) {

			return (x.component,x.component1);
		}


		static public Co4dbl CreateClopen(R lower, R upper) {
			return new Co4dbl(
				Border4dbl.CreateClose(lower)
				,
				Border4dbl.CreateOpen(upper)
			);
		}

		public static Co4dbl CreateGe(R lower)
		{

			return new Co4dbl(
				Border4dbl.CreateClose(lower)
				,
				Border4dbl.CreateOpen(nilnul.num.real.ext_.inf_.Pos4dbl.Singleton)
			);

		}
	}
}
