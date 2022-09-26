using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.stream.stream
{
	/// <summary>
	/// given a stream of streams,
	///		get the start term, which is the first terms of each of the streams
	///		get the followed term, which is the followed term of each of the streams
	/// </summary>
	static public class _TransposeX
	{
		static public nilnul.obj.stream.ClonableI<nilnul.num.real.stream.ClonableI> Transpose(
			nilnul.obj.stream.ClonableI<nilnul.num.real.stream.ClonableI> streamOfStreams
		) {
			return new _transpose.Ret(streamOfStreams);
		}
	}
}
