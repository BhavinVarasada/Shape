using System;

namespace Skillup.Shape.Utility
{
    /// <summary>
    /// used for to get all input from user.
    /// </summary>
    public class UserInput
    {
        #region Get User Input
        /// <summary>
        /// Get User Input for All shape inputs.
        /// </summary>
        /// <param name="strDisplayMsg"></param>
        /// <param name="strErrorMsg"></param>
        /// <param name="strReEnterMsg"></param>
        /// <returns></returns>
        public static double GetDouble(string strDisplayMsg, string strErrorMsg, string strReEnterMsg)
        {
            double dblUserInput = 0;
            bool bInputStatus = false;
            Output.Write(strDisplayMsg);
            while (bInputStatus == false)
            {
                string strUserInput = GetString();
                bInputStatus = double.TryParse(strUserInput, out dblUserInput);
                if (bInputStatus == false || dblUserInput < Constant.MINIMUM_INPUT_RANGE || dblUserInput > Constant.MAXIMUM_INPUT_RANGE)
                {
                    Output.WriteLine(strErrorMsg);
                    Output.Write(strReEnterMsg);
                    bInputStatus = false;
                }
            }
            return dblUserInput;
        }
        #endregion

        /// <summary>
        /// to get string as an input from user.
        /// </summary>
        /// <returns></returns>
        private static string GetString()
        {
            return Console.ReadLine();
        }
    }
}