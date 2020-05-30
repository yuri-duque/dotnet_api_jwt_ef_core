using Domain.Models;
using Repository.ModelsRepository;
using System.Collections.Generic;
using System.Linq;

namespace Service.Models
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IList<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll().ToList();
        }

        public Usuario GetById(long id)
        {
            return _usuarioRepository.Find(id);
        }

        public Usuario Login(Usuario usuario)
        {
            var user = GetAll().FirstOrDefault(x => x.Nome.Equals(usuario.Nome) && x.Senha.Equals(usuario.Senha));

            return user;
        }

        public void Save(Usuario usuario)
        {
            _usuarioRepository.Save(usuario);
        }

        public void Update(Usuario usuario)
        {
            _usuarioRepository.Save(usuario);
        }

        public void Delete(Usuario usuario)
        {
            _usuarioRepository.Save(usuario);
        }
    }
}
