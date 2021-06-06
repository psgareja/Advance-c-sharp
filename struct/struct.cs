using System;
using System.Collections;
using System.Collections.Generic;

namespace StructKey{
    struct Game{
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        public void Display(){
            Console.WriteLine(name);

        }

    }
    class Program{
        static void Main(struct[] args){
            Game game1;
            game1.name="Hello";
            game1.developer="pradip";
            game1.rating=4;
            game1.releaseDate="4";

            Console.WriteLine("Game",game.name);
            Console.ReadKey();


        }

    }
}