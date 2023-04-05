using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13_2_mamazhonova
{
    class Student
    {
        private string name;
        private string surname;
        private string recordBookNumber;

        public Student(string name, string surname, string recordBookNumber)
        {
            this.name = name;
            this.surname = surname;
            this.recordBookNumber = recordBookNumber;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetRecordBookNumber()
        {
            return this.recordBookNumber;
        }    

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetRecordBookNumber(string recordBookNumber)
        {
            this.recordBookNumber = recordBookNumber;
        }
    }
}
