using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.intervals_.started.be_
{
	/// <summary>
	/// disjoint.
	/// ordered.
	/// adjacent
	/// </summary>
	public class Chain : BeI
	{
		public bool be(intervals_.Started obj)
		{
			return _be(obj);
		}

		public bool _be(IEnumerable<Interval> _started)
		{
			if ( nilnul.objs.be_._NoneX.None(_started))
			{
				return true;
			}

			var skipped = nilnul.objs_.started._TailX._Tail(_started);

			return
				nilnul.num.real.ext.border.re_.Joinder.Singleton.re(
					_started.First().ed.upper
					,

					skipped.First().ed.lower
				)
				&&
				_be(skipped)
			;
		}

		static public readonly Chain Singleton = nilnul.obj.SingletonByDefault<Chain>.Instance;



	}
}
