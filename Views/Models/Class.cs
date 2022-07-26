using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Views.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Titulo é Obrigatorio !!")]//aciona uma validação
        [StringLength(30, MinimumLength = 3, ErrorMessage = "O titulo prescisa ter entre 3 e 60 caracteres !!")]//aciona uma validação
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]//aciona uma validação
        [Required(ErrorMessage = "Ocampo Data de Lancamento é obrigatório")]//aciona uma validação
        [Display(Name = "Data de Lançamento")]//?
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato invalido ( Teste ) ")]//validação
        [StringLength(30, ErrorMessage = "maximo de 30 caracteres!! ")]//validação
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]//validação
        [Required(ErrorMessage = "Preencha o campo com um valor !")]//validação

        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha a Sinopse")]//validação
        [StringLength(300, ErrorMessage = "maximo de 300 caracteres!! ")]//validação
        public string Sinopse { get; set; }

        [Required(ErrorMessage = "Preencha a avaliação")]//validação
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Spmente numeros !")]//validação
        public int Avaliacao { get; set; }

    }
}