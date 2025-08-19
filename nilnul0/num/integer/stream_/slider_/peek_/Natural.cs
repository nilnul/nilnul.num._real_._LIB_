using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.integer.stream_.slider_.peek_
{
	public class Natural
		:
		nilnul.obj.stream_.slider_.Peek<BigInteger>
		,
		nilnul.num.integer.stream_.slider_.PeekI

	{
		public Natural() : base(new nilnul.num.integer.stream_.slider_.Natural())
		{
		}

	}
}
