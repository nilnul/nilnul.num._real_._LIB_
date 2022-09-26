using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows
{
	/// <summary>
	/// when the args are empty, this is one.
	/// </summary>
	public class Product
		:
		nilnul.obj.Box1<
			IEnumerable<
				Pow
			>
		>
		,
		AlgebraicI
	{
		public Product(IEnumerable<Pow> val) : base(val)
		{
		}

		public Product():this(Enumerable.Empty<Pow>())
		{

		}

		/// <summary>
		/// eg:
		///		a^2 * b * a^3
		///		= a^5 * b
		/// </summary>
		public void simplify() {

			//partition accourding to var
			this.boxed = this.boxed.GroupBy(p => p.basis).Select(
				g => new Pow(
					g.Key
					,
					nilnul.num.accumulate_._SumX.Eval1(g.Select(p=> new Num1(p.index )))
				)
			);
		}
		public Product toSimplify() {

			//partition accourding to var
			return new Product( this.boxed.GroupBy(p => p.basis).Select(
				g => new Pow(
					g.Key
					,
					nilnul.num.accumulate_._SumX.Eval1(g.Select(p=> new Num1(p.index )))
				)
			));
		}


		public override string ToString()
		{
			return string.Join("*",boxed);
		}

		public Ee<RealI> generi => new Ee<RealI>(this);

		public Ee expr => new Ee(
			//((Expression<Func<IEnumerable<RealI>,RealI> >)( s=>real.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(s) )).Body.
			System.Linq.Expressions.MethodCallExpression.Call(
				Expression.Constant(
real.op_.binary_.multi.cumulator.Cumulate.Singleton
					)
				,
				typeof(real.op_.binary_.multi.cumulator.Cumulate).GetMethod(
					nameof(
						real.op_.binary_.multi.cumulator.Cumulate.cumulate
					)
					,
					new[] { typeof(IEnumerable< num.RealI>)}
				)
				,
				this.boxed.Select(a=>a.expr.ee)
			)
		//basis.sys
		);

		static public Product operator *(Product x, Product y)
		{

			return new Product(
				x.boxed.Concat(y.boxed)
			);

		}


	}
}
