using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.str_.enumerable.be_
{
	public class Started : BeI
	{
		public bool be(IEnumerable<double> obj)
		{
			return obj.Any();

			//throw new NotImplementedException();
		}

		static private Lazy<Started> _Lazy = new Lazy<Started>();
		static public Started Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}



	}
}
