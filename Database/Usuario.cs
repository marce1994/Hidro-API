using System.ComponentModel.DataAnnotations;

namespace Database{
    public class Usuario{
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NumeroDocumento{ get; set; }

        public TipoDocumento TipoDocumento{ get; set; }
    }
}