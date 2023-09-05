using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.op_
{
	public interface IOf:
		real.IOp
		,
		nilnul.obj.op_.IOf<num.IReal>

	{
	}

	public interface IOf<T>
		:
		IOf
		,
		nilnul.obj.IOp<IReal,T>
	{
	}


}
