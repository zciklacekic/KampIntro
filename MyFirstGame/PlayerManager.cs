using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public class PlayerManager : IPlayerService
    {
        IPersonValidationService _personValidationService;

        public PlayerManager(IPersonValidationService personValidationService)
        {
            _personValidationService = personValidationService;
        }

        public void Add(Players player)
        {
            if (_personValidationService.ValidatePerson(player))
            {
                Console.WriteLine(player.NickName + " Player added");
            }
            else
            {
                throw new Exception("This person is not validated bu E-State");
            }
        }

        public void Delete(Players player)
        {
            Console.WriteLine(player.NickName + " Player deleted");
        }

        public void Update(Players player)
        {
            Console.WriteLine(player.NickName + " Player updated");
        }
    }
}
