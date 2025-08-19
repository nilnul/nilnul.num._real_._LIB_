namespace nilnul.num.real.ext
{
	/// <summary>
	/// for improper calculus, the domain can include the infinity, as the limit of the calculus can be a real or an ext;
	/// for some function that is continuous, the limit of the value can be real.ext  for a src of inf;
	/// the tgt in the range can also be inf as some measure allows;
	/// </summary>
	/// <remarks>
	/// some improper <see cref="real.IFunc"/> would be come this as normal function;
	/// there may still be some point undefined, for this as well as <see cref="real.IFunc"/>;
	/// statisitics density function can modify some, not all, functions, by defining 0 as the val of some undefined points;
	/// </remarks>
	public interface IFunc { }
}
