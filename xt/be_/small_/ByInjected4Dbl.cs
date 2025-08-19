using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.be_.small_
{
	 public class ByInjected4Dbl
		:
		ext.Be4dblA,

		nilnul.num.real.ext.Be4dblI
	{
		public override bool _be_0ext(double x)
		{
			if (double.IsInfinity(x) )
			{
				return false;
			}

			return real.be_.AboutNil4Dbl.Injected._be_0finite(x);

		}

		public bool be(Ext4dblI val)
		{
			return _be_0ext( val.errable);
		}
		public bool be(Ext4dbl val)
		{
			return _be_0ext( val.errable);
		}

		 public bool be( double x) {
			return be(new Ext4dbl(x));
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
