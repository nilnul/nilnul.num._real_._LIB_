using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow.ee_
{
	public class VowDefault4Float<TVow> : vow.Ee4float
	where TVow : nilnul.obj.VowI2<float>, new()
	{
		public VowDefault4Float(float val) : base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
	}
}
