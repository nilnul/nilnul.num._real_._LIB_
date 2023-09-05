using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.num.real.stream_.slider_
{
	/// <summary>
	/// -ln(n) + (sum(1/k) as k from 1 to n), as n approaches infinity. about 0.57721566
	/// </summary>
	/// <remarks>
	/// 	/*欧拉常数又称欧拉-马斯克若尼常数，近似值为γ≈0.57721 56649 01532 86060 65120 90082 40243 10421 59335。*/
	/// </remarks>
	public class EulerConstant1 : num.real.StreamI
	{
		private BigInteger _n;

		public BigInteger n
		{
			get { return _n; }
			set { n = value; }
		}

		public nilnul.num.quotient.stream_.unitary.Series harmonic = new quotient.stream_.unitary.Series();
		public EulerConstant1()
		{
			harmonic.moveNext(); // the current  changes from 0, to 1/1
		}

		public RealI next()
		{
			_n++;

			return op_.binary_.Minus.Singleton.op(
				harmonic.next(),
				nilnul.num.real_.positive.ln_._ByReverseExpX.RetRealI(_n)
			);

		}


	}
}
