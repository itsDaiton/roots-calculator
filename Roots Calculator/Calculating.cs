using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roots_Calculator
{
    class Calculating
    {
        protected static double number, root, result, exponent;
        protected static string ret;

        public static string Calculate(string num, string index, out string info)
        {
            if (String.IsNullOrEmpty(num) || String.IsNullOrEmpty(index))
            {
                info = "Enter two inputs please.";
                ret = null;
            }
            else
            {
                if (double.TryParse(num, out number) && double.TryParse(index, out root))
                {
                    if ((number >= 0 && root > 0) == false)
                    {
                        info = "x ≥ 0 !\nn > 0 !";
                        ret = "error";
                    }
                    else
                    {
                        exponent = 1 / root;
                        result = Math.Round(Math.Pow(number, exponent), 5);
                        ret = $"{result}";
                        info = "Operation has been executed correctly.";
                    }
                }
                else
                {
                    info = "One of the two inputs isn't a number !";
                    ret = "error";
                }
            }
            return ret;
        }

        public static void Clear(TextBox tNum, TextBox tIndex, TextBox tResult, out string info)
        {
            TextBox[] textboxes = { tNum, tIndex, tResult };

            foreach (var item in textboxes)
            {               
                item.Clear();
            }

            info = "User interace has been cleared.";
        }

        public static string SquareRoot(string num, out string info)
        {
            if (String.IsNullOrEmpty(num))
            {
                info = "Enter a number please.";
                ret = null;
            }
            else
            {
                if (double.TryParse(num, out number))
                {
                    if ((number >= 0) == false)
                    {
                        info = "x ≥ 0 !";
                        ret = "error";
                    }
                    else
                    {
                        root = 2;
                        exponent = 1 / root;
                        result = Math.Round(Math.Pow(number, exponent), 5);
                        ret = $"{result}";
                        info = "Operation has been executed correctly.";
                    }
                }
                else
                {
                    info = "The input isn't a number !";
                    ret = "error";
                }
            }
            return ret;
        }

        public static string CubeRoot(string num, out string info)
        {
            if (String.IsNullOrEmpty(num))
            {
                info = "Enter a number please.";
                ret = null;
            }
            else
            {
                if (double.TryParse(num, out number))
                {
                    if ((number >= 0) == false)
                    {
                        info = "x ≥ 0 !";
                        ret = "error";
                    }
                    else
                    {
                        root = 3;
                        exponent = 1 / root;
                        result = Math.Round(Math.Pow(number, exponent), 5);
                        ret = $"{result}";
                        info = "Operation has been executed correctly.";
                    }
                }
                else
                {
                    info = "The input isn't a number !";
                    ret = "error";
                }
            }
            return ret;
        }
        
    }


}
