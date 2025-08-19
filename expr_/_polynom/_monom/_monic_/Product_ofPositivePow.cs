using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.str;
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
	public class Product_ofPositivePow
		:
		nilnul.obj.Box1<
			List<
				Pow_indexPositive
			>
		>
		,
		AlgebraicI
	{

		public List<
				Pow_indexPositive
			> pows
		{ get { return boxed; } }

		public Product_ofPositivePow(List<Pow_indexPositive> val) : base(val)
		{
		}
		public Product_ofPositivePow(IEnumerable<Pow_indexPositive> val) : this(val.ToList())
		{
		}
		public Product_ofPositivePow(params Pow_indexPositive[] val) : this(
			(IEnumerable<Pow_indexPositive>)val
		)
		{
		}


		public Product_ofPositivePow(VarI y) : this(
			new Pow_indexPositive(y)
		)
		{
		}

		public Product_ofPositivePow(params VarI[] vars) : this(
			(IEnumerable<VarI>)vars
		)
		{
		}

		public Product_ofPositivePow(IEnumerable<VarI> vars) : this(
			vars.Select(v => new Pow_indexPositive(v))
		)
		{
		}
		[Obsolete("use the readonly instance, which calls this one only once rather than repeatedly", true)]
		public Product_ofPositivePow() : this(Enumerable.Empty<Pow_indexPositive>())
		{
			_simplified = true;
		}

		static public readonly Product_ofPositivePow One = new Product_ofPositivePow(Enumerable.Empty<Pow_indexPositive>())
		{
			_simplified = true
		};
		private bool _simplified;
		public void simplify()
		{
			if (_simplified)
			{
				return;
			}
			var changed = false;
			var t = boxed.AsParallel().GroupBy(p => p.basis) /*The GroupBy yields groupings, and no grouping is yielded before the source sequence is fully enumerated. The IGrouping<TKey,TElement> as a structure is internally just an immutable array with a Key property. It's a materialized collection, not a deferred enumerable. When the GroupBy yields a grouping, it contains all the elements of the source sequence that have the specific key. No other element is going to be added to it in the future.*/
			.Select(
				g =>
				{
					if (g.Count() > 1)
					{
						if (!changed)
						{
							changed = true;
						}
						return new Pow_indexPositive(
							g.Key
							,
							new num_.Positive1(
								nilnul.num.integer.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
								g.Select(p => (p.index.en))
								)
						));
					}
					else
					{
						return g.First();
					}

				}

			).ToList();
			if (changed)
			{
				boxed = t;
			}
			_simplified = true;
		}

		public Product_ofPositivePow toSimplify()
		{
			return asSimplify();
		}
		public Product_ofPositivePow asSimplify()
		{
			simplify();
			return this;
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
			if (boxed.Any())
			{
				return $"{string.Join("*", boxed)}";

			}
			return "1";
		}

		static public Algebraic operator +(Product_ofPositivePow x, Product_ofPositivePow y)
		{
			return new prod.Scaled_powIndexPositive(
				x
			) + y;
		}

		static public Algebraic operator +(
			Product_ofPositivePow x
			,
			_algebraic.Pow_indexPositive y
		)
		{
			return x + new Product_ofPositivePow(y);
		}

		//public void clear()
		//{
		//	this.boxed.Clear();
		//	_simplified = true;
		//	//throw new NotImplementedException();
		//}


		static public Product_ofPositivePow operator *(Product_ofPositivePow x, Product_ofPositivePow y)
		{
			return new Product_ofPositivePow(
				x.boxed.Concat(y.boxed)
			);
		}

		static public Product_ofPositivePow operator *(Product_ofPositivePow x, real.expr_.VarI y)
		{
			return new Product_ofPositivePow(
				x.boxed.Append(
					new Pow_indexPositive(y)
				)
			);
		}

	}
}
