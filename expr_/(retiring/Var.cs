using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;

namespace nilnul.num.real
{
	public interface VarI:
		nilnul.VarI1<R>
	{
	}

	public class Var: nilnul.Var1<R>
		,
		VarI
	{

	}
}
