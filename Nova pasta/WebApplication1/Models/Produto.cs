using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{

    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Name { get; set; }
    }
    public enum Estado
    {
        SP,
        RJ,
        MG
    }

    public class Produto
    {
        [HiddenInput]
        public int ProdutoId { get; set; }
        public string Name { get; set; } //
        public string Descricao { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; } //
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; } //
        public int? CategoriaId { get; set; }
        public Estado Estado { get; set; } //
        public bool Importado { get; set; } //
    }

}
