using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TetrisWeb.Models.User
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
