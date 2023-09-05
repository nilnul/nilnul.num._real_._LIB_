namespace nilnul.num.real.stream_.slider
{
	public interface CumulusI
	:
	nilnul.obj.stream_.slider.CumulusI<nilnul.num.RealI>

	{ 

	}
	/*
	public class Cumulus
		: nilnul.obj.Box<nilnul.num.real.stream_.SliderI>
		,real.stream_.SliderI
	{
		private nilnul.num.real.op_.BinaryI _op;

		public nilnul.num.real.op_.BinaryI op
		{
			get { return _op; }
			set { _op = value; }
		}

		private RealI _current;
		public RealI current => _current;

		public Cumulus(SliderI val, real.op_.BinaryI op) : base(val)
		{
			_op = op;
			_current = boxed.current;
		}

		public void moveNext()
		{
			boxed.moveNext();
			_current = _op.op(_current, boxed.current);
		}

		public RealI next()
		{
			return nilnul.obj.stream_._slider_.NextX.Next(this);
			
		}
	}
	*/
}
