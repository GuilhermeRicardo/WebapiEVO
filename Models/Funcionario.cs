using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebapiEVO.Models
{
    public class Funcionario
    {   
        [Key()]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string Foto { get; set; }
        
        [ForeignKey("Departamento")]
        public int DepartamentoID { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}