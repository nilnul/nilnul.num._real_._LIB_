using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.clonable.stream.clonable.transposed_.elPiable._pi
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
	public class Ret<TPi,TVowPiable>
		:
		nilnul.obj.Box<ClonableI>
		,
		nilnul.num.real.StreamI
		where TPi:stream_.piable.PiI
		where TVowPiable:real.stream.be_.piable.VowI
	{
		private TPi _pi;
		public TPi pi
		{
			get { return _pi; }
			set { _pi = value; }
		}

		private TVowPiable _vowPiable;
		public TVowPiable vowPiable
		{
			get { return _vowPiable; }
			set { _vowPiable = value; }
		}

		public Ret(ClonableI val) : base(val)
		{
		}

		public nilnul.num.RealI next(
			//nilnul.num.real.stream.clonable.stream.ClonableI _elPiable_ifTransposed
		) {
			//var transposed = _TransposeX.Transpose(_elPiable_ifTransposed);
			var stream = boxed.next();
			return _pi.pi( new stream_.piable_.VowGeneral(_vowPiable, stream.clone() ));
		}

		public void reset()
		{
			boxed.reset();
		}
	}
}
