namespace nilnul.num.real
{
	public interface IOf
		: nilnul.num.real.op_.IOf
		//,
		//nilnul.obj.op_.IOf<IReal>
	{
	}

	public interface IOf<T>
		:
		IOf
		,
		nilnul.obj.IOp<IReal,T>
	{ }
}