namespace Skillup.Shape
{
    /// <summary>
    /// It is parent class for rectangle, oval and circle.
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Serial number property to provide unique serial number to each object.
        /// </summary>
        public int SerialNumber { get; private set; }

        protected double m_dblXaxis;
        protected double m_dblYaxis;
        private static int m_nSerialNumber = 1;

        /// <summary>
        /// Constructor of Shape class.
        /// </summary>
        /// <param name="dblXaxis"></param>
        /// <param name="dblYaxis"></param>
        public Shape(double dblXaxis, double dblYaxis)
        {
            m_dblXaxis = dblXaxis;
            m_dblYaxis = dblYaxis;
            SerialNumber = m_nSerialNumber++;
        }

        /// <summary>
        /// Abstarct method to calculate area of all shapes.
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// Abstarct method to calculate Perimeter of all shapes.
        /// </summary>
        /// <returns></returns>
        public abstract double Perimeter();

        /// <summary>
        /// It is used to print class name of current object.
        /// </summary>
        /// <returns></returns>
        public string ClassName()
        {
            return GetType().Name;
        }
    }
}