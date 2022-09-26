using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod._scaled
{
	public class Coef
		:
			nilnul.num.real.expr_.call_.Nary1
		//,
		//AlgebraicI

	{
		public Coef(RealI arg) : base(arg)
		{
		}

		public Coef(NumI1 y) : base(y)
		{
		}

		public Coef(int v):this(new Num1(v))
		{
		}
		public Coef():this(1)
		{

		}




		public Coef negate()
		{
			return new Coef(
				 -this.constant.ToReal()
			);

		}
		static public Coef operator -(Coef x)
		{
			return new Coef(
				 -x.constant.ToReal()
			);

		}
		static public _algebraic.pows.prod.scaleds.Sum_powIndexPositive operator +(Coef x, real.expr_.VarI y)
		{
			return new pows.prod.scaleds.Sum_powIndexPositive(
				 x
				 ,
				 y
			);
		}
		static public Coef operator *(Coef x, Coef y)
		{
			return new Coef(
				 x.constant.ToReal() * y.constant
			);
		}
		static public Coef operator *(Coef x, int y)
		{
			return new Coef(
				 x.constant.ToReal() * y
			);
		}

		static public Coef operator *( int y, Coef x)
		{
			return new Coef(
				 x.constant.ToReal() * y
			);
		}

		//static public _algebraic.pows.prod.Scaled_powIndexPositive operator *(Coef x, real.expr_.VarI y)
		//{
		//	return new pows.prod.Scaled_powIndexPositive(
		//		 x
		//		 ,
		//		 y
		//	);
		//}
		//public override string ToString()
		//{
		//	return base.ToString();
		//}

		public bool isNil()
		{
			return nilnul.num.real.be_.Nil.Singleton.be(this.constant);
			//throw new NotImplementedException();
		}
	}
}
