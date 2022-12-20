using Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class GamesBL : IGamesBL
    {
        private readonly IGamesDal _dal;

        public GamesBL(IGamesDal dal)
        {
            _dal = dal;
        }
        public Game GetByUserId(int userId)
        {
            return _dal.GetByUserId(userId);
        }

        public void AddGame(Game game)
        {
            _dal.AddGame(game);
        }
    }
}
