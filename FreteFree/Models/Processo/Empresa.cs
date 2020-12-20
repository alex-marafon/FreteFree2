using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FreteFree.Models.Processo
{
    public class Empresa
    {
        public Empresa()
        {
         Empresas = new HashSet<Empresa>();
         Ativo = true;
         DateTime   DataCadastroEmpresa = DateTime.Now;
        }

        [Key]
        [Display(Name = "ID")]
        public int EmpresaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Responsavel do Empresa")]
        [Display(Name = "Nome Responsavel")]
        public string NomeResponsavel { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone Empresa da Empresa")]
        [Display(Name = "Telefone Empresa")]
        public decimal TelefoneEmpresa { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome Empresa do Empresa")]
        [Display(Name = "Nome Empresa")]
        public string NomeEmpresa { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade do Empresa")]
        [Display(Name = "Cidade Empresa")]
        public string CidadeEmpresa { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCadastroEmpresa { get; set; }

        public virtual ICollection<Empresa> Empresas { get; set; }

    }
}
