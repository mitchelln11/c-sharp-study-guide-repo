using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Abstraction
{
    // NEED TO ADD ABSTRACT TO THE BEGINNING OF THE LINE BELOW, not there by default
    abstract class AbstractionParent
    {
        //public abstract string Horse(); // MUST be a method, no variables/fields apparently
        public abstract void animalSound(); // Will never have a body, abstract is only for when you have a shared method/class but not a possible default/starting value
        // No animal can have a default value
        // Will never create objects using AbstractionParent

        // Will NEVER look like the following
        // public abstract void animalSound()
        //  {
        //    Console.WriteLine("Generic animal sound");
        // }

        // If an abstract method is declared here, it MUST be used in every derived class that implements its parent
    }
}
