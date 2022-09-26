using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream
{
	public interface ClonableI
		:
		nilnul.num.real.StreamI
		//,
		//nilnul.obj.ClonableI<nilnul.num.real.StreamI3>
		,
		nilnul.obj.ClonableI<nilnul.num.real.stream.ClonableI>

	{
	}
}
