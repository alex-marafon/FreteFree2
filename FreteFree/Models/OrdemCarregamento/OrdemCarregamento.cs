using FreteFree.Models.Enum;
using FreteFree.Models.Processo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreteFree.Models.Motorista
{
    public class OrdemCarregamento
    {
        public OrdemCarregamento( DateTime DataOrdemCarregamento)
        {
            DataOrdemCarregamento = DateTime.Now;
     
        }

        [Key]
        [Display(Name = "ID")]
        public int OrdemCarregamentoId { get; set; }

        [Required(ErrorMessage = "Infome o Nome da Empresa")]
        [Display(Name = "Empresa")]
        [BindProperty(SupportsGet = true)]
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        [Required(ErrorMessage = "Infome o Nome do Motorista")]
        [Display(Name = "Motorista")]
        [BindProperty(SupportsGet = true)]
        public int MotoristaId { get; set; }
        public Motorista Motorista { get; set; }


        [Required(ErrorMessage = "Infome o Valor")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Infome o Tipo de Medida")]
        [Display(Name = " Tipo de Medida")]
        public Medida Medida { get; set; }

        [Required(ErrorMessage = "Infome a Data")]
        [Display(Name = " Data")]
        public DateTime DataOrdemCarregamento { get; set; }

        public bool Ativo { get; set; }

       

    }
}
