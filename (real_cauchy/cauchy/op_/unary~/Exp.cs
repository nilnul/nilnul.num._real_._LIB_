using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using R = nilnul.num.RealI2;
namespace nilnul.num._real.approach.generator.op_
{
	public class Exp
		: OpI
	{

		static private Lazy<Exp> _lazy = new Lazy<Exp>();
		
		static public Exp lazy {
			get {
				return _lazy.Value;
			}
		} 

		public GeneratorI eval(GeneratorI arg)
		{
			return new _exp.Ret(arg);


//			throw new NotImplementedException();
		}

		
	}
}
