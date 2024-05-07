using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS1
{
    public class Array
    {

        
        public  int Add()
        {
            int[] a = { 1, 2, 3, 4 };
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }return sum;
        }
        public bool Contains1(string str) {
            bool con=str.Contains("teja");
            return con;
        }
        public string upercase(string str1)
        {
            string str2=str1.ToUpper();
            return str2;
        }
        public string substring(string str1, string str2)
        {
            return "hi " +str1+" "+ str2;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
