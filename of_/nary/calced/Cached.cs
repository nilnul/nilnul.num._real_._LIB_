using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_.nary.calced
{
	/// <summary>
	/// cache the calculated
	/// </summary>
	public class Cached:
		nilnul.num.real.op_.nary._calced_.OpA
	{
		private nilnul.num.RealI _cache;

		public nilnul.num.RealI cache
		{
			get { return _cache; }
			set { _cache = value; }
		}

		public Cached(nilnul.num.real.op_.NaryI op):base(op)
		{
			_cache = op.op();
		}
		


	}
}
