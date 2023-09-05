using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_.geometric_
{
	/// <summary>
	/// x^0, x^1, x^2,..., x^n,...
	/// </summary>
	public class Std:nilnul.num.real.stream_.SliderA
		,
		nilnul.obj.stream_.slider_._FuncI
	{

		public Std( R rate)
		{
			this._rate = rate;
		}
		private R _rate;

		private nilnul.num.RealI _accumulated= new nilnul.num.real_.Quotient(1);

		public override R current => _accumulated;

		public override void moveNext()
		{
			_accumulated= nilnul.num.real.op_.binary_.Multi.Singleton.op(_accumulated, _rate);

		}


		public void setIndex(Num1 num)
		{
			_accumulated = nilnul.num.real.op_.unary_._PolyX.RealI(_rate, num);
			//throw new NotImplementedException();
		}

		public void moveNext(Num1 num)
		{
			_accumulated *= nilnul.num.real.op_.unary_._PolyX.RealI(_rate, num).ToReal();
			//throw new NotImplementedException();
		}
	}
}
