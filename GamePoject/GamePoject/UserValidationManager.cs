using System;
using System.Collections.Generic;
using System.Text;

namespace GamePoject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Filiz" && gamer.LastName == "Gül"
                && gamer.BirthYear == 1993 && gamer.IdentityNumber == 109876)
            {
                return true;
            
            }
            else if( gamer.Id==4 && gamer.FirstName=="Gamze" && gamer.LastName=="Gül" && gamer.BirthYear==1992 
                && gamer.IdentityNumber==36911)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
