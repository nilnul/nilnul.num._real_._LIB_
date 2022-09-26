﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using r = nilnul.num.rational;
using q = nilnul.num.quotient;
using Q = nilnul.num.rational.Rational_InheritFraction2;
using R = nilnul.num.real.RealI_posConverge2NonEmpty;
using Approach1 = nilnul.num._real.ApproachI1;
using nilnul.num.quotient.be;
using nilnul.num.quotient.ext.border.duo.be;
using nilnul.num._real._approach.members;
using nilnul.num.quotient.border.duo.be_;
using Q1 = nilnul.num._quotient.fraction.op.Simplify.Ed1;

namespace nilnul.num._real.approach.duo.op_._add
{
	

		public  class Call
			:
			nilnul._call.argArg1_.Closed<Approach1>
			,
			ApproachI1
		{

			



			public Call(_real.ApproachI1 a, _real.ApproachI1 b)
				:base(a,b)
			{
				

			}

			public Call(Q1 a, _real.ApproachI1 b)
				: this(
					new _real.approach_.Quotient(a), b
				)
			{


			}

			public quotient.border.duo.be_.Nonempty.En bound
			{
				get
				{
					return arg.bound + arg1.bound;
					throw new NotImplementedException();
				}
			}


			public void clamp(q.be_.Positive1.En diameter)
			{

				//Q firstDiameter = first.interval.diameter, secondDiameter=second.interval.diameter;

				bool _f = true, _s = true;

				while (bound.notSpanLessThan(diameter))
				{
					if (_f)
					{
						var fDiameter = arg.bound.diameter;
						if (fDiameter == 0)
						{
							_f = false;
						}
						else
						{
							arg.clamp(
								new quotient.be_.Positive1.En(
								fDiameter / 2
								)

							);

						}



					}

					if (_s)
					{
						var sDiameter = arg1.bound.diameter;
						if (sDiameter == 0)
						{
							_s = false;
						}
						else
						{
							arg1.clamp(
								new q.be_.Positive1.En(
								sDiameter / 2
								)

							);

						}



					}

				}

				return;
			//	throw new NotImplementedException();



			}
			public override string ToString()
			{
				return $"{arg}{Add.Sign}{arg1}";
			}
		}
	
}
