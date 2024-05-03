using System.ComponentModel.DataAnnotations;

namespace Orange_Beauty.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(maximumLength: 100, MinimumLength = 5, ErrorMessage = "O nome deve conter de 5 à 100 caracteres.")]
        public string NomeCli { get; set; }


        [Display(Name = "E-mail")]
        [RegularExpression(@"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*\s+<(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})>$|^(\w[-._\w]*\w@\w[-._\w]*\w\.\w{2,3})$", ErrorMessage = "Formato do E-mail Inválido.")]
        public string? EmailCli { get; set; }


        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Telefone está faltando digito.")]
        public string TelefoneCli { get; set; }


        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF está faltando digito.")]
        public string CPFCli { get; set; }


        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string LogradouroFunc { get; set; }


        [Display(Name = "Complemento")]
        public string? ComplementoFunc { get; set; }


        [Display(Name = "CEP")]
        [StringLength(8)]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string CEPFunc { get; set; }


        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string CidadeFunc { get; set; }


        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string EstadoFunc { get; set; }


        [Display(Name = "Data do Cadastro")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public DateTime DtCadastroFunc { get; set; }
    }
}
