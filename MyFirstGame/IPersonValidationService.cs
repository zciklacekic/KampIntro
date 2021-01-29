using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public interface IPersonValidationService
    {
        bool ValidatePerson(Players player);
    }
}
