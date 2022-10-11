using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIGNA.Models
{
    public class Pessoa
    {
        [Key]
        public int PESSOA_ID { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string NOME_FANTASIA { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string CNPJ_CPF { get; set; }
    }
}
