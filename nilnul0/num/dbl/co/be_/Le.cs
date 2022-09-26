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
	public class Le : BeI
	{
		public bool be(Duo obj)
		{
			return obj.Item1 <= obj.Item2;
		}

		public class En : nilnul.obj.be.En_beDefaultable<Duo, Le>
		{
			public En(Duo val) : base(val)
			{
			}

			public bool beReflexive {
				get {
					return avowed.Item1 == avowed.Item2;
				}
			}


		}
	}
}
