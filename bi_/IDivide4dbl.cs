namespace nilnul.num.real.op_.binary_
{
	/// <summary>
	///  just like 3e8 represents a range of numbers, a 0 represents not a single number but every number that is so small you don't have enough digits to write down how small it is.
	/// So the number representing zero might be an actual zero but it might very well not be one. So when we ask a computer to divide a number by zero we're actually telling it to divide a number by some arbitrary real small number. And it does. And the result is the arbitrary very large number.
	/// 0/0 might be NaN;
	/// </summary>
	public interface IDivide4dbl { }
}
