namespace nilnul.num.real.op_
{
	public interface ITo:
		real.IOp
		//,
		//obj.IOp
	{
	}

	public interface ITo<out T>
		:ITo
		,
		obj.IOp<
			T
			,
			IReal
		>
	{ }


}
