﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalogo.API.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int ProdutoId { get; set; }
    
    [Required]
    [StringLength(80)]
    public string Nome { get; set; }
    
    [StringLength(300)]
    public string? Descricao { get; set; }
    
    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Preco { get; set; }
    
    [StringLength(300)]
    public string? ImagemUrl { get; set; }
    
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }
    

}