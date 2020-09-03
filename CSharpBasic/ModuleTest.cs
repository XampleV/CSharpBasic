using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasic
{
    class ModuleTest
    {
        string name;
        string age;
        bool hasDog;
        string dogName;

        // Methods

        void Greeting()
        {
            if (hasDog == true)
            {
                Console.WriteLine($"Hello {name}. Nice to meet you. I see you have a dog named {dogName} | Age: {age}.");
            }
            else
            {
                Console.WriteLine($"What {name}!!!!!");
            }
        }
    }
}
