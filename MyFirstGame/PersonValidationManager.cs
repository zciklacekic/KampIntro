using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class PersonValidationManager : IPersonValidationService
    {
        public bool ValidatePerson(Players player)
        {
            if (player.FirstName=="ZAFER" && player.LastName=="ÇIKLAÇEKİÇ" && player.NationalityId=="12345678901" && player.YearOfBirth==1976)
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
