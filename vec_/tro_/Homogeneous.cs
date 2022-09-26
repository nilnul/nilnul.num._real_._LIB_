using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.num.real.vec_.tro_
{
	/// <summary>
	/// homogeneous coordinates used in projective geometry.
	/// </summary>
	/// imaging a projector shining an img to a screen. except the x,y on the screen ,there is a w between the projector and the screen
	public interface  Homogeneous4dblI
		//:
		//nilnul.geometry.planar.Point4dblI
	{
		/// <summary>
		/// The W dimension is the distance from the projector to the screen.
		/// </summary>
		/// So what does the W dimension do, exactly? Imagine what would happen to the 2D image if you increased or decreased W – that is, if you increased or decreased the distance between the projector and the screen. If you move the projector closer to the screen, the whole 2D image becomes smaller. If you move the projector away from the screen, the 2D image becomes larger. As you can see, the value of W affects the size (a.k.a. scale) of the image.
		/// tomdalling.com/blog/modern-opengl/explaining-homogenous-coordinates-and-projective-geometry/#:~:text=Homogeneous%20coordinates%20have%20an%20extra,common%20in%203D%20computer%20graphics.
		double w { get; }
		
	}
}
