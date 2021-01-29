using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstGame
{
    public interface IPlayerService
    {
        void Add(Players player);
        void Update(Players player);
        void Delete(Players player);
    }
}
