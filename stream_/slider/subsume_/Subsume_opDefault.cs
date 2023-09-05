namespace nilnul.num.real.stream_.slider
{
	public class Subsume_opDefault<TOp>

		: nilnul.obj.stream_.slider.Subsume_opDefault<nilnul.num.RealI, nilnul.num.real.stream_.SliderI, TOp>
		, real.stream_.SliderI
		where TOp : nilnul.num.real.op_.BinaryI, new()

	{
		public Subsume_opDefault(SliderI val) : base(val)
		{
		}
	}

}
