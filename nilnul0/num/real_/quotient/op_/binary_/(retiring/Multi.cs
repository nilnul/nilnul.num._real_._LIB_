using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.quotient.combine_
{
	[Obsolete()]
	public class Multi:CombineI
	{

		static public readonly Multi Singleton = SingletonByDefault<Multi>.Instance;


		public Quotient eval(num.Quotient arg, num.Quotient arg1)
		{
			return new num.Quotient(
					arg.q- arg1.q				
				);

			//throw new NotImplementedException();
		}
	}
}
