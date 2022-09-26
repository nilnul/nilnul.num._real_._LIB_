using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.intervals.be_
{
	/// <summary>
	/// disjoint.
	/// ordered.
	/// adjacent
	/// </summary>
	public class Chain : BeI
	{
		public bool be(IntervalsI obj)
		{
			if ( nilnul.objs.be_._NoneX.None(obj))
			{
				return true;
			}
			return nilnul.num.real.intervals_.started.be_.Chain.Singleton._be(obj);
			//throw new NotImplementedException();
		}

		public bool _be(IEnumerable<Interval> obj)
		{

			if ( nilnul.objs.be_._NoneX.None(obj))
			{
				return true;
			}
			return nilnul.num.real.intervals_.started.be_.Chain.Singleton._be(obj);

			//throw new NotImplementedException();
		}

		static public readonly Chain Singleton = nilnul.obj.SingletonByDefault<Chain>.Instance;

	}
}
