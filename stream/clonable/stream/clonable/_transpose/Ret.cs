using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._stream_;
using nilnul.obj._stream_._next;

namespace nilnul.num.real.stream.clonable.stream.clonable._transpose
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	public class Ret
		:
		nilnul.obj.Box<
			nilnul.num.real.stream.clonable.stream.ClonableI
		>
		,
		nilnul.num.real.stream.clonable.stream.ClonableI
		, MeshI

	{
		private BigInteger _cursor;

		public Ret(nilnul.num.real.stream.clonable.stream.ClonableI val) : base(val)
		{

		}



		public nilnul.num.real.stream.ClonableI next()
		{

			return new _ret.Ret(boxed.clone(), _cursor++);

		}

		public void reset()
		{
			boxed.reset();
		}

		
		public ClonableI clone()
		{
			return new Ret(this.boxed.clone());

		}

		StreamI MorphI<StreamI>.next()
		{
			return next();
		}
	}
}
