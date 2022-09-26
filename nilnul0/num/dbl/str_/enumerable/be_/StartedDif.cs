using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee.str_.enumerable.be_
{
	public class StartedDif :
		nilnul.obj.be_.FroAnd_defaultable<IEnumerable<double>, Distrinct,Started>
		,
		BeI
	{
		

		static private Lazy<StartedDif> _Lazy = new Lazy<StartedDif>();
		static public StartedDif Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		public class En :
			nilnul.obj.be.En_beDefaultable<IEnumerable<double>, StartedDif>
		{
			public En(IEnumerable<double> val) : base(val)
			{

			}
		}


	}
}
