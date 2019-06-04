using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class6
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            Console.WriteLine(mc.a);
            Console.WriteLine(MyClass.b);
            Console.WriteLine("--------------");
            MyClass mc2 = new MyClass();
            Console.WriteLine(mc2.a);
            Console.WriteLine(MyClass.b);
        }
    }
    class MyClass
    {
        public int a;//实例成员：当前对象
        public static int b;//静态成员：当前类(所有对象)
        public MyClass()//new 类名()会自动执行
        {
            a++;//a=a+1
            b++;
        }
    }
}
