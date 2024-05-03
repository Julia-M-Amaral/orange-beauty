using System.ComponentModel.DataAnnotations;

namespace Orange_Beauty.Models
{
    public class Categoria
    {
            public int CategoriaID { get; set; }


            [Display(Name = "Categoria")]
            [Required(ErrorMessage = "Este campo é obrigatório.")]
            public string NomeCategoria { get; set; }
    }
}
