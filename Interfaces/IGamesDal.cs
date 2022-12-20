using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGamesDal
    {
        Game GetByUserId(int userId);
        void AddGame(Game game);
    }
}
