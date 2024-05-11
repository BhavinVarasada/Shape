using System;

namespace Skillup.Shape.Model
{
    /// <summary>
    /// Oval class which is inherited from shape class.
    /// </summary>
    public class Oval : Shape
    {
        /// <summary>
        /// Constructor of Oval class with it's base class.
        /// </summary>
        /// <param name="dblMajorAxis"></param>
        /// <param name="dblMinorAxis"></param>
        public Oval(double dblMajorAxis, double dblMinorAxis) : base(dblMajorAxis / 2, dblMinorAxis / 2)
        {
        }

        /// <summary>
        /// It is calculate Area of oval which is override from shape class.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return Math.PI * (m_dblXaxis) * (m_dblYaxis);
        }

        /// <summary>
        /// It is calculate Perimeter of oval which is override from shape class.
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * Math.Sqrt((Math.Pow(m_dblXaxis, 2) + Math.Pow(m_dblYaxis, 2)) / 2);
        }
    }
}