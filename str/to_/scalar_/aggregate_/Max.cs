using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R = nilnul.num.RealI;


namespace nilnul.num.real.aggregate_
{
	public class Max
	{
		static public R Eval(IEnumerable<R> doubleS_headed)
		{

			if (doubleS_headed.Count() == 1)
			{
				return doubleS_headed.First();

			}
			return nilnul.num.real.op_.binary_.Max.Op(doubleS_headed.First(), Eval(doubleS_headed.Skip(1)));

		}
		static public R Eval(params R[] doubleS_noEmpty)
		{
			return Eval(doubleS_noEmpty as IEnumerable<R>);

		}
	}
}
