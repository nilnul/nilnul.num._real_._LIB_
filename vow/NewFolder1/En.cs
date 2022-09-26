using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vow
{
[Obsolete()]
	public interface EnI : nilnul.obj.vow.EnI<num.RealI>
	{
	
	}

[Obsolete()]
	public abstract class EnA : nilnul.obj.vow.EnA<num.RealI>
		,
		EnI
	{
		public EnA(RealI val) : base(val)
		{
		}
	}
}
