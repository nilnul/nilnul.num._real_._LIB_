using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream
{
	public class Co : nilnul.obj.Co<num.real.StreamI>
	{
		public Co(Tuple<StreamI, StreamI> tuple) : base(tuple)
		{
		}

		public Co(StreamI item1, StreamI item2) : base(item1, item2)
		{
		}
	}
}
