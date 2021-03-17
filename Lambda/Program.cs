using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //var matt = new Person()
            //{
            //    Name = "Matt",
            //    Username = "marainer",
            //    Age = 26
            //};
            //var phil = new Person()
            //{
            //    Name = "Phil",
            //    Username = "phtham",
            //    Age = 27
            //};
            //var tyler = new Person()
            //{
            //    Name = "Tyler",
            //    Username = "tylavay",
            //    Age = 30
            //};
            //var dmitry = new Person()
            //{
            //    Name = "Dmitry",
            //    Username = "dmlandy",
            //    Age = 23
            //};

            //var people = new List<Person>();
            //people.Add(dmitry);
            //people.Add(phil);
            //people.Add(matt);
            //people.Add(tyler);

            var matt = new OnlineProfile()
            {
                Name = "Matt",
                Username = "marainer",
                Email = "marainer"
            };
            var phil = new OnlineProfile()
            {
                Name = "Phil",
                Username = "phtham",
                Email = "phtham"
            };
            var tyler = new OnlineProfile()
            {
                Name = "Tyler",
                Username = "tylavay",
                Email = "tylavay"
            };
            var dmitry = new OnlineProfile()
            {
                Name = "Dmitry",
                Username = "dmlandy",
                Email = "dmlandy"
            };

            var people = new List<OnlineProfile>();
            people.Add(dmitry);
            people.Add(phil);
            people.Add(matt);
            people.Add(tyler);

            var isTylerEmail = people.Any2(people => people.Email == "tylavay");
            //var tyler1 = people.First(people => people.Name == "Tyler");

            //var peopleOver26 = people.Where2(p => p.Age >= 26);
            //var isPhil = peopleOver26.Any2(people => IsName(people, "Phil"));


            var yesNo = isTylerEmail ? "yes" : "no";
            Console.WriteLine($"Does tyler email? {yesNo}");
        }
    }
}
