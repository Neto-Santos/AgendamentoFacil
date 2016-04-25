using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using ControleDeServicos.DAL;
using ControleDeServicos.Models;

namespace ControleDeServicos.Consultas.Clientes
{
  public class ConsultaClientes
  {
    private readonly ControleDeServicoContext _db = new ControleDeServicoContext();

    public List<Cliente> BuscarClientePeloNome(string name)
    {
      var cliente = (from c in _db.Clientes
        where String.Equals(c.Nome, name, StringComparison.CurrentCultureIgnoreCase)
        select c).ToList();

      return cliente;
    }

  }
}