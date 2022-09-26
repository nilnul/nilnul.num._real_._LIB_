using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.interval.funcs.be_
{
	/// <summary>
	/// intervals are chain. 
	/// </summary>
	public interface PiecewiseI
		:funcs.BeI
	{


	}
	public class Piecewise : PiecewiseI
	{
		public bool be(FuncsI obj)
		{
			return nilnul.num.real.intervals.be_.Chain.Singleton._be( obj.Select(x => x.domain));
			throw new NotImplementedException();
		}

		static public readonly Piecewise Singleton = nilnul.obj.SingletonByDefault<Piecewise>.Instance;

	}

}
