using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._quotient.fraction.op;
using nilnul.num.quotient.radix;
using nilnul.num.quotient_;

namespace nilnul.num.real.ext.re_.approx_.byBe_
{
	/// <summary>
	/// </summary>
	public class ByInjected4Dbl 
		:
		Re4dblA
		,
		nilnul.num.real.ext.Re4dblI
	{
		public ByInjected4Dbl()
		{
		}

		public bool _re_01ext(double a, double b)
		{
			return real.ext.be_.small_.ByInjected4Dbl.Singleton._be_0ext(a - b);
		}

		public override bool re(Ext4dblI a, Ext4dblI b)
		{
			return real.ext.be_.small_.ByInjected4Dbl.Singleton.be(
				ext.of_.binary_.Minus.Singleton.op(
					a , b
				)
			);
		}

		static public ByInjected4Dbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ByInjected4Dbl>.Instance;
			}
		}
	}
}