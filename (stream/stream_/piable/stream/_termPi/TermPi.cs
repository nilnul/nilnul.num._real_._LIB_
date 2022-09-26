using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num.real.stream.clonable.stream;

namespace nilnul.num.real.stream_.piable.stream._termPi
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
		nilnul.obj.Box<real.stream_.piable.StreamI>
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

		public Ret(real.stream_.piable.StreamI val) : base(val)
		{
		}

		

		public nilnul.num.RealI next(
			//nilnul.num.real.stream.clonable.stream.ClonableI _elPiable_ifTransposed
		) {
			//var transposed = _TransposeX.Transpose(_elPiable_ifTransposed);
			var stream = boxed.next();

			return _pi.pi( new stream_.piable_.VowGeneral(_vowPiable, stream.stream.en ));
		}

		public void reset()
		{
			boxed.reset();
		}
	}
}
