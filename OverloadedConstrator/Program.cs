using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedConstrator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //overloaded constractor : Technique to create multiple constractors 
            //                          with a different set of parameters.
            //                          name + parameters = signature


            Pizza pizza = new Pizza("Stuffed crust", "red sauce", "mozzarela");                       //Create object

            Console.ReadKey();

        }
        class Pizza                                          //define a class
        {   
            string bread;
            string sauce;
            string cheese;
            string topping;


            public Pizza(string bread)                                             //we just create a constractor using parameters
            {
                this.bread = bread;     

            }
            public Pizza(string bread, string sauce)                               //we just create a constractor using parameters
            {
                this.bread = bread;
                this.sauce = sauce;

            }
            public Pizza(string bread, string sauce, string cheese)                  //we just create a constractor using parameters
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
               
            }
            public Pizza(string bread, string sauce, string cheese, string topping)  //we just create a constractor using same name but different parameters its call overloaded constractor 
            {
                this.bread = bread;
                this.sauce = sauce;
                this.cheese = cheese;
                this.topping = topping;
            }
        }
    }
}
