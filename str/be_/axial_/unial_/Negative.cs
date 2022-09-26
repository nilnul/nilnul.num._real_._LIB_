using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.str.be_.axisal_.unital_
{
	public class Negative
		:
		num.real.str.Be4dblI
	{
		public bool be(IEnumerable<double> obj)
		{
			var beginOne = obj.SkipWhile(x => x == 0);
			if (beginOne.Any())
			{
				if (beginOne.First() ==-1 )
				{
					return beginOne.Skip(1).All(a=>a==0);
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
			//throw new NotImplementedException();
		}

		static public Negative Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Negative>.Instance;
			}
		}

	}
}
