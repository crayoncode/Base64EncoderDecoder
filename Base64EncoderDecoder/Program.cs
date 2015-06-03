using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64EncoderDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //编码
            byte[] bytes = Encoding.Default.GetBytes("你好");
            Console.WriteLine(Convert.ToBase64String(bytes));
            //解码
            byte[] outputb = Convert.FromBase64String("ztKwrsTj");
            string orgStr = Encoding.Default.GetString(outputb);
            Console.WriteLine(orgStr);
            Console.ReadKey();
        }
    }
}
