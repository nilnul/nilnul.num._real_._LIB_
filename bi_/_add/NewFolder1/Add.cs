using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using nilnul.function.op.binary;
using nilnul.collection.set.relation;
using nilnul.math.number.complex.real;

namespace nilnul.math.algebra.function.op
{


	public partial class Add
		
	{



		static private readonly Add _Instance = new Add();
		static public Add Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Add()
		{
		}

		public override string ToString()
		{
			return "+";
		}

		static public RealExprI Simplify(RealExprI firstSimplified,RealExprI secondSimplified)
		{
			if (firstSimplified.GetType().GetGenericTypeDefinition() == typeof(Real<>)

				&&
				secondSimplified.GetType().GetGenericTypeDefinition() == typeof(Real<>)
				)
			{
				Decimal l2 = (Decimal)(firstSimplified.GetType().GetProperty("value").GetValue(firstSimplified, null));
				decimal r2 = (decimal)(secondSimplified.GetType().GetProperty("value").GetValue(secondSimplified, null));
				return (l2 + r2).ToReal();
			}

			else
			{
				throw new Exception();
			}

		}




		//public Add(Real a, Real b)
		//{
		//    this._operands = new List<Real>();

		//    if (a is Add)
		//    {
		//        this._operands.AddRange(((Add)a)._operands);
		//        this._operands.Add(b);

		//    }
		//    else if (b is Add)
		//        {
		//            this._operands.Add(a);
		//            this._operands.AddRange(((Add)b)._operands);


		//        }
		//    else {
		//            this._operands.Add(a);
		//            _operands.Add(b);
		//        }


		//}




		//public Add(params Real[] augends) {
		//    _augends = augends;
		//}

		//public static Number Call(Number a, Number b){
		//    Number r=new Number();
		//    r.add(a);
		//    r.add(new Add());
		//    r.add(b);
		//    return r;

		//}

		//public static Number Call(Number a, double b)
		//{
		//    Number r=new Number();
		//    r.add(a);
		//    r.add(new Add());
		//    r.add(b);
		//    return r;

		//}
		//public static implicit operator Num (Add x){
		//    Number r=new Number();
		//    r.add(x["a"]);
		//    r.add(new Add());
		//    r.add(x["b"]);
		//    return r;




		//}
		//public static ulong Call(ulong[] n) {
		//    ulong r = 0;
		//    foreach(ulong i in n){
		//        r += i;

		//    }
		//    return r;
		//}
	
	}
}
