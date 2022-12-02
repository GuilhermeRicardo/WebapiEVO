using System.ComponentModel.DataAnnotations;

namespace WebapiEVO.Models
{
    public class Departamento
    {
        [Key()]
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public IEnumerable <Funcionario> Funcionarios { get; set; }        

    }
}