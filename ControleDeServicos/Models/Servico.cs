using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeServicos.Models
{
  public class Servico
  {
    public int Id { get; set; }

    [Required]
    public string Descricao { get; set; }
  }
}
