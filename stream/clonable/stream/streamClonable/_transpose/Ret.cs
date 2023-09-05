using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._stream_;

namespace nilnul.num.real.stream.stream._transpose
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	public class Ret
		:
		nilnul.obj.Box<nilnul.obj.stream.ClonableI<
			nilnul.num.real.stream.ClonableI>
		>
		,
		nilnul.obj.stream.ClonableI<nilnul.num.real.stream.ClonableI>

	{


		public Ret(obj.stream.ClonableI<nilnul.num.real.stream.ClonableI> val) : base(val)
		{

		}

		private BigInteger _cursor;


		public nilnul.num.real.stream.ClonableI next()
		{

			return new _ret.Ret(boxed.clone(), _cursor++);

		}

		public void reset()
		{
			boxed.reset();
		}

		
		public StreamI1<ClonableI> clone()
		{
			return new Ret(this.clone());
		}
	}
}
