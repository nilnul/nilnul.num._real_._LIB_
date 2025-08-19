namespace nilnul.num.real.stream.cumulus_
{
	public class CumulaDefault8Dbl<TCumula>
		:
		stream.Cumulus8dbl1

		where TCumula:
		real.bi.Cumula8dblI
		//real.op_.binary.CumulatorI
		,new()
	{
		public CumulaDefault8Dbl(Stream4dblI val) : base(val,  nilnul.obj_.Singleton<TCumula>.Instance)
		{
		}
	}


}
