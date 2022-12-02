using System.ComponentModel.DataAnnotations;
using WebapiEVO.Models;

namespace WebapiEVO.ViewModels
{
    public class CreateFuncionarioViewModels
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string RG { get; set; }

        public string Foto { get; set; }

        public int DepartamentoID { get; set; }
    }
}