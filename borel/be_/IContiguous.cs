namespace nilnul.num.real.borel.be_
{
	/// <summary>
	/// continuous, barring countable break points, which might be empty/excluded, or jump/outlier
	/// </summary>
	/// <remarks>
	/// remove enumerable points, and we still keep the set measured positive.
	/// </remarks>
	/// 
	/// vs:
	///		<see cref="interval.set_.sed_.IEnumerable"/>, which might be nonspanned, or there is some jump points.
	///
	/// vs:	/// <see cref="borel_.IConnected"/>
	///	vs:	
	///		 nonempty countable <see cref="IContinuous"/>, with countable beak points, as defined by <see cref="borel_.IConnected"/>,  whileas this requires the two continuous can be connected by a single point.
	///		
	interface IContiguous
    {
    }


	



}
