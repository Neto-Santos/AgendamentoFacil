using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ControleDeServicos.DAL;
using ControleDeServicos.Models;

namespace ControleDeServicos.Consultas.Servicos
{
  public class ConsultasDeServicos
  {
    private readonly ControleDeServicoContext _db = new ControleDeServicoContext();

    public IOrderedQueryable<Servico> BuscarServicosPorData(DateTime date)
    {
      var consulta = from serv in _db.Servicos
        where serv.Data >= date.Date
        orderby serv.Data
        select serv;

      return consulta;
    }
  }
}