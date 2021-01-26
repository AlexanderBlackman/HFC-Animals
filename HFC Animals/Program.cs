using System;

namespace HFC_Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            //       Animal animal = new Hippo();
            //        animal.Swim();
            //        Hippo hippo =  (Hippo)animal;
            //        hippo.Swim();

            Animal[] animals =
                {
                new Wolf(false),
                new Hippo(),
                new Wolf(true),
                new Wolf(false),
                new Hippo()
            };

            foreach (Animal animal in animals)
            {
                animal.MakeNoise();
                if (animal is ISwim swimmer)
                    swimmer.Swim();

                if (animal is IHuntInPack packHunter)
                    packHunter.HuntInPack();
            }
            Console.WriteLine();
        }
    }
}
