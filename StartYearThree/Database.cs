using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartYearThree
{
    public class Database
    {
        public List<Person> persons = new List<Person>()
        {
            new Person("Чупашева", Person.Re(01,10,2015)),
            new Person("Иванов", Person.Re(10,01,2017)),
            new Person("Кривцов", Person.Re(05,02,2019)),
            new Person("Янаева", Person.Re(15,12,2014))
        };
    }
}
