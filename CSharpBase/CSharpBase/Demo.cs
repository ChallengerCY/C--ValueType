using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBase
{
    //枚举类型
    //枚举类型目的是限定变量的可能性
    //枚举类型默认对应的是整形，也可以指定类型
    enum Days : byte {Monday,Tuesday,Wenesday,Thursday,Friday,Saturday,Sunday}

    class Demo
    {
        static void Main(string[] args)
        {
                //C#的值类型
               //C#有三种类型，值类型，引用类型，指针类型(在不安全模式下用到)
              //值类型存储在栈上面，引用类型是在栈上面存储一个引用，在内存的对上面存储值
             //所有的值类型继承自System.ValueType,System.ValueType继承自System.Object（基类）
            int value = 0;
            int value_2 = new int();
            bool a = true;

            Person people=new Person();
            people.age = 10;
            //用var定义的变量支持任何类型
            var day = Days.Friday;

            Console.WriteLine(people.age);
            Console.WriteLine(Days.Monday);
            Console.WriteLine(day);
            Console.ReadLine();        
        }
        //struct类型
        //目的是打包封装一个数据集
        struct Person
        {
            //C#中有四种访问修饰符
            //public 对外都是可见的 private 私有的 internal在命名空间内是可以用的 protected 只有继承类才能使用
            public int age;
            private string name;
            internal string fname;
            //protected string lastname;         
        }
    }
}
