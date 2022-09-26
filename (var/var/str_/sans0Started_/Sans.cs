using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.var.str_.sans0Started_
{
	public interface SansI
		:
		real.var.StrI
		,
		real.var.str_.Sans0StartedI
	{

	}
	public class Sans:
		nilnul.obj.str_.sans0Started_.Sans<num.real.VarI>
		,
		SansI
	{


		static public Sans Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sans>.Instance;
			}
		}

	}
}
