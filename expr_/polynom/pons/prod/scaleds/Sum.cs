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

namespace nilnul.num.real.expr_.algebraic.pons.prod.scaleds
{
	/// <summary>
	/// a sum of product. 
	/// </summary>
	public class Sum
		

	{
		private List<Scaled> _scaleds;

		public List<Scaled> scaleds
		{
			get { return _scaleds; }
			set { _scaleds = value; }
		}

		public Sum(List<Scaled> scaleds)
		{
			_scaleds = scaleds.ToList();
		}
		public Sum(IEnumerable<Scaled> scaleds)
		:this(
			scaleds.ToList()
		)
		{
		}

		public Sum(params Scaled[] scaleds)
			: this(
				 (IEnumerable<Scaled>)scaleds
			)
		{
		}

		public Sum(IEnumerable<Product> scaleds)
			: this(
				  scaleds.Select(x=>
				 new Scaled(x)
				 )
			)
		{
		}
		public Sum(params Product[] scaleds)
			: this(
				 (IEnumerable<Product>)scaleds
			)
		{
		}



		public Sum(RealI x, VarI y)
			: this(
				 new Scaled(x)
				 ,
				 new Scaled(y)
			)
		{
		}

		public Sum(int x, VarI y)
			: this(
				 new Scaled(x)
				 ,
				 new Scaled(y)
			)
		{
		}

		public Sum(Algebraic y)
			: this(
				  new Scaled(y)
				 
			)
		{
		}

		public Sum(VarI y)
			: this(
				  new Scaled(y)
				 
			)
		{
		}

		//[Obsolete()]
		public Sum(int v) : this(
			v==0?Enumerable.Empty<Scaled>()
			: new[] {
			new Scaled(v)
			}
		)
		{
		}
		public Sum() : this(Enumerable.Empty<Scaled>())
		{

		}

		static public Sum Of(int i) {
			return i == 0 ?  Sum.Nil :( i==1? Sum.One: new Sum(i));
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
				s1 => s1.product
				,
				algebraic.pons.prod.Eq.Singleton
			).Select(
					g =>
					{
						if (g.Count() > 1)
						{
							if (!isChanged)
							{
								isChanged = true;
							}

							return new Scaled(
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


		public Sum asSimplify()
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



		public static readonly Sum Nil = new Sum();
		public static readonly Sum One = new Sum(1);

		public static readonly Sum NegOne = new Sum(-1);


		static public Sum operator -(Sum x)
		{
			return new Sum(
				x.scaleds.Select(s => -s)
			);
		}

		static public Sum operator +(Sum x, Sum y)
		{
			return new Sum(
				x.scaleds.Concat(y.scaleds)
			);
		}
		static public Sum operator +(Sum x, Scaled y)
		{
			return x + new Sum(
				y
			);
		}

		static public Sum operator +(Sum x, Product y)
		{
			return x + new Scaled(
				y
			);
		}
		static public Sum operator +(Sum x, Ponent y)
		{
			return x + new Product(
				y
			);
		}

		static public Sum operator +(Sum x, nilnul.num.real.expr_.VarI y)
		{
			return x + new Ponent(
				y
			);
		}

		static public Sum operator -(Sum x, Sum y)
		{
			return
				x + -y
			;
		}

		static public Sum operator *(Sum x, Sum y)
		{
			return new Sum(
				nilnul.obj.str.strung.op_.binary_._CartesianX.Seq(
					x.scaleds, y.scaleds
				).Select(c => c.Item1 * c.Item2)
			);
		}

		static public Sum operator *(Sum x, Algebraic y)
		{
			return new Sum(
				x._scaleds
				.Select(
					c => c * y
				)
			);
		}

		static public Sum operator * (Algebraic y, Sum x)
		{
			return new Sum(
				x._scaleds
				.Select(
					c =>  y*c
				)
			);
		}



		static public Sum operator *(Sum x, nilnul.num.RealI y)
		{
			return new Sum(

					x.scaleds
				.Select(c => c * y)
			);
		}
		static public Sum operator *( nilnul.num.RealI y, Sum x)
		{
			return new Sum(

					x.scaleds
				.Select(c =>  y*c)
			);
		}

		static public Sum operator *(Sum x, int y)
		{
			return x * new nilnul.num.real_.Quotient(y);
		}
		static public Sum operator *(int y, Sum x)
		{
			return new nilnul.num.real_.Quotient(y)*x  ;
		}

		static public Sum operator /(Sum x, int y)
		{
			return x * new nilnul.num.real_.Quotient(1,y);
		}

		static public bool operator ==(Sum x, Sum y)
		{
			return prod.scaleds.sum.Eq.Singleton.Equals(x,y);
		}
		static public bool operator !=(Sum x, Sum y)
		{
			return !(x==y);
		}
	}
}