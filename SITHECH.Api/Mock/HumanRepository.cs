using SITHEC.Domain;
using static SITHEC.Domain.Enums.Enumerations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SITHECH.Api.Mock
{
    public class HumanRepository
    {
        private Human[] humans = new Human[5];

        public HumanRepository() 
        {
            humans[0] = new Human { Id = Guid.NewGuid(), Name = "JUAN GONZALEZ ESTRADA", Gender = Gender.Masculino, Age = 28, Size = 170, Weight = 80 };
            humans[1] = new Human { Id = Guid.NewGuid(), Name = "ANA NAVA ESTRADA", Gender = Gender.Femenino, Age = 27, Size = 160, Weight = 60 };
            humans[2] = new Human { Id = Guid.NewGuid(), Name = "PEDRO CASTRO MENDEZ", Gender = Gender.Masculino, Age = 25, Size = 180, Weight = 76 };
            humans[3] = new Human { Id = Guid.NewGuid(), Name = "LUIS MENDEZ GONZALEZ", Gender = Gender.Masculino, Age = 29, Size = 178, Weight = 89 };
            humans[4] = new Human { Id = Guid.NewGuid(), Name = "MINERVA VILLEGAS FLORES", Gender = Gender.Femenino, Age = 38, Size = 160, Weight = 70 };
        }

        public Human[] GetAll()
        {
            return humans;
        }
    }
}
