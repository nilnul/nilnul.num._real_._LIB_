using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_
{
	public class Rounded
	{
		private BigInteger _integer;

		public BigInteger integer
		{
			get { return _integer; }
			set { _integer = value; }
		}

		private nilnul.num.RealI _acute;

		/// <summary>
		/// a real that is lt one.
		/// </summary>
		public nilnul.num.RealI acute
		{
			get { return _acute; }
			//set { _acute = value; }
		}
		public Rounded(nilnul.num.RealI real)
		{
			_integer = nilnul.num.real.to_.Round.Eval(real);

			_acute = nilnul.num.real.op_.binary_.Minus.Singleton.op(real, _integer);

		}

		//static public Rounded Create(nilnul.num.RealI real) {
		//	var rounded = nilnul.num.real.to_.Round.Eval(real);


			

		//	var expressed = arg - rounded * (nilnul.num.real_.Tau.Singleton.ToReal() / 4);  //+round* tau/4	     //pi/2
		//}

	}
}
