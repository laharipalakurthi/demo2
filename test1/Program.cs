//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace test1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name, Address;
        public int Age;
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string _Addresss
        {
            get { return Address; }
            set { Address = value; }
        }
        public int _Age
        {
            get { return Age; }
            set { Age = value; }
        }
    }
    public class PersonImplementation
    {
        public String GetName(IList<Person> person)
        {

            //IList<Person> abc = new List<Person>();
            //Person p3 = new Person();
            // String person1 = String.Empty;
            for (int i = 0; i < person.Count; i++)
            {
                Console.Write(person[i]._Name + " " + person[i]._Addresss + " ");
            }
            Console.WriteLine();
            return " ";
        }
        public double Average(IList<Person> person)
        {
            double totalAge = 0;
            for (int i = 0; i < person.Count; i++)
            {
                totalAge = totalAge + person[i]._Age;
            }
            Console.WriteLine(totalAge / person.Count);
            return 0.0;
        }
        public int Max(IList<Person> person)
        {
            int mAge = 0, temp = 0;
            for (int i = 0; i < person.Count; i++)
            {
                temp = person[i]._Age;
                if (temp > mAge)
                {
                    mAge = temp;
                }
            }
            Console.WriteLine(mAge);
            return 0;
        }
        // public static int[] Max(int[] _Age) => new[] { _Age.Max() };

        public static void Main()
        {
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            p.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });
            PersonImplementation pi = new PersonImplementation();
            pi.GetName(p);
            pi.Average(p);
            pi.Max(p);
            Console.ReadLine();
        }
    }
}

