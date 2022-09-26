using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._stream_;

namespace nilnul.num.real.mesh._col
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	public class Ret
		:
		nilnul.obj.Box<nilnul.num.real.MeshI1>
		,
		nilnul.num.real.SeqI

	{
		private nilnul.Num1 _col;

		public Ret(
			nilnul.num.real.MeshI1 val
			,
			nilnul.Num1 col
		) : base(val)
		{
			_col = col;

		}

		public Ret(nilnul.num.real.MeshI1 val, BigInteger col) 
			: this( 
				  val, new nilnul.Num1(col)
			)
		{

		}

		public RealI ele(Num1 index)
		{
			return boxed[index,this._col];
		}

		
	}
}
