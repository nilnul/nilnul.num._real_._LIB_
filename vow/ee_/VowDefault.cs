using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow.ee_
{
	public class VowDefault<TVow> : vow.Ee
	where TVow : nilnul.obj.VowI2<RealI>, new()
	{
		public VowDefault(RealI val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
