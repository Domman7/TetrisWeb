﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Interfaces;
using Entities;

namespace ORMDal
{
    public class ORMGamesDal : IGamesDal
    {
        public Entities.Game GetByUserId(int userId)
        {
            var context = new DefaultDBContext();
            try
            {
                var game = context.Game.FirstOrDefault(item => item.UserId == userId);
                if (game == null)
                {
                    return null;
                }
                return new Entities.Game()
                {
                    Id = game.Id,
                    Score = game.Score,
                    GameDate = game.GameDate,
                    UserId = game.UserId
                };
            }
            finally
            {
                context.Dispose();
            }
        }

        public void AddGame(Entities.Game game)
        {
            var context = new DefaultDBContext();
            try
            {
                context.Game.Add(new Game()
                {
                    Score = game.Score,
                    GameDate = game.GameDate,
                    UserId = game.UserId
                });
                context.SaveChanges();
            }
            finally
            {
                context.Dispose();
            }
        }
    }
}
