using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.stream_.slider_.arithmetic_
{
	/// <summary>
	/// constant stream * natural stream
	/// </summary>
	public class Std
		:
		nilnul.num.real.stream_.SliderA
		,
		nilnul.num.real.stream_._func_.OnNumeroI
	{

		public Std( R rate)
		{
			this._rate = rate;
		}
		private R _rate;

		private nilnul.num.RealI _accumulated= new nilnul.num.real_.Quotient(0);

		public override R current => _accumulated;

		public override void moveNext()
		{
			_accumulated= nilnul.num.real.op_.binary_.Add.Singleton.op(_accumulated, _rate);

		}

		public R term(NumI1 numero)
		{
			return _rate.ToReal() * numero;
		}


		static public nilnul.num.RealI Term(
			nilnul.num.Real rate
			,
			nilnul.Num1 numero
		)
		{


			return numero * rate;
		}


		static public nilnul.num.RealI Term(
			nilnul.num.RealI rate
			,
			nilnul.Num1 numero
		)
		{

			return Term(rate.ToReal(), numero);
		}
		static public nilnul.num.RealI Term(
			nilnul.num.RealI rate
			,
			nilnul.NumI1 numero
		)
		{

			return Term(rate,  new Num1(numero) );
		}

	}
}
