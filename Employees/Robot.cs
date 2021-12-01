using System;

namespace Employees
{
    public class Robot
    {
        private string name;
        private int age;

        public int Height { get; set; }
        public int Age
        {
            get { return age; }
            set 
            { 
                if(value < 0)
                {
                    age = 0;
                   // throw new ArgumentException(nameof(age));
                }
                else
                {
                    age = value;
                }
            
            }
        }

        public Robot(int height, string name, int age)
        {
            Height = height;
            this.name = name;
            Age = age;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            //Validate
            name = newName;
        }
    }
}