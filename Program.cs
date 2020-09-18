using System;
using System.Collections.Generic;
namespace InheritanceOverride
{

    class Program
    {
        static void Main(string[] args)
        {
            CityDerivedClass myDerivedCity = new CityDerivedClass("New York");
            myDerivedCity.printCityName();

            List<PersonalDetails> personalList = new List<PersonalDetails>();
            // Populate personalList
            personalList.Add(new PersonalDetails(55,"Joshpe","Male"));
            personalList.Add(new PersonalDetails(25,"Mary","Female"));
            personalList.Add(new PersonalDetails(10,"Lu","Male"));
            personalList.Add(new PersonalDetails(99,"Yoda","Male"));
            personalList.Add(new PersonalDetails(47,"Skywalker","Male"));

            // Find all age > 35
            List<PersonalDetails> ageOver35 = personalList.FindAll(person => person.age > 35);
            
            // Sort by firstname
            SortByFirstName mySort = new SortByFirstName();
            personalList.Sort(mySort);

            // Create list to be merged
            List<PersonalDetails> mergePersonalList = new List<PersonalDetails>();
            // Populate mergePersonalList
            mergePersonalList.Add(new PersonalDetails(14,"Juli","Female"));
            mergePersonalList.Add(new PersonalDetails(30,"Dacy","Female"));
            mergePersonalList.Add(new PersonalDetails(34,"Lucy","Female"));

            // Create list to store merged list
            List<PersonalDetails> combine = new List<PersonalDetails>();
            // Merge personalList and mergePersonalList
            combine.AddRange(personalList);
            combine.AddRange(mergePersonalList);

            // Remove all male personal from list
            personalList.RemoveAll(p => p.gender == "Male");
        }
    }

    public abstract class CityBaseClass
    {
        public string name;
        public CityBaseClass(string name)
        {
            this.name = name;
        }
        public virtual void printCityName()
        {
            Console.Write("This is a virtual output");
        }
    }

    class CityDerivedClass : CityBaseClass
    {
        public CityDerivedClass(string name) : base(name)
        {
        }
        public override void printCityName()
        {
            Console.Write("This overrides the virtual method");
        }
    }

    class PersonalDetails
    {
        public string firstname { get; set; }
        public int age;
        public string gender;
        public PersonalDetails(int age, string firstname, string gender)
        {
            this.age = age;
            this.firstname = firstname;
            this.gender = gender;
        }
    }
    class SortByFirstName : IComparer<PersonalDetails>
    {
        public int Compare(PersonalDetails a, PersonalDetails b)
        {
            return a.firstname.CompareTo(b.firstname);
        }
    }

}
