using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.num._real.approach;
using R = nilnul.num.RealI;

namespace nilnul.num
{
	/// <summary>
	/// this can provide some operators to Real number.
	/// </summary>
	/// <remarks>
	/// This solution has one problem:
	///		Every subtype will not inherit other class or struct except this one; While with interface, one type can be free to inherit.
	///		
	/// advantages:
	///		1) 'cuz interface cannot be used in Cast Operation, so maybe we should try abstract Type (will the abstract type work in cast operation? i'm not sure.).
	///		2) this can provide operators, while interface cannot.
	///		3) if we impose that all reals inherit from this, then every real will have a unqiue top class.
	///		4) some common members can be defined. here.
	/// </remarks>
	/// 
	[Obsolete()]
	public abstract class RealA : RealI

	{
		public abstract GeneratorI choice
		{
			get
			;
		}

		static public R operator +(RealA a, RealA b) {
			return nilnul.num.real.co.op_.Add.Eval(a, b);
		}
	}
}
