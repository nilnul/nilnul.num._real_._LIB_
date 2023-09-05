using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream
{
	
	public partial class NN
	{
		

		static public IEnumerable<BigInteger> GetItems()
		{
			for (int i = 0; ; i++)
			{
				yield return GetItem(i);
			}
			yield break;
		}
		static public IEnumerable<BigInteger> GetItems(int to)
		{
			return GetItems().Take(to);
		}

		static public BigInteger GetItem(int n)
		{


			//var t = 8 * i + 1;

			//var root = new real.op.Sqrt.CallOfN(t);

			//root.converge_lessThan1();



			/////wrong....
			//var t1 = real.op.Divide_posConverge2interval.Eval(real.op.Subtract3.Eval(root, 1), 2);

			//return op.Ceil.Eval(t1);


			//var t = n * (

			//	real.op.Exp_baseIndex.Eval(
			//		10, (n *
			//		floor(log_10(10n)).
			//                 ) - 1
			//	)

			//	/

			//	(10 ^ floor(log_10(10n)). - 1)





			//;
			throw new NotImplementedException();

		}


	}
}
