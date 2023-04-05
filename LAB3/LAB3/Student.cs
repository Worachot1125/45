using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
        private string name;
        private string _id;
        private int _age;
        private int _birthYear;

        public string Name {
            get { return this.name; }
        }
        public int Birthyear
        {
            get { return this._birthYear; }
        }

        //constructor
        public Student(string name, int birthYear) {
            this.name = name;
            this._birthYear = birthYear;
        }

        public int myAge() {
            int age = 2023 - _birthYear;
            return age;
        }
    }
}
