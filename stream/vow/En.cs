using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.vow
{
	public class En<TVow> : nilnul.obj.vow.En<nilnul.num.real.StreamI>
		where TVow : real.stream.VowI
	{
		public En( TVow vow, StreamI val) : base( vow,val)
		{
		}
	}
}
