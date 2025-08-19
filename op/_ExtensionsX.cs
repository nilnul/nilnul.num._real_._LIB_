namespace nilnul.num.real.op
{
	static public class _ExtensionsX
	{
		static public R0 Op(this OpI1 op, nilnul.num.quotient_.DenomNonnil quotient)
		{
			return op.op( new nilnul.num.real_.Quotient_denomNonnil(quotient));
		}

		static public Real_onQuotient OpAsReal(this nilnul.num.real.OpI1 op, nilnul.num.RealI_onQuotient arg)
		{
			return  Real_onQuotient.Of(op.op(arg));
		}
	}
}
