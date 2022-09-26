using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_._algebraic.pows.prod.scaleds
{
	public class Sum
		:AlgebraicI

	{
		private IEnumerable< Scaled> _scaleds;

		public IEnumerable< Scaled> scaleds
		{
			get { return _scaleds; }
			set { _scaleds = value; }
		}

		public Sum(IEnumerable< Scaled> scaleds)
		{
			_scaleds = scaleds;
		}

		public Sum(params  Scaled[] scaleds)
			:this(
				(IEnumerable< Scaled>)scaleds
			)
		{
		}

		public Sum():this(Enumerable.Empty<Scaled>())
		{

		}


		public override string ToString()
		{
			return string.Join("+", _scaleds);
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

		static public  Sum operator -(Sum x)
		{
			return new Sum(
				x.scaleds.Select(s => s.negate())
			);
		}

	}
}
