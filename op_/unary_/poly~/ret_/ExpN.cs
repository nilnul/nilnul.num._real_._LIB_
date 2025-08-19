using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using N1 = nilnul._num.bigint.be.Natural.Asserted;
using R1 = nilnul.num.RealI2;

using nilnul.num.real.op;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;

namespace nilnul.num._real.approach.duo.op_._pow.ret_
{


	[Obsolete(nameof(approach.op_._poly.Ret))]
	public class ExpN
		:  ApproachI1
	{

		static public ApproachI1 Eval(ApproachI1 base_, N1 _index)
		{



			var half = nilnul.num.op_.Half.Singleton.eval(_index);  //.natural.op.DivideX.Half(_index);

			var anotherHalf = _index.val - half.val;


			if (anotherHalf == 0)
			{
				return num._real.approach_.Quotient.CreateOne();


			}
			if (anotherHalf == 1)
			{
				if (half.val == 0)
				{
					return base_;
				}
				return Multi.Square(base_);

			}



			return Multi.Eval(
				 Eval(base_, half)
				,

				Eval(base_, new N1(anotherHalf))



			);

		}





		private ApproachI1 _base;

		public ApproachI1 base_
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


		public ExpN(ApproachI1 base_, N1 index)

		{
			this._base = base_;
			this.index = index;
			_binaryMulti__set();



		}

		public ExpN(ApproachI1 base_, BigInteger index)
			: this(base_, new nilnul._num.bigint.be.Natural.Asserted(index))

		{




		}


		private ApproachI1 _binaryMulti;

		private void _binaryMulti__set()
		{

			_binaryMulti = Eval(base_, index);


		}







		public Nonempty.En bound
		{
			get
			{
				return _binaryMulti.bound;

				throw new NotImplementedException();

			}
		}



		public void clamp(Positive1.En diameter)
		{
			_binaryMulti.clamp(diameter);
			return;
			throw new NotImplementedException();
		}


	}
}
