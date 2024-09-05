using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartYearThree
{
    public class Person
    {
        public string FName { get; set; }
        public DateTime Date { get; set; }
        public Person(string name, DateTime date) 
        { 
            this.Date = date;
            this.FName = name;
        }
        public static DateTime Re(int day, int mouth, int year)
        {
            return new DateTime(year, mouth, day);
        }
    }
}
