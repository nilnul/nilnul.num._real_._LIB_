using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.var
{
	public interface StrI
		:nilnul.obj.StrI2< nilnul.num.real.VarI>
		
		

	{

	}
	public class Str :
		nilnul.obj.str_.Seq2<nilnul.num.real.VarI>
		,
		StrI
	{
		public Str(IEnumerable<VarI> boxed) : base(boxed)
		{
		}

	
	}
}
