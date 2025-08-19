using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using N = nilnul.num.natural.Natural_bigInteger;

using Q = nilnul.num.rational.Rational_InheritFraction2;

namespace nilnul.num.real.solo.op
{
	public partial class Sqrt
	{
		public class CallOfN
			:RealI_posConverge2NonEmpty
		{
			private N _arg;

			public N arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			private Q _lower;

			public Q lower
			{
				get { return _lower; }
				set { _lower = value; }
			}

			private Q _upper;

			public Q upper
			{
				get { return _upper; }
				set { _upper = value; }
			}

			public CallOfN(N arg)
			{
				_arg = arg;

				_ini();

			}

			public void _ini() {

				var interval = nilnul.num.natural.op.SqrtX._Eval_ofNatural_retInterval(_arg);

				_lower = interval.Item1;
				_upper = interval.Item2;

				
			}



			public Nonempty.Asserted interval
			{
				get
				{
					if (_lower!=_upper)
					{
						return Nonempty.Asserted.CreateOpen(_lower, _upper);
					}
					else
					{
						return Nonempty.Asserted.CreateSingleton(_lower);
					}
					
					throw new NotImplementedException();
				}
			}

			public void converge(Positive.Asserted diameter)
			{
				if (interval.notSpanLessThan(diameter))
				{
					var middle = (_lower + _upper )/ 2;

					var middleSquare = middle * middle;
					var argSquare = _arg * arg;
					var compareResult = nilnul.num.rational.order.Comparer1.Eval(middleSquare, argSquare);

					if (compareResult==0)
					{
						_lower = middle;
						_upper = middle;
					}else
					if (compareResult<0)
					{
						_lower = middle;


					}
					else
					{
						_upper = middle;
					}

				}
				return;
				throw new NotImplementedException();
			}
		}
	}
}
