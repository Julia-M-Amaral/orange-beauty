using System.ComponentModel.DataAnnotations;

namespace Orange_Beauty.Models
{
    public class NivelAcesso
    {
        public int NivelAcessoID { get; set; }


        [Display(Name = "Tipo de Acesso")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string NomeNivelAcesso { get; set; }
    }
}
