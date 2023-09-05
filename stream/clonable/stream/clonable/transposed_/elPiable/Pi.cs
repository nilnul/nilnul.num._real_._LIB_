using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.clonable.stream.clonable.transposed_
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
	static public class _PiX
	{
		static public nilnul.num.real.StreamI3 Pi<TPi,TPiableVow>(
			nilnul.num.real.stream.clonable.stream.ClonableI _elPiable_ifTransposed
		)
			where TPiableVow: num.real.stream.be_.piable.VowI
			where TPi: num.real.stream_.piable.PiI

		{

			var transposed = _TransposeX.Transpose(_elPiable_ifTransposed);


			switch (transposed)
			{
				case mesh_.TermPiableI x:
					return new num.real.mesh_.termPiable._termPi.Ret<TPi>(
						x
					);

				default:
					throw new UnexpectedTypeException(" ");
					break;
			}



			

		}
	}
}
