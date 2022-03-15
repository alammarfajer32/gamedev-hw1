using System;

namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 200;

            int damagedhealth = 20;

            int boostedhealth = 10;

            int damaged()
            {

                return health - damagedhealth;

            }
            int boosted()
            {

                return damaged() + boostedhealth;

            }
            int[] healtharray = { damaged(), boosted() };


            void hp()
            {
                if (damaged() < boosted())
                {
                    Console.WriteLine(damagedhealth + " less than " + boostedhealth);
                }

                else if (damaged() > boosted())
                {
                    Console.WriteLine(damagedhealth + " greater than " + boostedhealth);
                }
                else
                {
                    Console.WriteLine(damagedhealth + " equal " + boostedhealth);
                }
            }
            Console.WriteLine(" damaged health: " + damaged());
            Console.WriteLine(" boosted health " + boosted());
            Console.WriteLine(healtharray[1]);

            hp();







        }
    }
}
