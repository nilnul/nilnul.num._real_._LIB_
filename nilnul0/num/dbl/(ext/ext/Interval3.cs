using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.double_
{
	public partial class Interval3
		:ext.bound.couple.be.Interval.Asserted

	{


		public Interval3(double a,bool leftEq,double b,bool rightEq)
			:base(a,leftEq,b,rightEq)
		{
		}

		public Interval3(
			ext.Bound lower,
			ext.Bound upper
			)
			:base(lower, upper)
		{

		}

		public Interval3(
			ext.bound.Couple couple
				
		)
			:this(couple.lower,couple.upper)
		{

		}




		static public Interval3 _CreateCenteredClosed(double center,double radius) {
			return _CreateClosed(
				center-radius,center+radius	
			);
		}

		static public Interval3 _CreateClosed(double left,double right) {
			return new Interval3(
				left,true,right,true	
			);
		}

		static public Interval3 _CreateOpen(double left, double right) {

			return new Interval3(
				left,false,right,false	
			);

		}

		static public Interval3 _CreateOpenClose(double left, double right) {

			return new Interval3(
				left,false,right,true	
			);

		}

		static public Interval3 _CreateClopen(double left, double right) {

			return new Interval3(
				left,true,right,false	
			);

		}






		//static public Interval2 ZeroToOne = new Interval2(0, 1);

		//static public Interval2 GetZeroToOne{
		//	get {
		//		return new Interval2(0, 1);
		//	}
		//}
	

					

	}
}
