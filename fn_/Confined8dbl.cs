namespace nilnul.num.real.fn_
{
	/// <summary>
	/// <see cref="_fn_.Scope"/>
	/// ;
	/// the scope is explicitly specified in advance.
	/// Then for the algorithm, an xpn is thrown if the input is out of scope, even the latter algorithm can give a val;
	/// and for any input in scope, there shall be a val given by the following algorithm, and  no xpn is thrown.
	/// </summary>
	internal interface Confined8dbl
		:_confined_.Algo4confinedI
	{
		num.real.Collection4dblI confine { get; }

		
	}


}
