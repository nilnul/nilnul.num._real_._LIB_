using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.algebraic.pons
{
	public class Product
	{
		private List<Ponent> _ponents;
		public static readonly Product One = new Product();


		public List<Ponent> ponents
		{
			get { return _ponents; }
			set { _ponents = value; }
		}

		public Product(List<Ponent> ponents)
		{
			this._ponents = ponents;
		}

		public Product(IEnumerable<Ponent> enumerable):
			this(
				enumerable switch {
					List<Ponent> list=>list
					,
					_=> enumerable.ToList()
				}
			)
		{
		}
		public Product(params Ponent[] product):this((IEnumerable<Ponent>) product)
		{
		}

		public Product():this(
			new List<Ponent>()
		)
		{

		}

		public Product(IEnumerable<VarI> vars):this(vars.Select(v=> new Ponent(v)))
		{
		}



		public Product(params VarI[] vars):this((IEnumerable<VarI>)vars)
		{
		}

		static public Product operator *(
			Product product
			,
			Product ponent
		) {
			return new Product(
				product.ponents.Concat(ponent.ponents)
			);
		}
		static public Product operator *(
			Product product
			,
			Ponent ponent
		) {
			///important to make the expression readonly in an equivalent sense.
			return new Product(
				product.ponents.Append(ponent)
			);
		}
		static public Product operator *(
			Ponent ponent
			,
			Product product
		) {
			///important to make the expression readonly in an equivalent sense.
			return new Product(
				product.ponents.Prepend(ponent)
			);
		}

		static public Product operator *(
			Product product
			,
			Algebraic ponent
		) {
			return product* new Ponent(ponent);
		}
		static public Product operator *(
			Algebraic ponent
			,

			Product product
		) {
			return new Ponent(ponent) * product ;
		}

		static public Product operator *(
			Product product
			,
			real.expr_.VarI ponent
		) {
			return product* new Algebraic(ponent);
		}

		private bool _simplified;
		public void simplify()
		{
			if (_simplified)
			{
				return;
			}
			var changed = false;
			var t = this._ponents.AsParallel().GroupBy(
				p => p.basis
				,
				algebraic.Eq.Singleton

			) /*The GroupBy yields groupings, and no grouping is yielded before the source sequence is fully enumerated. The IGrouping<TKey,TElement> as a structure is internally just an immutable array with a Key property. It's a materialized collection, not a deferred enumerable. When the GroupBy yields a grouping, it contains all the elements of the source sequence that have the specific key. No other element is going to be added to it in the future.*/
			.Select(
				g =>
				{
					if (g.Count() > 1)
					{
						if (!changed)
						{
							changed = true;
						}
						return new Ponent(
							g.Key
							,
							nilnul.num.integer.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
								g.Select(p => (p.index))
							)
						);
					}
					else
					{
						return g.First();
					}

				}

			).ToList();
			if (changed)
			{
				this._ponents = t;
			}
			_ponents.RemoveAll(
				p=>p.index==0
			); /// todo: if divideByZero exception is taken into account, we need to construct a derivation system:
			/// 1) a contextual posits
			/// 2) a precontext case-by-case "if-condition" is prepended to each axiomatic subsystem, when the needed posit is not deductable from the posits.
			_simplified = true;
		}

		
		public Product asSimplify()
		{
			simplify();
			return this;
		}

	}
}
