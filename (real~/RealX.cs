using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI2;
using Qq = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using N = nilnul._num.bigint.be.Natural.Asserted;
namespace nilnul.num.real.all
{
	/// <summary>
	/// Wrap a real with operators
	/// </summary>
	/// 
	[Obsolete()]
	public class RealX
		: nilnul.Box1<R>
		,
		R
	{
		
		public RealX(R v):base(v)
		{

		}
		public GeneratorI choice
		{
			get
			{
				return boxed.choice;
				//throw new NotImplementedException();
			}
		}

		public  RealX poly( N n) {
			return nilnul.num.real.op_.Poly.Singleton.eval(this, n).ToX();
		}

		public static RealX Div(int v, R diameter)
		{
			return  nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(v, diameter).ToX();

			throw new NotImplementedException();
		}

		public RealX sqrt() {
			return nilnul.num.real_.nonNeg.op_.Sqrt.Singleton.eval( this.boxed).ToX();
		}

		
		static public implicit operator RealX(real_.Quotient q) {
			return new RealX(q);
		}

		static public implicit operator RealX(Qq q) {
			return new nilnul.num.real_.Quotient(q);
		}


		static public implicit operator RealX(int q) {
			return new RealX((real_.Quotient) q);
		}




		////this will not compile
		//static public implicit operator RealX(R q)
		//{
		//	return new RealX(q);
		//}

		static public RealX operator +(RealX a, RealX b) {
			return new RealX( nilnul.num.real.duo.op_.Add.Singleton.eval(a, b));
		}

		static public RealX operator +(RealX a, R b) {
			return new RealX( nilnul.num.real.duo.op_.Add.Singleton.eval(a, b));
		}


		static public RealX operator -(RealX a, RealX b) {
			return new RealX( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}

		static public RealX operator -(R  a, RealX b) {
			return new RealX( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}
		static public RealX operator -(RealX  a, R b) {
			return new RealX( nilnul.num.real.duo.op_.Minus.Singleton.eval(a, b));
		}
		static public RealX operator -(RealX  a ) {
			return new RealX( nilnul.num.real.op_.Negate.lazy.eval(a));
		}

		static public bool operator <=(RealX a, RealX b) {
			return nilnul.num.real.Comparer.Decider.Singleton.le(a, b);
		}
		static public bool operator <(RealX a, RealX b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, b);
		}
		static public bool operator <(R  a, RealX b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a, b);
		}
		static public bool operator <(RealX  a, R  b) {
			return nilnul.num.real.Comparer.Decider.Singleton.lt(a.boxed, b);
		}

		static public RealX Sqrt(RealX a) {
			return nilnul.num.real.op_.Sqrt.Singleton.eval(a).ToX();
		}
		static public RealX Sqrt(R a) {
			return nilnul.num.real.op_.Sqrt.Singleton.eval(a).ToX();
		}
		static public RealX Squar(R a) {
			return nilnul.num.real.op_.Square.Singleton.eval(a).ToX();
		}

		static public bool operator >(RealX a, RealX b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, b);
		}
		static public bool operator >(R  a, RealX b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a, b);
		}
		static public bool operator >(RealX  a, R  b) {
			return nilnul.num.real.Comparer.Decider.Singleton.gt(a.boxed, b);
		}

		static public bool operator >=(RealX a, RealX b) {
			return nilnul.num.real.Comparer.Decider.Singleton.ge(a, b);
		}

		static public RealX operator *(RealX a, RealX b) {
			return new RealX( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}

		static public RealX operator *(R a, RealX b) {
			return new RealX( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}
		static public RealX operator *(RealX a, R b) {
			return new RealX( nilnul.num.real.duo.op_.Multi.Singleton.eval(a, b));
		}

		static public RealX operator /(RealX a, RealX b) {
			return new RealX( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public RealX operator /(RealX a, N b) {
			return new RealX( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public RealX operator /(R a, RealX b) {
			return new RealX( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}
		static public RealX operator /(RealX a, R b) {
			return new RealX( nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(a, b));
		}

		static public RealX operator /(Qq a, RealX b) {
			return new RealX( 
				nilnul.num.real.duo_.divisible.op_.Div.Singleton.eval(
					a
					, 
				
					b.boxed
				)
			);
		}




		static public RealX operator *(Qq a, RealX b) {
			return new RealX( 
				
				nilnul.num.real.op_._ScaleX.Scale(a, b)
				
				);
		}

	


		static public RealX CreateOne() {
			return 1;
		}

		static public RealX CreateZero() { return 0; }
		
	}
}
