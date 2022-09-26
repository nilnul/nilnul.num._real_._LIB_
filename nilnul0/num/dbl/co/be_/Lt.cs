using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.num.ieee.duo.be_
{
	/// <summary>
	/// begin le end
	/// </summary>
	public class Lt : BeI
	{
		public bool be(Duo obj)
		{
			return obj.Item1 < obj.Item2;
		}

		public class En : nilnul.obj.be.En_beDefaultable<Duo, Lt>
		{
			

			public En(Duo val) : base(val)
			{
			}

			public En(double x, double x1)
				:this(new Duo(x,x1))
			{
				
			}
		}
	}
}
