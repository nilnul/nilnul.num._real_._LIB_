using nilnul.num.integer._ext;
using System.CodeDom;

namespace nilnul.num
{
	public class Real4dbl
		:
		nilnul.num.quotient_.radix.ext.errable_.ieee_.bin.be_.finite.vow.Ee
		,
		Real4dblI
		//,
		//IReal

	{
		public Real4dbl(in double val) : base(val)
		{
		}

		public Real4dbl(double val) : base(val)
		{
		}

		static public readonly Real4dbl Nil = new Real4dbl(0);
		static public readonly Real4dbl One = new Real4dbl(1);

		static public readonly Real4dbl NegOne = new Real4dbl(-1);


		static public Real4dbl operator -(Real4dbl x) {
			if (x.errable==0)
			{
				return x;
			}
			return new Real4dbl(-x.errable);
		}

		static public Real4dblI operator /(Real4dbl x,Real4dblI y) {
			return new Real4dbl(
				x.errable/y.errable /// might be NaN; but the wrapping ctor would throw exception thence;
			);
		}

		public double errable => this.eeByRef;


	}
}
