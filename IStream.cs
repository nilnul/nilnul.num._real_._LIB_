namespace nilnul.num.real
{
	/// <summary>
	/// a stream is a fn: N -> R.
	/// 
	/// the cardinality of all streams is:
	///		R^N = (2^N)	^N = 2^(N^2) = 2^N = R
	/// </summary>
	public interface IStream :nilnul.obj.IStream<num.IReal>{ }
}
