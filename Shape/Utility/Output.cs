using System;

namespace Skillup.Shape.Utility
{
    /// <summary>
    /// for all methods which is used for print.
    /// </summary>
    public class Output
    {
        /// <summary>
        /// to print the message with arguments on another line.
        /// </summary>
        /// <param name="Message"></param>
        public static void WriteLine(object Message = null)
        {
            Console.WriteLine(Message);
        }

        /// <summary>
        /// for print the message but on same line.
        /// </summary>
        /// <param name="Message"></param>
        public static void Write(object Message = null)
        {
            Console.Write(Message);
        }

        /// <summary>
        /// To print the title of program.
        /// </summary>
        public static void PrintTitle()
        {
            WriteLine(Constant.DASH_LINE);
            WriteLine(Constant.PROGRAM_NAME);
            WriteLine(Constant.DASH_LINE);
        }

        /// <summary>
        /// To print the title line of result.
        /// </summary>
        public static void PrintResultLine()
        {
            //Print Result line.
            WriteLine(Constant.DASH_LINE);
            WriteLine(Constant.MSG_RESULT);
            WriteLine(Constant.DASH_LINE);
        }

        /// <summary>
        /// To print the all object information.
        /// </summary>
        /// <param name="objShapeObject"></param>
        public static void PrintObjectInformation(Shape objShapeObject)
        {
            //Print object information.
            WriteLine(string.Format(Constant.MSG_SHAPE_NAME, objShapeObject.ClassName()));
            WriteLine(string.Format(Constant.MSG_SERIAL_NUMBER, objShapeObject.SerialNumber));
            WriteLine(string.Format(Constant.MSG_AREA, Math.Round(objShapeObject.Area(), Constant.MATH_POINT_ROUND_OFF), Constant.UNIT_FOR_AREA));
            WriteLine(string.Format(Constant.MSG_PERIMETER, Math.Round(objShapeObject.Perimeter(), Constant.MATH_POINT_ROUND_OFF), Constant.UNIT_FOR_ALL_INPUT));
            WriteLine(Constant.SHORT_DASH_LINE);
        }
    }
}