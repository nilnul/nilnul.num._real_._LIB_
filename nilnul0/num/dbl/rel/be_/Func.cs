using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.slew;
using nilnul.slew;
using nilnul.slew;
using nilnul.obj;

namespace nilnul.num.ieee.rel.be_
{
	/// <summary>
	/// each x has only one or zero y.
	/// </summary>
	public class Func : BeI
	{
		public bool be(Rel obj)
		{
			return nilnul.num.ieee.str_.enumerable.be_.Distrinct.Lazy.be( obj.Select(x=>x.Item1) );

			//throw new NotImplementedException();
		}


		static private Lazy<Func> _Lazy = new Lazy<Func>();
		static public Func Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		public class En : nilnul.obj.be.En_beDefaultable<Rel, Func>
		{
			public En(Rel val) : base(val)
			{

			}
		}
	}
}
