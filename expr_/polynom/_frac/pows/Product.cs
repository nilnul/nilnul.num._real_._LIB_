using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic._frac.pows
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

		public IEnumerable<
				Pow
			> pows
		{ get { return boxed; } }
		public Product(IEnumerable<Pow> val) : base(val.ToList())
		{
		}
		public Product(params Pow[] val) : this(
			(IEnumerable<Pow>)val
		)
		{
		}

		public Product() : this(Enumerable.Empty<Pow>())
		{

		}

		public Product(VarI y):this(
			new Pow(y)
		)
		{
		}

		public Product(params VarI[] vars):this(
			(IEnumerable<VarI>)vars
		)
		{
		}

		public Product(IEnumerable<VarI> vars):this(
			vars.Select(v=>new Pow(v))
		)
		{
		}

		public Product toSimplify()
		{

			//partition accourding to var
			return new Product(
				this.boxed.GroupBy(p => p.basis).Select(
					g => new Pow(
						g.Key
						,
						g.Select(p=>p.index).Aggregate((BigInteger)0, (a,c)=>a+c)
					
					)
				).Where(
					p=>p.index!=0
				)
			);
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
					new[] { typeof(IEnumerable<num.RealI>) }
				)
				,
				this.boxed.Select(a => a.expr.ee)
			)
		//basis.sys
		);

		public override string ToString()
		{
			return $"{string.Join("*",boxed)}";
		}

		
		static public Product operator *(Product x, Product y) {
			return new Product(
				x.boxed.Concat(y.boxed)
			);
		}

		static public Product operator *(Product x, real.expr_.VarI y) {
			return new Product(
				x.boxed.Append(
					new Pow(y)
				)
			);
		}

	}
}
