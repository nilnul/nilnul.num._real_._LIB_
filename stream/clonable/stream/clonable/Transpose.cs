using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.clonable.stream.clonable
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	static public class _TransposeX
	{
		static public nilnul.num.real.stream.clonable.stream.ClonableI Transpose(
			nilnul.num.real.stream.clonable.stream.ClonableI streamOfStreams
		) {
			return new _transpose.Ret(streamOfStreams /*.clone()*/);
		}
	}
}
