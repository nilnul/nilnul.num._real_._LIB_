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
	public class FuncSeeded : 
		
		BeI
	{
		public bool be(Rel obj)
		{
			return Func.Lazy.be(obj) && Seeded.Lazy.be(obj)  ;

			//throw new NotImplementedException();
		}

		public class En : nilnul.obj.be.En_beDefaultable<Rel, FuncSeeded>
		{
			public En(Rel val) : base(val)
			{

			}
		}
	}
}
