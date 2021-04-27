using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 结构体
{
    class Program
    {
        public struct Weapon
        {
            public string name;
            public int physicalDefense;
            public int MaxHp;
            public Weapon (string name, int physicalDefense, int MaxHp)//this用于重名 区分的
            {
                this.name = name;
                this.physicalDefense=physicalDefense;
                this.MaxHp = MaxHp;
        
        
            }
        }
        public struct Vector
        {
            public Vector(float a, float b, float c)
            {
                x = a;
                y = b;
                z = c;

            }
            public float x;
            public float y;
            public float z;

        }
        private static Vector vec;
        private static string name;
        static void Main(string[] args)
        {
            //vec.x = 10;
            //vec.y = 11;
            //vec.z = 12;
            vec = new Vector(10, 11, 13);//调用构造函数，作用效果与分别三次赋值一致
        }
    }
}
