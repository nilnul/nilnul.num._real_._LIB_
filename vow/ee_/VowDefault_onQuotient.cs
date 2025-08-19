using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow.ee_
{
	public class VowDefault_onQuotient<TVow> : vow.Ee_onQuotient
	where TVow : nilnul.obj.VowI_ofIn<num.RealI_onQuotient>, new()
	{
		public VowDefault_onQuotient(num.RealI_onQuotient val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
