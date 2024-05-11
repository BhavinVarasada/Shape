using Skillup.Shape.Model;
using Skillup.Shape.Utility;
using System;

namespace Skillup.Shape
{
    /// <summary>
    /// Used for program execution logic.
    /// </summary>
    public class Execution
    {
        /// <summary>
        /// method call to get rectangle length and width, oval major and minor axis and
        /// circle radius from user.
        /// </summary>
        public void Start()
        {
            try
            {
                // to print the program title.
                Output.PrintTitle();

                // method call to get rectangle length from user.
                string strMsgRectangleLength = string.Format(Constant.MSG_USERINPUT_REACTANGLE_LENGHT, Constant.UNIT_FOR_ALL_INPUT);
                double dblRectangleLength = UserInput.GetDouble(strMsgRectangleLength, Constant.ERROR_MSG_COMMON, Constant.MSG_USERINPUT_RE_ENTER);

                // method call to get rectangle width from user.
                string strMsgRectangleWidth = string.Format(Constant.MSG_USERINPUT_REACTANGLE_WIDTH, Constant.UNIT_FOR_ALL_INPUT);
                double dblRectangleWidth = UserInput.GetDouble(strMsgRectangleWidth, Constant.ERROR_MSG_COMMON, Constant.MSG_USERINPUT_RE_ENTER);

                // Create Rectangle object and initialize it with base class Shape.
                Shape objRectangle = new Rectangle(dblRectangleLength, dblRectangleWidth);

                // method call to get Oval major axis from user.
                string strMsgOvalMajorAxis = string.Format(Constant.MSG_USERINPUT_OVAL_MAJOR_AXIS, Constant.UNIT_FOR_ALL_INPUT);
                double dblOvalMajorAxis = UserInput.GetDouble(strMsgOvalMajorAxis, Constant.ERROR_MSG_COMMON, Constant.MSG_USERINPUT_RE_ENTER);

                // method call to get Oval minor axis from user.
                string strMsgOvalMinorAxis = string.Format(Constant.MSG_USERINPUT_OVAL_MINOR_AXIS, Constant.UNIT_FOR_ALL_INPUT);
                double dblOvalMinorAxis = UserInput.GetDouble(strMsgOvalMinorAxis, Constant.ERROR_MSG_COMMON, Constant.MSG_USERINPUT_RE_ENTER);

                // Create Oval object and initialize it with base class Shape.
                Shape objOval = new Oval(dblOvalMajorAxis, dblOvalMinorAxis);

                // method call to get Circle Radius from user.
                string strMsgCircleRadius = string.Format(Constant.MSG_USERINPUT_CIRCLE_RADIUS, Constant.UNIT_FOR_ALL_INPUT);
                double dblCircleRadius = UserInput.GetDouble(strMsgCircleRadius, Constant.ERROR_MSG_COMMON, Constant.MSG_USERINPUT_RE_ENTER);

                // Create Circle object and initialize it with base class Shape.
                Shape objCircle = new Circle(dblCircleRadius);

                // to display the object information.
                Output.PrintResultLine();
                Output.PrintObjectInformation(objRectangle);
                Output.PrintObjectInformation(objOval);
                Output.PrintObjectInformation(objCircle);
            }
            catch (Exception ex)
            {
                // Exception handling for any unexpected and unknown errors.
                Output.Write(Constant.ERROR_MSG_UNEXPECTED);
                Output.WriteLine(string.Format(Constant.ERROR_MSG_DETAIL, ex.Message));
                Output.WriteLine(string.Format(Constant.ERROR_MSG_STACKTRACE, ex.StackTrace));
            }
        }
    }
}