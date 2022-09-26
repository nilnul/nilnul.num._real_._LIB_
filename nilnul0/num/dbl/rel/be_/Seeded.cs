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
	public class Seeded : BeI
	{
		public bool be(Rel obj)
		{
			return obj.Any();

			//throw new NotImplementedException();
		}


		static private Lazy<Seeded> _Lazy = new Lazy<Seeded>();
		static public Seeded Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}


		public class En : nilnul.obj.be.En_beDefaultable<Rel, Seeded>
		{
			public En(Rel val) : base(val)
			{

			}
		}
	}
}
