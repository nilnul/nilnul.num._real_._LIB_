using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.num.real.Var1;

namespace nilnul.num.real.var.set._naming
{
	static public class Extensions
	{
		static public V Create(string name) {

			return nilnul.txt_.names.fro_.Vars.Instance.createVar<V>(name);

		}
	}
}
