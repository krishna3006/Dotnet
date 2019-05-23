using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDll
{
    public class AccessDemo
    {
        private int x;
        public string name;
        protected string course;
        internal string topic;
        internal protected string quiz;
        public void Show()
        {
            AccessDemo obj = new AccessDemo();
            obj.x = 12;
            obj.name = "Bhargav";
            obj.course = "Dotnet";
            obj.topic = "Arrays";
            obj.quiz = "Access Modifiers";
        }
    }
    class Krishna
    {
        public void Test()
        {
            AccessDemo obj = new AccessDemo();

        }
    }
    class Derived : AccessDemo
    {
        public void Test()
        {
            Derived obj = new Derived();
        }
    }
    public class Quiz
    {

    }
}


      