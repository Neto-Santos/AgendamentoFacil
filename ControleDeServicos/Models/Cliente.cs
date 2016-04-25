using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeServicos.Models
{
  public class Cliente
  {
    public int Id { get; set; }
    
    [Required, MaxLength(50), MinLength(3)]
    public string Nome { get; set; }
    
    [Required]
    public string Telefone1 { get; set; }
    
    public string Telefone2 { get; set; }
    
    public string Cpfcnpj { get; set; }
    
    public string Endereco { get; set; }
    
    public ICollection<Agendamento> Agendamentos { get; set; }
  }
}