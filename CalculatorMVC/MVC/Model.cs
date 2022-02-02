using System.Collections.Generic;
using System.Windows.Controls;

namespace MVC
{
    static class Model
    {
        public static List<char> dataList = new List<char> { '+', '-', '*', '/' };
        static double result;
        public static TextBlock tb;
        public static ComboBox tbCombo;
        public static TextBox tbxF;
        public static TextBox tbxS;

        public static int Combo
        {
            set
            {
                tbCombo.Text = dataList[value].ToString();
            }
        }

        public static double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                tb.Text = result.ToString();
            }
        }
    }
}
