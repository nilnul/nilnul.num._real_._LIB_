using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach_;

namespace nilnul.num._real.approach.generator_.notZero.op_._inverse
{
	public class Ret :
		_call.ArgA<generator_.NotZeroI>
		,
		generator_.NotZeroI
		,
		
		GeneratorI
	{
		//private GeneratorI _x;

		//public GeneratorI x
		//{
		//	get { return _x; }
		//	set { _x = value; }
		//}

		//private ApproachI1 _generated;

		//public ApproachI1 generated
		//{
		//	get { return _generated; }
		//	set { _generated = value; }
		//}

		//private approach.be_.Nonzero.En _nonZero;

		//public approach.be_.Nonzero.En nonZero
		//{
		//	get { return _nonZero; }
		//	set { _nonZero = value; }
		//}
		private approach_.nonzero.op_._inverse.Ret _inversedApproach;

		public approach_.nonzero.op_._inverse.Ret inversedApproach
		{
			get { return _inversedApproach; }
			set { _inversedApproach = value; }
		}


		public Ret(generator_.NotZeroI x):base(x)
		{

			_inversedApproach = new approach_.nonzero.op_._inverse.Ret(x.generate());

		}

		
		public ApproachI1 generate()
		{
			return _inversedApproach;

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"1/{arg}";
		}

		approach_.NotZeroI NotZeroI.generate()
		{
			return _inversedApproach;

			throw new NotImplementedException();
		}
	}
}
