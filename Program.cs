
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.setName("raghav pathak");
            Console.WriteLine(u1.getName());
            Console.ReadLine();
        }
    }
    class User
    {
        private String name;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
    }
}
