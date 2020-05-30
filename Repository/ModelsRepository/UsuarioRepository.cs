using Domain.Models;
using Repository.Context;

namespace Repository.ModelsRepository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public UsuarioRepository(BaseContext ctx): base(ctx) { }
    }
}
