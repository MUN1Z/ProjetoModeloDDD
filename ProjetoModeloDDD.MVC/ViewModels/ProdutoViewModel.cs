using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999")]
        public decimal Valor { get; set; }

        [DisplayName("Disponivel?")]
        public bool Disponivel { get; set; }
        public int ClienteId { get; set; }

        public virtual ClienteViewModel cliente { get; set; }
    }
}