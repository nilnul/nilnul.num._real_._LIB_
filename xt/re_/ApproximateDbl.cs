using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.ext.re_
{
	/// <summary>
	/// symmectric
	/// reflexive
	/// not transitive
	/// </summary>
	public class Approximate4dbl 
		:
		nilnul.obj.Box_ofIn<nilnul.num.real.ext.be_.Small4dbl>
		,
		nilnul.num.real.ext.Re4dblI
	{
		public Approximate4dbl(in real.ext.be_.Small4dbl val) : base(val)
		{
		}

		public Approximate4dbl(real.ext.be_.Small4dbl x) : base(x)
		{
		}

		public Approximate4dbl(nilnul.num.real_.NonnegOfDouble val) : this(new real.ext.be_.Small4dbl( val) )
		{
		}

		

		public Approximate4dbl(int i) : this(new real_.NonnegOfDouble(i))
		{
		}

		public Approximate4dbl(double x) : this(
			new real_.NonnegOfDouble(x)
		)
		{

		}

		public Approximate4dbl():this(double.Epsilon)
		{

		}




		static public Approximate4dbl CreateByAbs(double x) {
			return new Approximate4dbl(
				nilnul.num.real_.nonneg.coerce_._AbsX.Doub(x)
			);
		}
		public bool _re_01ext(double a, double b)
		{
			
			return boxed._be_0ext( ext.of_.binary_.Minus.Singleton._op_01ext(a,b) );
		}

		public bool re(Ext4dblI a, Ext4dblI b)
		{
			return _re_01ext(a.errable, b.errable);
		}
		public bool re(Ext4dbl a, Ext4dbl b)
		{
			return re((Ext4dblI)a, (Ext4dblI)b);
		}
		public bool re(double a, double b)
		{
			return re(new Ext4dbl(a), new Ext4dbl(b));
		}

		static public Approximate4dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Approximate4dbl>.Instance;
			}
		}



	}
}
