namespace nilnul.num.real.stream.cumulus_
{
	public class CumulatorDefault4Dbl<TCumuls>
		: Cumulus4dbl
		where TCumuls:
		real.of_.binary.Cumulator4dblI
		//real.op_.binary.CumulatorI
		,new()
	{
		public CumulatorDefault4Dbl(Stream4dblI val) : base(val,  nilnul.obj_.Singleton<TCumuls>.Instance)
		{
		}
	}


}
