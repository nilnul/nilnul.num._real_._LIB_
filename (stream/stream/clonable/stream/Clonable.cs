using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.clonable.stream
{
	public interface ClonableI
		:
		nilnul.obj.StreamI1<
			nilnul.num.real.stream.ClonableI
		>,
		nilnul.obj.ClonableI<nilnul.num.real.stream.clonable.stream.ClonableI>

	{
	}
}
