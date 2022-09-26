using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj;
using nilnul.obj._stream_;

namespace nilnul.num.real.mesh.clonable._transpose
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	public class Ret
		:
		nilnul.obj.Box<
			nilnul.num.real.MeshI1
		>
		
		, MeshI1

	{
		private BigInteger _cursor;

		public Ret(nilnul.num.real.MeshI1 val) : base(val)
		{
		}



	

		public RealI this[Num1 row, Num1 col]
		{
			get {
			return boxed[col,row];

			}
		}
	}
}
