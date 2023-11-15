using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Person
    {
        public  string name;
         public int age;
         public string address;
        public void getdata(string name,int age,string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }

    }
}
