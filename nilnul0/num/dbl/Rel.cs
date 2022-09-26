using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.ieee
{
	public class Rel:nilnul.Rel_elementEqDefault<double,num.dbl.Eq,num.ieee.Duo>
	{
		public Rel()
		{

		}

		public Rel(IEnumerable<Duo> duos)
		{
			this.add(duos);
		}
	}
}
