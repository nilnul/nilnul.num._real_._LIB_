using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._stream;
using nilnul.obj._stream_;
using R = nilnul.num.RealI;
using Rx = nilnul.num.Real;

namespace nilnul.num.real.stream_
{
	/// <summary>
	/// √2(√2√2 ...)
	/// The limit is 2.
	/// </summary>
	public class RecurSqrtTwo
		: nilnul.num.real.StreamI
	{

		private Rx _pre=2;

		public Rx pre
		{
			get { return _pre; }
			//set { _pre = value; }
		}

		static public readonly Rx Two = 2;

		public R next()
		{
			return _pre=Two * _pre.sqrt();
		}

		

		public void reset()
		{
			_pre=2;
		}
	}
}
