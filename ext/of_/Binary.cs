using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.ext.op_
{
	public interface IBinary
		:IOp
	{ }
	public interface BinaryI: nilnul.obj.op_.BinaryI<num.real.ExtI>, num.real.ext.IOp
	{
	}
}
