using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.nonneg.co.vow.ee_
{
	public class VowDefault4Dbl<TVow>
		:
		vow.Ee
		where TVow : nilnul.obj.VowI2<nonneg.CoDbl>,new()
	{
		public VowDefault4Dbl(CoDbl val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
				)
		{
		}
	}
}
