using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = System.Double;



namespace nilnul.num.real.ext.border
{
	static public class _Co4dblX 
	{


		static public (
				Border4dbl
				,
				Border4dbl
			) CreateClopen(R lower, R upper) {
			return (
				Border4dbl.CreateClose(lower)
				,
				Border4dbl.CreateOpen(upper)
			);
		}
		static public (
				Border4dbl
				,
				Border4dbl
			) CreateClopen(R lower) {
			return (
				Border4dbl.CreateClose(lower)
				,
				Border4dbl.CreateOpen( Ext4dbl.PosInf)
			);
		}


		public static (
				Border4dbl
				,
				Border4dbl
			) CreateGe(R lower)
		{

			return (
				Border4dbl.CreateClose(lower)
				,
				Border4dbl.CreateOpen(nilnul.num.real.ext_.inf_.Pos4dbl.Singleton)
			);

		}
	}
}
