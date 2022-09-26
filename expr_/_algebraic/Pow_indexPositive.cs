using nilnul._rel.mate_.monandry_.dict.be_.bijective.vow;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic
{
	/// <summary>
	/// as we only add and multi, so positive index forms a closure.
	/// </summary>
	public class Pow_indexPositive
		:
		nilnul.obj.Box1<
			nilnul.num.real.expr_.VarI
		>
		,
		AlgebraicI
	{
		private nilnul.num_.Positive1 _index;

		/// <summary>
		/// if index is nil, this can be transformed to 1.
		/// </summary>
		public nilnul.num_.Positive1 index
		{
			get { return _index; }
			set { _index = value; }
		}


		public nilnul.num.real.expr_.VarI	basis
		{
			get { return boxed; }
		}


		public Pow_indexPositive(
			VarI val
			,
			nilnul.num_.Positive1 index
		) : base(val)
		{
			_index = index;
		}
		public Pow_indexPositive(VarI val, int v) : this(val,new num_.Positive1(v))
		{
		}

		public Pow_indexPositive(VarI val) : this(val, new num_.Positive1(1))
		{
		}

		

		public override string ToString()
		{
			if (this._index.en ==1)
			{
				return $"{this.boxed}";

			}
			return $"{this.boxed}^{this._index}";
		}

		public Ee<RealI> generi => new Ee<RealI>(this);

		public Ee expr => new Ee(
			System.Linq.Expressions.MethodCallExpression.Call(
				typeof(real.op_.unary_._PolyX).GetMethod(
					nameof(
						real.op_.unary_._PolyX.RealI
					)
					,
					new[] { typeof(num.RealI), typeof(nilnul.num_.Positive1) }
				)
				,
				basis.sys
				,
				Expression.Constant(
					index
				)
			)
		//basis.sys
		);

		static public pows.prod.Scaled_powIndexPositive operator -(
			Pow_indexPositive pow

		) {
			return -new pows.prod.Scaled_powIndexPositive( pow ) ;
		}
		static public Algebraic operator +(
			Pow_indexPositive pow
			,
			Pow_indexPositive var

		) {
			return new pows.Product_ofPositivePow( pow ) + var;
		}

		static public Algebraic operator -(
			Pow_indexPositive pow
			,
			Pow_indexPositive var

		) {
			return ( pow ) + -var;
		}

		static public Algebraic operator +(
			Pow_indexPositive pow
			,
			num.real.expr_.VarI var

		) {
			return pow + var.AsPow();
		}



	}
}
