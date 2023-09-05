using nilnul._rel.mate_.monandry_.dict.be_.bijective.vow;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac
{
	/// <summary>
	/// </summary>
	/// alias:
	///		indicand
	public class Pow
		:
		nilnul.obj.Box1<
			nilnul.num.real.expr_.VarI
		>
		,
		num.real.expr_.algebraic.IFrac
		,
		FracI
	{
		private BigInteger _index;

		/// <summary>
		/// if index is nil, this can be transformed to 1.
		/// </summary>
		/// alias:
		///		indic
		public BigInteger index
		{
			get { return _index; }
			set { _index = value; }
		}


		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		radic
		///		basic
		public nilnul.num.real.expr_.VarI	basis
		{
			get { return boxed; }
		}


		public Pow(
			VarI val
			,
			BigInteger index
		) : base(val)
		{
			_index = index;
		}
		public Pow(
			VarI val
			,
			nilnul.num_.Positive1 index
		) : this(val, index.en)
		{
		}

		public Pow(VarI val, int v) : this(val,(BigInteger)(v))
		{
		}

		public Pow(VarI val) : this(val, (1))
		{
		}


		public override string ToString()
		{
			if (this._index ==0)
			{
				return $"{1}";
			}
			if (this._index ==1)
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
						real.op_.unary_._IndexX.RetRealI
					)
					,
					new[] { typeof(num.RealI), typeof(BigInteger) }
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

		public Pow toInverse() {
			return new Pow(
				this.basis
				,
				-this.index
			);
		}

		static public pows.Product operator *(Pow a, Pow b) {
			if (a.basis == b.basis)
			{
				return new pows.Product(
					new Pow(a.basis,a.index+b.index)
				);
			}
			return new pows.Product(
				a,b
			);
		}

		static public pows.Product operator *(Pow a, real.expr_.VarI b) {
			if (a.basis == b)
			{
				return new pows.Product(
					new Pow(a.basis,a.index+1)
				);
			}
			return new pows.Product(
				a,new Pow( b)
			);
		}



	}
}
