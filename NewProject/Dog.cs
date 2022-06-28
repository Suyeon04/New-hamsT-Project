using System;

namespace newProject
{
    public class Dog : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("강아지가 와구와구 먹어요");
        }

        public void Bark()
        {
            Console.WriteLine("냠냠");
        }
    }
}