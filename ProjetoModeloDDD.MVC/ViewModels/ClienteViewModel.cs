using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(2)]
        public string Sobrenome { get; set; }

        [Required]
        [MaxLength(150)]
        [EmailAddress]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        
        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}