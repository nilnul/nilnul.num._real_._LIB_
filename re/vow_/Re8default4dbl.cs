using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.re.vow_
{
	public class Re8default4dbl<T>
		: real.re.Vow4dbl
		where T : nilnul.num.real.ReDblI, new()
	{


		public Re8default4dbl() : base(nilnul._obj.typ_._UnisonX<T>.Unison)
		{
		}


		static public Re8default4dbl<T> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Re8default4dbl<T>>.Unison;
			}
		}

	}
}
