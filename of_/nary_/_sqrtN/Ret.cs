using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.num.rational.be;
using nilnul.num.rational.bound.pair.be;
using N = nilnul.num.natural.Natural_bigInteger;
using N1 = nilnul.Num;

using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using System.Numerics;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.construct_._sqrtN
{
	public class Ret
		: ApproachI1
	{
		private N1 _arg;

		public N1 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		

		private quotient.border.duo.be_.Nonempty.En interval;
		public Ret(int arg) : this(new N1(arg))
		{
		}

		public Ret(N1 arg)
		{
			_arg = arg;

			_ini();

		}
		public Ret(BigInteger arg)
			: this(new N1(arg))
		{


		}

		public void _ini()
		{

			interval = (nilnul.num.quotient.Range) nilnul.num.cast_.Sqrt.Singleton.cast(_arg);




		}





		public quotient.border.duo.be_.Nonempty.En bound
		{
			get
			{

				throw new NotImplementedException();
			}
		}

		public void converge_lessThan1()
		{
			return;

			//converge(1);

		}

		public void converge(int i)
		{
			converge(new Positive.Asserted(i));
		}

		public void converge(Positive.Asserted diameter)
		{

			throw new NotImplementedException();
		}

		public void clamp(Positive1.En diameter)
		{
			if (interval.notSpanLessThan(diameter))
			{
				var middle = interval.midPoint;

				var middleSquare = middle * middle;
				var argSquare = _arg * arg;
				var compareResult = nilnul.num.quotient.Comparer1.Singleton.Compare(middleSquare, argSquare);

				if (compareResult == 0)
				{
					interval = quotient.border.duo.be_.Nonempty.En.CreateSingleton(middle);
					
				}
				else
				if (compareResult < 0)
				{
					interval = new quotient.border.duo.be_.Nonempty.En(quotient.Border1.CreateOpen(middle), interval.upper);
				}
				else
				{
					interval = new quotient.border.duo.be_.Nonempty.En(
						interval.lower, quotient.Border1.CreateOpen(middle));

				}

			}
			return;

			throw new NotImplementedException();
		}
	}
}
