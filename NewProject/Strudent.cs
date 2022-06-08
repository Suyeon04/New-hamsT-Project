namespace newProject
{
    internal class Student
    {
        public string name;
        public int age;
        public int grade;

        public override string ToString()
        {
            return this.name + " : " + this.grade;
        }


    }
}