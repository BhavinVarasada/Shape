namespace Skillup.Shape.Model
{
    /// <summary>
    /// Rectangle class which is inherited from shape class.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Constructor of Recatngle class with it's base class Constructor.
        /// </summary>
        /// <param name="dblLength"></param>
        /// <param name="dblWidth"></param>
        public Rectangle(double dblLength, double dblWidth) : base(dblLength, dblWidth)
        {
        }

        /// <summary>
        /// It is calculate Area of rectangle which is override from shape class.
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            return m_dblXaxis * m_dblYaxis;
        }

        /// <summary>
        /// It is calculate Perimeter of rectangle which is override from shape class.
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * (m_dblXaxis + m_dblYaxis);
        }
    }
}