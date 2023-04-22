using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AnalistaQualidadeTeste.Models
{
    public class Painel
    {

        [Key]

        [DisplayName("#: ")]
        public int Id { get; set; }

        [DisplayName("Título: ")]
        [Required(ErrorMessage = "O campo {0} é requirido")]
        [MaxLength(30, ErrorMessage = "No máximo 30 caracteres")]
        public string Titulo { get; set; }

        [DisplayName("Tipo: ")]
        [Required(ErrorMessage = "O campo {0} é requirido")]
        [MaxLength(30, ErrorMessage = "No máximo 30 caracteres")]
        public string Tipo { get; set; }

        [DisplayName("Prioridade: ")]
        [Required(ErrorMessage = "O campo {0} é requirido")]
        public string Prioridade { get; set; }

        [DisplayName("Data de abertura: ")]
        public DateTime DataAbertura { get; set; }

        [Required(ErrorMessage = "O campo {0} é requirido")]

        [DisplayName("Responsável: ")]
        public string Responsavel { get; set; }

        [DisplayName("Descrição: ")]
        public string Descricao { get; set; }

        [DisplayName("Nova observação: ")]
        public string NovaObservacao { get; set; }
        public bool Ativo { get; set; }

    }
}