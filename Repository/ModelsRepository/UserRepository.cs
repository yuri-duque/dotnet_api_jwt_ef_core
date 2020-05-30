using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository.ModelsRepository
{
    public static class UserRepository
    {
        public static Usuario Get(string username, string senha)
        {
            var users = new List<Usuario>();
            users.Add(new Usuario { Id = 1, Nome = "batman", Senha = "batman", Role = "manager" });
            users.Add(new Usuario { Id = 2, Nome = "robin", Senha = "robin", Role = "employee" });
            return users.Where(x => x.Nome.ToLower() == username.ToLower() && x.Senha == senha).FirstOrDefault();
        }
    }
}
