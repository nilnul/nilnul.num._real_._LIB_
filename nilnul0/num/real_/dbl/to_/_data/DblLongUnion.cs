using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real_.dbl.to_._data
{
	[StructLayout(LayoutKind.Explicit)]
	struct DoubleLongUnion
	{
		[FieldOffset(0)]
		public ulong data;
		[FieldOffset(0)]
		public double val;
	}
	/*
var union = new DoubleLongUnion();
union.Double = 1.234d;
var longBytes = union.Long;	 
	 */
}
