using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V = nilnul.num.real.Var1;
namespace nilnul.num.real.var
{
	[Obsolete(nameof(nilnul.num.real.var.set._naming.Extensions))]
	static public class NamingX
	{
		static public V Create(string name) {

			return nilnul.var.set.NamingContext_ofVarI.Instance.createVar<V>(name);

		}
	}
}
