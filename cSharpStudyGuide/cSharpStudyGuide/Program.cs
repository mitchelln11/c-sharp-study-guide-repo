using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cSharpStudyGuide.Tests;
using cSharpStudyGuide.Encapsulation;
using cSharpStudyGuide.Inheritance;
using cSharpStudyGuide.Abstraction;
using cSharpStudyGuide.Suffixes;
using cSharpStudyGuide.Reflection;
using cSharpStudyGuide.Dictionaries;
using cSharpStudyGuide.OutParameter;


namespace cSharpStudyGuide
{
    class Program
    {
        // Keep examples in the same order as the added using statements
        static void Main(string[] args)
        {
            ////////////////// DIFFERENT FOLDER EXAMPLE BELOW /////////////////////
            // Must add using statement with namespace AND folder name
            //Vendor v = new Vendor();
            //v.buySoda();

            // Absolute Value checker
            //AbsoluteMatching match = new AbsoluteMatching();
            //match.AbsChecker();
            //Console.ReadLine();

            ////////////////// NameEncapsulation EXAMPLES BELOW /////////////////////

            //NameEncapsulation person = new NameEncapsulation();
            //person.Name = "Timmy";
            //Console.WriteLine(person.Name);
            //Console.ReadLine();

            //-----------------------------------------------------------------------

            //// You can add multiples this way
            //NameEncapsulation person = new NameEncapsulation();
            //person.Name = "Timmy";

            //NameEncapsulation person2 = new NameEncapsulation();
            //person2.Name = "Tony";

            //Console.WriteLine(person.Name); // Must call the variable, or you will just get cSharpStudyGuide, Encapsulation, NameEncapsulation
            //Console.WriteLine(person2.Name);
            //Console.ReadLine();

            //-----------------------------------------------------------------------

            // If something already exists, or was declared in the private variable, you can access it this way.
            //NameEncapsulation person = new NameEncapsulation();

            //Console.WriteLine(person.Name);
            //Console.ReadLine();



            ////////////////// BASE/DERIVED CLASS INHERITANCE EXAMPLES BELOW /////////////////////

            // I am instantiating 2 classes from derived child classes.
            // DerivedClassChild myCar = new DerivedClassChild();
            // Below, I'm calling the brand from the parent. Notice how I'm not referring to the actual parent, but rather the Derived class. It works because the Derived class is inheriting from the Parent/Base class.
            // Console.WriteLine($"I own a {myCar.brand} {myCar.modelName}");
            // myCar.honk();

            // DerivedClassChild2 secondCar = new DerivedClassChild2();
            // Console.WriteLine($"I own a {secondCar.brand} {secondCar.modelName}");
            // secondCar.honk();
            // Console.ReadLine();
            // Notice how the .brand and honk method can be used in both Instantiated Derived classes that come from the Parent.

            ////////////////// ABSTRACT AND OVERRIDE EXAMPLES BELOW /////////////////////
            // Both Instantiated animals are using the same method as their parent, but they're getting different results because of the Derived classes overridding the null parent.
            //AbstractionDerivedHorse horse = new AbstractionDerivedHorse();
            //horse.animalSound();

            //AbstractionDerivedLion lion = new AbstractionDerivedLion();
            //lion.animalSound();

            //Console.ReadLine();

            ////////////////// Reflection EXAMPLE BELOW /////////////////////

            // Another way to look for the type
            //var person = new Person();
            //Type personType = person.GetType(); // use typical lowercase version

            //Type personType = typeof(Person); // when using typeof, use the capital version of the object (Person) Same as above, less code
            //var properties = personType.GetProperties();
            //foreach (var item in properties)
            //{
            //    Console.WriteLine($"Property: Assembly {item.PropertyType.Assembly} \r\n" +
            //        $"Fullname: {item.PropertyType.FullName} \r\n" +
            //        $"BaseType: {item.PropertyType.BaseType} \r\n" +
            //        $"AssemblyQualifiedName: {item.PropertyType.AssemblyQualifiedName} \r\n" +
            //        $"Module: {item.PropertyType.Module} \r\n" +
            //        $"Attributes: {item.PropertyType.Attributes} \r\n" +
            //        $"Name: {item.Name} \r\n");
            //}

            //var methods = personType.GetMethods();
            //foreach (var item in methods)
            //{
            //    Console.WriteLine($"Item Name: {item.Name}");
            //}
            //Console.ReadKey();

            /////////////// Binary Gaps Test /////////////////////////
            //BinaryGaps gap = new BinaryGaps();
            //gap.BinaryGapSolution(10);
            //Console.ReadKey();

            // Instantiate OutParam Class
            OutParam pars = new OutParam();

            // Set new variables, values are set on OutParam class instead of here
            double summary, counted, averages;

            // Run method with arguments on the Program class instead of the OutParam parameters
            pars.OutAverage(out summary, out counted, out averages);
            Console.ReadLine();
        }
    }
}
