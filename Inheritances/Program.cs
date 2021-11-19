using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            //Miras alinan class da dahil butun classlar kullanilabilir.
            //Her bir class 1 kez miras alabilir.



            Player player = new Player();
            //player.Position;
            Coach coach = new Coach
            {
                Id = 1,
                Name = "Onur",
                Surname = "Agici",
                CoachPosition = "Head Coach",
               identity = 2
            };
            
            Person person = new Person();
            person.Name = "Hasan";

            Console.WriteLine(coach.CoachPosition);
            Console.WriteLine(coach.Id);
            Console.WriteLine(coach.Surname);
            Console.WriteLine(coach.Name);
            Console.ReadLine();
        }
    }

    class Person:Miras // Base Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    

    class Player:Person //Sub Class
    {
        public string Position { get; set; }
    }

    class Coach: Person //Sub Class
    {
        public string CoachPosition { get; set; }
    }
}
