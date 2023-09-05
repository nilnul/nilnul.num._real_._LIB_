namespace nilnul.num.real.stream
{
	public class Cumulus_cumulatorDefault<TCumuls>
		: Cumulus
		where TCumuls: real.op_.binary.CumulatorI,new()
	{
		public Cumulus_cumulatorDefault(StreamI val) : base(val,  nilnul.obj_.Singleton<TCumuls>.Instance)
		{
		}
	}


}
