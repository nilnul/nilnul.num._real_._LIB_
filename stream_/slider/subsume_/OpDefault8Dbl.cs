namespace nilnul.num.real.stream_.slider.subsume_
{
	public class OpDefault8Dbl<TOp>

		:
		slider.Subsume8dbl
		where TOp : nilnul.num.real.Bi8dblI, new()

	{
		public OpDefault8Dbl(Slider4dblI val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance
		)
		{
		}
	}

}
