using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpStudyGuide.Abstraction
{
    class AbstractionDerivedLion : AbstractionParent // Error will be added to the left hand side if nothing is declared inside. Adding a statement will make it go away
    {
        public override void animalSound()
        {
            Console.WriteLine("Rooooaaaaaarrr"); 
        }
    }
}
