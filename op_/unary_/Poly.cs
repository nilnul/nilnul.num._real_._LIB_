using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.num_;
using Q = nilnul.num.Quotient1;
using R = nilnul.num.RealI;//.R;//.RealI;

namespace nilnul.num.real.op_.unary_
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///		x^y. where x>0, and y is natural.
	///		we require x>0, 'cuz we define x^y as e^(xln(y)) in line with the duo.op_.Pow.
	///		we require y is natural in that:
	///			1) when y is natural , the computation rules are quite different from when y is not.
	///			2) when y is natural, this is a Polynomial expression. This why we call this poly.
	///		we put this as an op_ rather than and duo.op_ in that:
	///			1) the y here is a natural number, which is not in the scope of the Real Number realm, and thus is deepd sub-par / not on the same level to be talked with x. y should be ready cooked in a depended project.
	///			2) the y should be taken as part of the op_; it's in the rules. It's not part of the argument. In fact, we can form an op_ first by putting y in its consturctor first, before we applying the op_ onto the x, which is a RealNumber.
	///		The above triangulates that the name is Poly and it's an op_ rather than duo.op_
	///		
	///		Note: when x^y has y as unitary faction, we can this root.
	/// </remarks>
	public class Poly
		: nilnul.obj.Box<nilnul.Num1>
		,
		UnaryI
		,
		_unary_.RetRealOnRealI
		,
		IPoly
	{




		//static public R Op(Q base_, Q index)
		//{
		//	return
		//		approach.duo.op_.Pow.Eval(
		//			approach.op_.Root._Eval(base_, index.denominator)

		//			,

		//			index.numerator
		//			)

		//		;




		//}
		public Poly(nilnul.Num1 degree) : base(degree)
		{
		}

		public Poly(Plural degree) : this(degree.ed)
		{
		}

		public R op(R par)
		{
			return _PolyX.RealI_baseUnsureQuotient(par, this.boxed);
		}

		public Real op_retReal(RealI par)
		{
			return UnaryX.RetReal(this, par);
		}

		
	}
}
