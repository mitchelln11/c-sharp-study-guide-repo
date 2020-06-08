using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Abstraction
{
    class AbstractionDerivedHorse : AbstractionParent // Don't forget to add the colon in order to inherit from the parent
    {
        public override void animalSound() // Don't forget to add the override keyword in order to be able to use methods from the parent
        {
            Console.WriteLine("Hee Haw");
        }
    }
}
