using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class GamesDAL : IGamesDal
    {
        private List<Game> games = new List<Game>();

        public Game GetById(int id)
        {
            return games.FirstOrDefault(item => item.Id == id);
        }

        public Game GetByUserId(int userId)
        {
            return games.FirstOrDefault(item => item.UserId == userId);
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }
    }
}