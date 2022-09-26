using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.positives_.started.op_.unary_.map_
{
	public class InvertDbl : MapDbl
	{
		

		public InvertDbl() : base(x=>1/x)
		{
		}


		static public InvertDbl Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<InvertDbl>.Instance;
			}
		}

	}
}
