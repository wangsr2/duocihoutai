using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("明天你好！");
            //Console.ReadLine();

            var studentList = new List<Student>();

            Student st = new Student();
            st.name = "张上海古籍出版社";
            st.age = 200;
            studentList.Add(st);

            st = new Student();
            st.name = "十几号放假";
            st.age = 11;
            studentList.Add(st);
            
            foreach(var item in studentList)
            {
                Console.WriteLine("Name:{0},Age:{1}", item .name,item .age);
            }
            Console.ReadKey();
        }
       
    }
}
