using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("tb_usuario")]
    public class Usuario
    {
        [Key]
        [Required]
        public long Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Senha { get; set; }

        public static void Map(ModelBuilder modelBuilder)
        {
            var map = modelBuilder.Entity<Usuario>();
            map.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
