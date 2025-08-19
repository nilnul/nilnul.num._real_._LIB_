using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.num.real.str.op
{
	public partial class Min
	{
		static public double Eval(IEnumerable<double> doubleS_headed) { 

				if (doubleS_headed.Count()==1)
			{
				return doubleS_headed.First();
				
			}
			return Math.Min(doubleS_headed.First(),Eval(doubleS_headed.Skip(1)));

		}
		static public double Eval(params double[] doubleS_noEmpty) {
			return Eval(doubleS_noEmpty as IEnumerable<double>);
			
		}
	}
}
