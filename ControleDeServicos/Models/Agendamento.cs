using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeServicos.Models
{
  public class Agendamento
  {
    [Required]
    public Cliente ClienteId { get; set; }

    [Required]
    public Servico ServicoId { get; set; }

    [Required]
    public DateTime Horario { get; set; }

    public string Observacao { get; set; }

    public decimal Valor { get; set; }
  }
}