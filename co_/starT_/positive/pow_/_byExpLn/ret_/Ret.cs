using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.RealI;

using N = nilnul.num.natural.Natural_bigInteger;

using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using q = nilnul.num.quotient;
using nilnul.num.real_;
using nilnul.num.real.be_.positive.vow;

namespace nilnul.num.real.co_.starT_.positive._pow
{
	public class Ret
		:
		
		nilnul.num.real_.PositiveI1,
		R
	{



		private R _expLn;



		public Ret(real_.Positive1 base_, R index)

		{
			//this._index = index;
			////_taylorSeries = real.Rational_posConverge2Bounded.NewZero();

			////_termIndex = 0;


			//this._base = base_;



			_expLn = nilnul.num.real.op_.unary_.Exp.Op(
				nilnul.num.real.op_.binary_.Multi.Singleton.op(
					index
					,
					nilnul.num.real_.positive.ln_._ByReverseExpX.Ln(base_)
				)

			);


		}

		public Ret(NonnegI nonneg, R index):this( new nilnul.num.real_.Positive1(nonneg),index)
		{

		}

		 public Ret (R base0, R index):this(new real_.Positive1(base0), index)
		{
			
		}
		public q.Bound bound
		{
			get
			{
				return _expLn.bound;

				//throw new NotImplementedException();
			}
		}

		public En real => new En(this);

		public void squeeze(nilnul.num.quotient_.Positive1 diameter)
		{
			_expLn.squeeze(diameter);
			//throw new NotImplementedException();
		}


	}
}
