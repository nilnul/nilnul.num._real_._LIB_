using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._stream_;

namespace nilnul.num.real.stream.stream._transpose._ret
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	public class Ret
		:
		nilnul.obj.Box<nilnul.obj.stream.ClonableI<nilnul.num.real.stream.ClonableI>
		>
		,
		nilnul.num.real.stream.ClonableI

	{
		private nilnul.Num1 _index;

		public Ret(
			obj.stream.ClonableI<nilnul.num.real.stream.ClonableI> val
			,
			nilnul.Num1 index
		) : base(val)
		{
			_index = index;

		}

		public Ret(
			obj.stream.ClonableI<nilnul.num.real.stream.ClonableI> val
			,
			BigInteger bigInteger
		) 
			: this( 
				  val, new nilnul.Num1(bigInteger)
			)
		{
		}

		
		public ClonableI clone()
		{
			
			return new Ret(boxed, this._index);
		}

		public RealI6 next()
		{
			var t = boxed.next();
			t.reset();

			return nilnul.obj.stream._SkimX.Skim(
				t
				,
				_index
			);

		}

		public void reset()
		{
			boxed.reset();
		}
	}
}
