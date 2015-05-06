using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeiqAngou
{
    class Program
    {
        static void Main(string[] args)
        {
            string strAngou = "LZH SN STJHZTMNMZQZ JNMN ATMRGNT VN OTQNFTQZLT CD JZHCNJT RHMZRZH "
                + "RNQDJTQZH CDJHMZJXZ VZSZRH GZ ETSZQH FZ STJHZT MNVN LHSNLDMZHXN";
            string strAns = "";

            for (int i = 0; i < strAngou.Length; i++)
            {
                char ch = strAngou[i];
                if (ch == 'Z')
                {
                    ch = 'A';
                }
                else if (ch != ' ')
                {
                    ch = (char)((int)ch + 1);
                }
                strAns += ch.ToString();
            }
            Console.WriteLine("暗号文＝" + strAngou);
            Console.WriteLine("解読文＝" + strAns);
            strAns = Console.ReadLine();
        }
    }
}
