using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.expr_.polynomial.eval_
{
	static public class _HornerX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_coefs_indexAsIndic">
		///a[0] + a[1]*x +a[2] * x^2 + ...
		/// </param>
		/// <param name="assigned"></param>
		/// <returns></returns>
		static public double Eval(IEnumerator<double> _coefs_indexAsIndic, double assigned) {
			var r = 0d;
			while (_coefs_indexAsIndic.MoveNext())
			{
				r= r*assigned+_coefs_indexAsIndic.Current;
			}
			return r;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_coefs_indicBig1st">
		///a[0] * x^n + a[1] * x^(n-1) +a[2] * x^(n-22) + ... + a[n] * x^0
		/// </param>
		/// <param name="assigned"></param>
		/// <returns></returns>
		static public double _Eval_indicBig1st(IEnumerator<double> _coefs_indicBig1st, double assigned) {
			var r = 0d;
			while (_coefs_indicBig1st.MoveNext())
			{
				r= r*assigned+_coefs_indicBig1st.Current;
			}
			return r;
		}

		static public double _Eval_indicBig1st(IEnumerable<double> coefs, double assigned) {
			return _Eval_indicBig1st(coefs.GetEnumerator(),assigned);
		}

		static public double _Eval_indicLittle1st(IEnumerable<double> coefs, double assigned) {
			return _Eval_indicBig1st(coefs.Reverse(),assigned);
		}


	}
}
