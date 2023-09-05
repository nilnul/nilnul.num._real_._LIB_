using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.str.seed.op
{
	public partial class Max
	{

		static public double Eval(IEnumerable<double> doubleS_headed) { 

				if (doubleS_headed.Count()==1)
			{
				return doubleS_headed.First();
				
			}
			return Math.Max(doubleS_headed.First(),Eval(doubleS_headed.Skip(1)));

		}
		static public double Eval(params double[] doubleS_noEmpty) {
			return Eval(doubleS_noEmpty as IEnumerable<double>);
			
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
