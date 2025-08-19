namespace nilnul.num.real_.nonneg.op_.unary_
{
	static public class SqrtX
	{
		static public NonnegI Sqrt(this nilnul.num.real_.NonnegI nonneg)
		{
			return real_.nonneg.op_.unary_.Sqrt.Singleton.op(nonneg);
		}
		static public NonnegI Sqrt(this nilnul.num.RealI nonneg)
		{
			return real_.nonneg.op_.unary_.Sqrt.Singleton.op(nonneg);
		}

	}
}
