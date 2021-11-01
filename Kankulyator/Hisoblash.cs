using System;
using System.Data;
namespace Kankulyator
{
    public class Hisoblash
    {
        public static string Eval(string expression, string math)
        {
            expression = Eval(expression);
            if (math == "sqrt")
            {
                try
                {
                    return Math.Sqrt(double.Parse(expression)).ToString();
                }
                catch
                {
                    return "Xatolik!";
                }
            }
            else if (math == "sqr")
            {
                try
                {
                    return Math.Pow(double.Parse(expression), 2).ToString();
                }
                catch
                {
                    return "Xatolik!";
                }
            }
            else return "Xatolik!";
        }
        public static string Eval(string expression)
        {
            expression = expression.Replace(',', '.');
            expression = expression.Replace('×', '*');
            DataTable table = new DataTable();
            try
            {
                return table.Compute(expression, string.Empty).ToString();
            }
            catch
            {
                return "Xatolik!";
            }
        }
    }
}
