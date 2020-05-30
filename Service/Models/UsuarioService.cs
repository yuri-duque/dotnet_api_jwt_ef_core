using AutoMapper;
using Domain.DTO;
using Domain.Models;
using Repository.ModelsRepository;
using System.Collections.Generic;
using System.Linq;

namespace Service.Models
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(UsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public IList<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll().ToList();
        }

        public Usuario GetById(long id)
        {
            return _usuarioRepository.Find(id);
        }

        public Usuario Login(UsuarioLoginDTO usuarioDTO)
        {
            var user = GetAll().FirstOrDefault(x => x.Username.ToLower().Equals(usuarioDTO.Username.ToLower()) && x.Password.Equals(usuarioDTO.Password));

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

        public void Delete(long Id)
        {
            _usuarioRepository.Delete(x => x.Id == Id);
        }
    }
}
