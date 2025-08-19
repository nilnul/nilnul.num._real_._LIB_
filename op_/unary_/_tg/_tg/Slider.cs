using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;


namespace nilnul.num._real.approach.op_._tg
{
	/// <summary>
	/// use the power series. cofficient is Bernoulli number. The residual is hard to estimate for only asymptonic series can be found. Asymptonic series can guarantee it's convergent. But cannot be used to estimate the error since we stopped at a finite "k"th term, at this point the subsequent terms may still be large as asympton can only guarantee when n is infinite.
	/// I gave up. Maybe we should use Sin / Cos.
	/// </summary>
	public class Slider
		:
		nilnul.num.quotient.Arg
		,
		nilnul.num.quotient.SliderI
	{

		private nilnul.num.quotient.slider_.geometric_.PolyOdd _polyOdd;

		private Q1 _current;

		public Slider(Q1 arg) : base(arg)
		{
			_polyOdd
			_current = arg;
		}

		public Q1 current
		{
			get
			{
				return _current;
				throw new NotImplementedException();
			}
		}

		

		public void moveNext()
		{


			throw new NotImplementedException();
		}
	}
}
