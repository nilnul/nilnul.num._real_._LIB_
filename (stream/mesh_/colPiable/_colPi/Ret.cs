using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.stream.clonable.stream;

namespace nilnul.num.real.mesh_.colPiable._colPi
{
	/// <summary>
	/// given a stream of streams, 
	/// Transpose them,resulting new stream of streams.
	/// for each stream in the new stream of streams
	///		op_.unary_.Pi( the stream) has limit
	///		yield return the limit
	/// so we get a stream of limit.
	/// if that stream has limit, the limit is what we are getting
	/// 
	/// </summary>
	public class Ret<TPi>
		:
		nilnul.obj.Box<real.mesh_.ColPiableI>
		,
		nilnul.num.real.SeqI

		where TPi:seq_.piable.PiI
	{
		private TPi _pi;
		public TPi pi
		{
			get { return _pi; }
			set { _pi = value; }
		}

	
		public Ret(real.mesh_.ColPiableI val) : base(val)
		{
		}

		

		

		public RealI ele(Num1 index)
		{
			return _pi.pi( boxed.col(index) );
		}
	}
}
