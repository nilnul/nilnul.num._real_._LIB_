using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.str_.enumerable.be_
{
	public class Distrinct : BeI
	{
		public bool be(IEnumerable<double> obj)
		{
			return nilnul.str.be.DistinctX.IsDistinct(obj, dbl.Eq.Lazy);

			//throw new NotImplementedException();
		}

		static private Lazy<Distrinct> _Lazy = new Lazy<Distrinct>();
		static public Distrinct Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
