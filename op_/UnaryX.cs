namespace nilnul.num.real.op_
{
	static public class UnaryX
	{
		static public RealI Op(this UnaryI op, nilnul.num.Quotient1 quotient)
		{
			return op.op(new nilnul.num.Real(quotient));
		}

		static public Real RetReal(this nilnul.num.real.op_.UnaryI op, nilnul.num.RealI arg)
		{
			return new Real(op.op(arg));
		}
	}
}
