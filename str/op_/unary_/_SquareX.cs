using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI;

namespace nilnul.num.real.str.op_.unary_
{
	static public class _SquareX
	{
		static public IEnumerable<double> Square(this IEnumerable<double> a) {
			return  a.Select(x=> nilnul.num.real.op_.unary_.Square.Lazy.op(x));
		}

		static public IEnumerable<R> Square(this IEnumerable<R> a) {
			return  a.Select(x=> nilnul.num.real.op_.unary_.Square.Lazy.op(x));
		}

		static public IEnumerable<decimal> Square(this IEnumerable<decimal> a) {
			return  a.Select(x=> nilnul.num.real.op_.unary_.Square.Lazy.op(x));
		}

		public static IEnumerable<double> Square((double, double) arg)
		{
			return Square(nilnul.obj.vec.to_.ToStrX.ToStr5(arg));
		}
		public static IEnumerable<double> Square((double, double,double) arg)
		{
			return Square(nilnul.obj.vec.to_.ToStrX.ToStr5(arg));
		}
		public static IEnumerable<double> Square((double, double,double,double) arg)
		{
			return Square(nilnul.obj.vec.to_.ToStrX.ToStr5(arg));
		}
		public static IEnumerable<double> Square((double, double,double,double,double) arg)
		{
			return Square(nilnul.obj.vec.to_.ToStrX.ToStr5(arg));
		}



	}
}
