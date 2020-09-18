using System;

namespace InheritanceOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            CityDerivedClass myDerivedCity = new CityDerivedClass("New York");
            myDerivedCity.printCityName();
        }
    }

    public abstract class CityBaseClass{
        public string name;
        public CityBaseClass(string name){
            this.name = name;
        }
        public virtual void printCityName(){
            Console.Write("This is a virtual output");
        }
    }

    class CityDerivedClass:CityBaseClass{
        public CityDerivedClass(string name):base(name){
        }
        public override void printCityName(){
            Console.Write("This overrides the virtual method");
        }
    }
}
