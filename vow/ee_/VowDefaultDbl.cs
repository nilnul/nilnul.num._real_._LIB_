using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow.ee_
{
	public class VowDefaultDbl<TVow> : vow.EeDbl
	where TVow : nilnul.obj.VowI2<double>, new()
	{
		public VowDefaultDbl(double val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
