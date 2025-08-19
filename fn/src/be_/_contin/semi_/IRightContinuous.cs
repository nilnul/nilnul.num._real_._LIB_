namespace nilnul.num.real.fn.src.be_._contin.semi_
{
	/// <summary>
	/// given a src: a
	/// , the function is defined at the interval of [a, a+delta), where delta is a positive real that is arbitrarily small.
	/// , the function approaches  to f(a) as x -> a+, that x approaches to x from upper/right part;
	/// </summary>
	public interface IRightContinuous
		: _contig.semi_.IRightApproachable /// what's more, the point's val is that limit;
    {
    }

}
