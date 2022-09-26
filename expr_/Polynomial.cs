using System.Collections.Generic;
using System.Linq;

namespace nilnul.num.real.expr_
{
	public class Polynomial : PolynomialI
	{
		/// <summary>
		/// note the start one is the constant(which is of pow nil). the lower powered comes first.
		/// </summary>
		IEnumerable<nilnul.num.RealI> _coefficients;

		public IEnumerable<nilnul.num.RealI> coefficients {
			get {
				return _coefficients;
			}
		}

		nilnul.num.real.VarI _var;
		public nilnul.num.real.VarI var {
			get {
				return _var;
			}
		}


		public Polynomial(
			nilnul.num.real.VarI var,
			IEnumerable<nilnul.num.RealI> coefs
		)
		{
			_coefficients = coefs;
			_var = var;

		}

		public var.Set vars => new var.Set(_var);

		public ExprI substitute(
			real.VarI var
			,
			ExprI expr
		)
		{
			if (this._var == var)
			{
				return new nilnul.num.real.expr_.call_.aggregated_.Sum(
					this._coefficients.Select(
						(c, i) => new nilnul.num.real.expr_.call_.unary_.Poly(expr, i
							)
					)
			);
			}
			else
			{
				return this;
			}
			//throw new NotImplementedException();
		}
	}
}
