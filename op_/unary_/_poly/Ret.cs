using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.Num1;//.natural.Natural_bigInteger;
using R = nilnul.num.RealI;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using N1 = nilnul.Num1;
using R1 = nilnul.num.RealI;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num.real.op_.unary_._poly
{



	public class Ret
		:  R
	{




		private R _base;

		public R base_
		{
			get { return _base; }
			set { _base = value; }
		}



		private N1 _index;

		public N1 index
		{
			get { return _index; }
			set { _index = value; }
		}


		public Ret(R base_, N1 index)

		{
			this._base = base_;
			this.index = index;
			_binaryMulti__set();



		}

		public Ret(R base_, BigInteger index)
			: this(base_, new nilnul.Num1(index))

		{




		}


		private R _binaryMulti;

		private void _binaryMulti__set()
		{

			_binaryMulti = Eval(base_, index);


		}



		public nilnul.num.quotient.Bound bound
		{
			get
			{
				return _binaryMulti.bound;


			}
		}



		public void squeeze(nilnul.num.quotient_. Positive1 diameter)
		{
			_binaryMulti.squeeze(diameter);
		}


	}
}
