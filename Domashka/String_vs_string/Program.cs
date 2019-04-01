using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**даны две строки
 * в каждую строку водит пользователь
 *ишем в первой строке  кол-во второй 
 * ссчитаем какой номер индекса при старте
 */
namespace String_vs_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();
            int count = 0;
            string temp_str = "";
            for (int i =0; i<str1.Length; i++)
            {
               
                int start = i;
                int end = i + str2.Length - 1;
                
                for(int t = start; t <= end; t++)
                {
                   if(end!=str1.Length) temp_str += str1[t];

                    if (temp_str == str2)
                    {
                        count++; // кол-во повторений строки в строке
                         
                    }
                    
                }
                temp_str = "";
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
