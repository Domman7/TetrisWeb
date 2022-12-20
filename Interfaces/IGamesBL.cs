using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGamesBL
    {
        Game GetByUserId(int UserID);
        void AddGame(Game game);
    }
}

