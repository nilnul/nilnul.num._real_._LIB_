using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.be_.small_
{
	 public class ByInjected4Dbl
		:nilnul.num.real_.nonneg.Be4dblI
	{

		public bool be(in NonnegOfDoubleI val)
		{
			return injected.be(in val);
		}
		public bool be( NonnegOfDoubleI val)
		{
			return injected.be(in val);
		}
		public bool be( NonnegOfDouble val)
		{
			return injected.be( val);
		}

		 public bool be( double x) {
			return be(new NonnegOfDouble(x));
		}

		/// <summary>
		/// this can be changed before call this
		/// </summary>
		public  Small4dbl injected = new Small4dbl(double.Epsilon * 1000);

		public  void setInjected(double x)
		{
			injected = new Small4dbl(x);
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
