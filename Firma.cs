using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Firma
    {
        private string name = "Oracle";
        private List<zamestnanes> list = new List<zamestnanes>();
        private String[] names = {"Hudson", "Ezra", "Liam", "Noah", "Oliver", "William", "Elijah", "James", "Benjamin", "Lucas", "Mason", "Ethan", "Alexander", "Henry", "Jacob", "Michael", "Daniel", "Logan", "Jackson", "Sebastian", "Jack", "Aiden", "Owen", "Samuel", "Matthew", "Joseph", "Levi", "Mateo", "David", "John" };
        private String[] surnames = { "Roberts", "Carter", "Mitchell", "Campbell", "Rivera", "Hall", "Baker", "Nelson", "Adams", "Green", "Flores", "Hill", "Nguyen", "Torres", "Scott", "Wright", "King", "Allen", "Young", "Walker", "Robinson", "Lewis", "Ramirez", "Clark", "Sanchez", "Harris", "White", "Thompson", "Perez", "Lee" };
        public void AddH(Position p, string name, string surname, int salary, DateTime date, bool vacation)
        {
            list.Add(new zamestnanes(p, name, surname, salary, date, vacation));
        }

        Random rnd = new Random();
        public void Generate(int number)
        {
            for (int i = 0; i < number; i++)
            {
                int position = rnd.Next(0, 10);
                int salary = rnd.Next(10, 31);
                salary *= 100;
                int year = rnd.Next(2007, 2022);
                int mounth = rnd.Next(1, 13);
                int day = rnd.Next(1, 28);
                int namesNumber = rnd.Next(names.Length);
                int surnamesNumber = rnd.Next(surnames.Length);
                int onVacation = rnd.Next(0, 4);
                bool vacation = false;
                if (onVacation == 3)
                {
                    vacation = true;
                }

                if (position <= 6)
                {
                    position = 0;
                }

                if (position <9 && position > 6)
                {
                    salary *= 2;
                    position = 1;
                }

                if (position == 9)
                {
                    salary *= 5;
                    position = 2;
                }


                list.Add(new zamestnanes((Position)position, names[namesNumber], surnames[surnamesNumber], salary, new DateTime(year, mounth, day), vacation));
            }
        }
        
        public IEnumerable<zamestnanes> HeightestSalary()
        {
            int maxheight = list.Max(x => x.Salary);
            return list.Where(x => x.Salary == maxheight);
         
        }
        
        public double AvarageSalary()
        {
            return list.Average(x => x.Salary);
        }

        public double AvarageSalaryForPosition(Position position)
        {
            return list.Where(x => x.CurrentPosition == (Position)position).Average(x => x.Salary);
        }

        public IEnumerable<zamestnanes> LowestSalary()
        {
            return list.OrderBy(x => x.Salary).Take(3);
        }

        public IEnumerable<zamestnanes> TimeInWork()
        {
            List<zamestnanes> result = list.OrderBy(x => x.Date).ToList();
            return result;
        }

        public IEnumerable<zamestnanes> OnVacation()
        {
            return list.Where(x => x.Vacation == true).OrderBy(x => x.CurrentPosition);
        }

        public override string ToString()
        {
            List<zamestnanes> resultList = list.OrderBy(x => x.CurrentPosition).ToList();
            string result = name + ": \n";

            foreach (var x in resultList)
            {
                result += x.ToString() + "\n";
            }

            return result;
        }

        public string Count() 
        {
            int nWorker = list.Count(x => x.CurrentPosition == 0);
            int nManager = list.Count(x => x.CurrentPosition == (Position)1);
            int nDerector = list.Count(x => x.CurrentPosition == (Position)2);

            return "Workers: " + nWorker + "\nManagers: " + nManager + "\nDerectors: " + nDerector;
        }
    }
}
