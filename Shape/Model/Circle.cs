namespace Skillup.Shape.Model
{
    /// <summary>
    /// Circle class which is inherited from oval class.
    /// </summary>
    public class Circle : Oval
    {
        /// <summary>
        /// Radius class constructor with it's base class Constructor.
        /// </summary>
        /// <param name="dblRadius"></param>
        public Circle(double dblRadius) : base(2 * dblRadius, 2 * dblRadius)
        {
        }
    }
}