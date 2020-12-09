using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsForm
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base()
        {
            SetSpecies(SPECIES.DOG);
            SetCanFly(false);
            SetName(name);
            SetAge(age);


        }
    }
}
