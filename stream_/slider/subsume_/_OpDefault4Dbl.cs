namespace nilnul.num.real.stream_.slider.subsume_
{
	public class _OpDefault4Dbl<TOp>

		:
		slider._Subsume4dbl
		where TOp : nilnul.num.real.of_.Binary4dblI, new()

	{
		public _OpDefault4Dbl(Slider4dblI val) : base(val, 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance
		)
		{
		}
	}

}
