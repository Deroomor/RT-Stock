using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Coding("");

            var str2 = DeCoding(str);
        }

        private static string Coding(string cnnstr)
        {

            var buffer = System.Text.Encoding.UTF8.GetBytes(cnnstr);

            string st1 = System.Convert.ToBase64String(buffer);

            st1 = "HTI" + st1;

            buffer = System.Text.Encoding.UTF8.GetBytes(st1);

            string rst = System.Convert.ToBase64String(buffer);
            return rst; 
        }

        private static string DeCoding(string cnnstr)
        {
            
            var buffer = System.Convert.FromBase64String(cnnstr);

            string st1 = System.Text.Encoding.UTF8.GetString(buffer);

            st1 = st1.Substring(3);

            buffer = System.Convert.FromBase64String(st1);

            string rst = System.Text.Encoding.UTF8.GetString(buffer);
            return rst;
        }
    }
}
