using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.str_.started
{
	static public  class _MaxX
	{

		static public double Max(IEnumerable<double> doubleS_headed) { 

				if (doubleS_headed.Count()==1)
			{
				return doubleS_headed.First();
				
			}
			return Math.Max(doubleS_headed.First(),Max(doubleS_headed.Skip(1)));

		}
		static public double Max(params double[] doubleS_noEmpty) {
			return Max(doubleS_noEmpty as IEnumerable<double>);
			
		}

		static public int Index(
			IEnumerable<double> doubleS_headed
		) {
			var r = 0;

			for (int i = 1; i < doubleS_headed.Count(); i++)
			{
				if (doubleS_headed.ElementAt(i) >doubleS_headed.ElementAt(r))
				{
					r = i;
				}

				
			}
			return r;
		
		}
	}
}
