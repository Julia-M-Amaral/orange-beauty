using System.ComponentModel.DataAnnotations;

namespace Orange_Beauty.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }


        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string NomeProd { get; set; }


        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int CategoriaID { get; set; }


        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public decimal PrecoProd { get; set; }


        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string DescricaoProd { get; set; }


        [Display(Name = "Estoque disponível")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int EstoqueProd { get; set; }
    }
}
