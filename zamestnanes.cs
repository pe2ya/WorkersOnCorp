using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    public enum Position
    {
        Worker = 0,
        Manager,
        Director
    }
    class zamestnanes
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary{ get; set; }
        public Position CurrentPosition { get; set; }
        public DateTime Date { get; set; }

        public bool Vacation { get; set; }

        public zamestnanes(Position position, string name, string surname, int salary, DateTime date, bool vacation)
        {
            CurrentPosition = position;
            Name = name;
            Surname = surname;
            Salary = salary;
            Date = date;
            Vacation = vacation;
        }

        public override string ToString()
        {
            string holiday = "Hi is on vacation";
            if (Vacation == false)
            {
                holiday = "Hi is at work";
            }
            return CurrentPosition + " - " +Name + " " + Surname + ", " + Salary + ", " + Date.ToString("yyyy'-'MM'-'dd") + ", " + holiday;
        }

    }
}
