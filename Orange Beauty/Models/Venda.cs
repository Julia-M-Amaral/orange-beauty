using System.ComponentModel.DataAnnotations;

namespace Orange_Beauty.Models
{
    public class Venda
    {
        public int VendaID { get; set; }


        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int FuncionarioID { get; set; }


        [Display(Name = "Produto")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int ProdutoID { get; set; }


        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public int ClienteID { get; set; }


        [Display(Name = "Data da Venda")]
        [DisplayFormat(DataFormatString = "{0:dd/mm/aaaa}")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public DateTime DataVenda { get; set; }


        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public decimal PrecoProd { get; set; }


        [Display(Name = "Observações")]
        public string? DescricaoProd { get; set; }
    }
}
