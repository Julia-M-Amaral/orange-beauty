using System.ComponentModel.DataAnnotations;

namespace Orange_Beauty.Models
{
    public class Status
    {
        public int StatusID { get; set; }


        [Display(Name = "Status funcionário")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string NomeStatus { get; set; }
    }
}
