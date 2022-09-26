using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.border.duo
{
	public  class Ed<T>
		: nilnul.obj.vow.Ed<ext.border.Duo, T>
		where T: nilnul.obj.VowI<ext.border.Duo>,new()
	{
		public Ed(Duo val) : base(val)
		{
		}
	}
}
