//using nilnul.num.real.expr_._algebraic.pows.prod._scaled;
using nilnul.num.real.expr_._algebraic;
using nilnul.num.real.expr_._algebraic.pows;
using nilnul.num.real.expr_._algebraic.pows.prod;
using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_
{
	/// <summary>
	/// a sum of product. 
	/// </summary>
	public class Algebraic
		: AlgebraicI

	{
		private List<Scaled_powIndexPositive> _scaleds;

		public List<Scaled_powIndexPositive> scaleds
		{
			get { return _scaleds; }
			set { _scaleds = value; }
		}

		public Algebraic(List<Scaled_powIndexPositive> scaleds)
		{
			_scaleds = scaleds.ToList();
		}
		public Algebraic(IEnumerable<Scaled_powIndexPositive> scaleds)
		:this(
			scaleds.ToList()
		)
		{
		}

		public Algebraic(params Scaled_powIndexPositive[] scaleds)
			: this(
				 (IEnumerable<Scaled_powIndexPositive>)scaleds
			)
		{
		}

		public Algebraic(IEnumerable<Product_ofPositivePow> scaleds)
			: this(
				 scaleds.Select(p => new Scaled_powIndexPositive(p))
			)
		{
		}
		public Algebraic(params Product_ofPositivePow[] scaleds)
			: this(
				 (IEnumerable<Product_ofPositivePow>)scaleds
			)
		{
		}

		public Algebraic(Pow_indexPositive pow):this(
			new Product_ofPositivePow(pow)
		)
		{

		}



		public Algebraic(RealI x, VarI y)
			: this(
				 new Scaled_powIndexPositive(x)
				 ,
				 new Scaled_powIndexPositive(y)
			)
		{
		}

		public Algebraic(int x, VarI y)
			: this(
				 new Scaled_powIndexPositive(x)
				 ,
				 new Scaled_powIndexPositive(y)
			)
		{
		}

		public Algebraic(VarI y)
			: this(
				  new Scaled_powIndexPositive(y)
				 
			)
		{
		}

		//[Obsolete()]
		public Algebraic(int v) : this(
			v==0?Enumerable.Empty<Scaled_powIndexPositive>()
			: new[] {
			new Scaled_powIndexPositive(v)
			}
		)
		{
		}
		public Algebraic() : this(Enumerable.Empty<Scaled_powIndexPositive>())
		{

		}

		static public Algebraic Of(int i) {
			return i == 0 ?  Algebraic.Nil :( i==1? Algebraic.One: new Algebraic(i));
		}

		public bool isNotNil()
		{
			return this.asSimplify()._scaleds.Any();
		}

		public bool isNil()
		{
			return !isNotNil();
		}

		private bool _simplified;
		public void simplify()
		{
			if (_simplified)
			{
				return;
			}

			var isChanged = false;

			var changed = _scaleds.AsParallel().GroupBy(
				s1 => s1.product, _algebraic.pows.prod.Eq.Singleton
			).Select(
					g =>
					{
						if (g.Count() > 1)
						{
							if (!isChanged)
							{
								isChanged = true;
							}

							return new Scaled_powIndexPositive(
								g.Select(s => s.coef).Aggregate(
									(a, c) => nilnul.num.real.op_.binary_.Add.Singleton.op(a, c)
								)
								//nilnul.num.real.op_.binary_.add.cumulator.Cumulate.Singleton.cumulate(
								//	g.Select(s2 => s2.coef)
								//)
								,
								g.Key
							);

						}
						return g.First();

					}
			).ToList();

			if (isChanged)
			{
				_scaleds = changed;
			}

			_scaleds.Each(
				s => s.simplify()
			);
			_scaleds.RemoveAll(
				s => s.isNil()
			);

			_simplified = true;

		}

		[Obsolete(nameof(asSimplify) + ". the simplification as a work per efficicency is not lost .")]
		public Algebraic toSimplify()
		{
			return asSimplify();
			
		}
		public Algebraic asSimplify()
		{
			simplify();
			return this;

		}


		public override string ToString()
		{
			var c = scaleds.Count();
			if (c == 0)
			{
				return "0";
			}
			if (c == 1)
			{
				return _scaleds.First().ToString();
			}


			return _scaleds.First().ToString()
				
				+
			string.Join(
				""
				,
				_scaleds.Skip(1).Select(
					s => $@"{
						(
							s.coef.ToReal() < 0 ? "" /*minus is already prepended for the scaled*/
							: "+"
						)
					}{
						s
					}"
				)
			);

		}


		public Ee<RealI> generi => new Ee<RealI>(this);


		public Ee expr => new Ee(
			//((Expression<Func<IEnumerable<RealI>,RealI> >)( s=>real.op_.binary_.multi.cumulator.Cumulate.Singleton.cumulate(s) )).Body.
			System.Linq.Expressions.MethodCallExpression.Call(
				Expression.Constant(
real.op_.binary_.add.cumulator.Cumulate.Singleton
					)
				,
				typeof(real.op_.binary_.add.cumulator.Cumulate).GetMethod(
					nameof(
						real.op_.binary_.add.cumulator.Cumulate.cumulate
					)
					,
					new[] { typeof(IEnumerable<num.RealI>) }
				)
				,
				this._scaleds.Select(a => a.expr.ee)
			)
		//basis.sys
		);

		public static readonly Algebraic Nil = new Algebraic();
		public static readonly Algebraic One = new Algebraic(1);

		public static readonly Algebraic NegOne = new Algebraic(-1);


		static public Algebraic operator -(Algebraic x)
		{
			return new Algebraic(
				x.scaleds.Select(s => -s)
			);
		}

		static public Algebraic operator +(Algebraic x, Algebraic y)
		{
			return new Algebraic(
				x.scaleds.Concat(y.scaleds)
			);
		}
		static public Algebraic operator +(Algebraic x, Scaled_powIndexPositive y)
		{
			return x + new Algebraic(
				y
			);
		}

		static public Algebraic operator +(Algebraic x, Product_ofPositivePow y)
		{
			return x + new Scaled_powIndexPositive(
				y
			);
		}
		static public Algebraic operator +(Algebraic x, Pow_indexPositive y)
		{
			return x + new Product_ofPositivePow(
				y
			);
		}

		static public Algebraic operator +(Algebraic x, nilnul.num.real.expr_.VarI y)
		{
			return x + new Pow_indexPositive(
				y
			);
		}

		static public Algebraic operator -(Algebraic x, Algebraic y)
		{
			return
				x + -y
			;
		}

		static public Algebraic operator *(Algebraic x, Algebraic y)
		{
			return new Algebraic(
				nilnul.obj.str.strung.op_.binary_._CartesianX.Seq(
					x.scaleds, y.scaleds
				).Select(c => c.Item1 * c.Item2)
			);
		}

		static public Algebraic operator *(Algebraic x, nilnul.num.RealI y)
		{
			return new Algebraic(

					x.scaleds
				.Select(c => c * y)
			);
		}
		static public Algebraic operator *( nilnul.num.RealI y, Algebraic x)
		{
			return new Algebraic(

					x.scaleds
				.Select(c =>  y*c)
			);
		}

		static public Algebraic operator *(Algebraic x, int y)
		{
			return x * new nilnul.num.real_.Quotient(y);
		}
		static public Algebraic operator *(int y, Algebraic x)
		{
			return new nilnul.num.real_.Quotient(y)*x  ;
		}

		static public Algebraic operator /(Algebraic x, int y)
		{
			return x * new nilnul.num.real_.Quotient(1,y);
		}
		static public algebraic.Frac operator /(Algebraic x, Algebraic y)
		{
			return new algebraic.Frac(x,y);
		}

		static public algebraic.Frac operator /(int y, Algebraic x )
		{
			return y* algebraic.Frac.Inverse(x);
		}


		


		static public bool operator ==(Algebraic x, Algebraic y)
		{
			return algebraic.Eq.Singleton.Equals(x,y);
		}
		static public bool operator !=(Algebraic x, Algebraic y)
		{
			return !(x==y);
		}








	}
}
