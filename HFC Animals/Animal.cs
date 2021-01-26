using System;
using System.Collections.Generic;
using System.Text;

namespace HFC_Animals
{
    abstract class Animal
    {
        public abstract void MakeNoise();
    }

    class Hippo: Animal, ISwim
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Glug glug Bwah!!!");
        }

        public void Swim()
        {
            Console.WriteLine("Wheee!!! I'm going for a swim");
        }
    }

    abstract class Canine : Animal
    {
        public bool AlphaInPack { get; protected set; } = false;
    }

    class Wolf : Canine, IHuntInPack
    {
        public Wolf(bool alphaInPack)
        {
            AlphaInPack = alphaInPack;
        }

        public override void MakeNoise()
        {
                if (AlphaInPack) 
                    Console.Write("Arrm drrr Arrrphrrr!!!");
                Console.WriteLine("aroooh!");
        }

        public void HuntInPack()
        {
            if (AlphaInPack) Console.WriteLine("Frrrwww meh!");
            else Console.WriteLine("Arr frrrww drrr arrphrr");
        }
        }

    class Dog : Canine, IHuntInPack, ISwim
    {

        public override void MakeNoise()
        {
            if (AlphaInPack)
                Console.WriteLine("I'm the big dog");
            Console.WriteLine("Woof Woof I can't speak English Woof Woof");
        }

        public void HuntInPack()
        {
            if (AlphaInPack)
                Console.WriteLine("Woof I lead");
            else
                Console.WriteLine("Woof, I follow like a good boy");
        }

        public void Swim()
        {
            Console.WriteLine("paddle paddle wooof paddle shake");
        }
    }

    abstract class Feline: Animal  {  }

    class Lion: Feline, IHuntInPack
    {
        public override void  MakeNoise()
        {
            Console.WriteLine("Roaaaaaarrrrrgh!!!");
        }

        public void HuntInPack()
        {
            Console.WriteLine("Go ahead lionnesses, I'll wait until you finsh");
        }
    }

    class Tiger: Feline, ISwim
    {
        override public void MakeNoise() { 
        Console.WriteLine("Mmmr  Mmmr Mmmr Raaaargh");
    }
    
    public void Swim()
        {
            Console.WriteLine("Flop flop Raagh flop");
        }
    
    }

    class Bobcat: Feline
    {
        override public void MakeNoise()
        {
            Console.WriteLine("Purrrr  purrr");
        }
    }


}






