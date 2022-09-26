using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using N = nilnul.num.natural.Natural_bigInteger;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;
using nilnul.num.quotient.be_;
using nilnul.num.quotient.border.duo.be_;
using nilnul.num.quotient_;

namespace nilnul.num.real_.positive.op_.unary_._root.ret_
{
	[Obsolete("",true)]
	public class DegreePlural
		:
		nilnul.obj.Box<real_.Positive>,
		nilnul.num.RealI
	{


		private nilnul.num_.Plural _degree;
		public nilnul.num_.Plural degree
		{
			get { return _degree; }
			set { _degree = value; }
		}


		public DegreePlural(
			real_.Positive radicand
			,
			nilnul.num_.Plural degree

			) : base(radicand)

		{
			this._degree = degree;



			var lowerRooted = nonneg.op_.unary_._RootX.RetRealI(radicand.current.lower.mark, degree);
			var upperRooted = nonneg.op_.unary_._RootX.RetRealI(radicand.current.upper.mark, degree);


			//var lowerBorder = new nilnul.num.quotient.Border2(radicand.current.lower.openFalseCloseTrue && lowerRooted.current.lower.openFalseCloseTrue, lowerRooted.current.lower.mark);


			//var upperBorder = new nilnul.num.quotient.Border2(
			//	radicand.current.upper.openFalseCloseTrue
			//	&& upperRooted.current.upper.openFalseCloseTrue
			//	,
			//	upperRooted.current.upper.mark
			//);



			_bound = new num.quotient.bound_.Closed(
				lowerRooted.current.lower.mark
				,
				upperRooted.current.upper.mark
			);





		}


		private num.quotient.bound_.Closed _bound;
		public num.quotient.bound_.Closed current
		{
			get
			{
				return _bound;
			}
		}


		public void squeeze(num.quotient_.Positive1 diameter)
		{

			_bound = nilnul.num.real.op_.unary_.injective_.upward._inverse._ret_._clamp._NarrowSrcX.DomainNarrowDown(
boxed,new num.real.op_.unary_.Poly(_degree),
				_bound,   diameter
			);

		}


	}
}
