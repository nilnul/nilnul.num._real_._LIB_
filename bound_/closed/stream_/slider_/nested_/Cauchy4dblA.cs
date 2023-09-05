namespace nilnul.num.real.bound_.closed.stream_.slider_.nested_
{
	public abstract class Cauchy4dblA
		:
		nilnul.obj.stream_.SliderA<
			bound_.ClosedDbl
		>
		,
		Cauchy4dblI

	{
		public abstract void clamp(real_.PositiveDblI diameter);
	}
}
