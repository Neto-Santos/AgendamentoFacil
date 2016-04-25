using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using ControleDeServicos.Models;

namespace ControleDeServicos.DAL
{
	public class ControleDeServicosInicializador : System.Data.Entity.DropCreateDatabaseAlways<ControleDeServicoContext>
	{
		protected override void Seed(ControleDeServicoContext context)
		{

		  var clientes = new List<Cliente>
		  {
        new Cliente{Cpfcnpj = "000.000.000-0", Endereco = "Rua Neo Alves Martins, 103", Nome = "Maria Fernanda", Telefone1 = "(44) 9832-2313", Telefone2 = "(44) 3233-1949"},
        new Cliente{Cpfcnpj = "000.000.000-0", Endereco = "Rua Vital de Negreiros, 654", Nome = "Maria Jaquina", Telefone1 = "(44) 9832-9966", Telefone2 = "(44) 3233-4578"},
        new Cliente{Cpfcnpj = "000.000.000-0", Endereco = "Rua Neo Alves Martins, 987", Nome = "Fernanda Maria", Telefone1 = "(44) 9832-2336", Telefone2 = "(44) 3233-6547"},
        new Cliente{Cpfcnpj = "000.000.000-0", Endereco = "Rua Neo Alves Martins, 110", Nome = "Josefa Ferda", Telefone1 = "(44) 9832-2336", Telefone2 = "(44) 3233-4561"},
        new Cliente{Cpfcnpj = "000.000.000-0", Endereco = "Rua Neo Alves Martins, 987", Nome = "Fernanda Maria", Telefone1 = "(44) 9832-2336", Telefone2 = "(44) 3233-6547"}
		  };

      clientes.ForEach(c => context.Clientes.Add(c));
		  context.SaveChanges();

			var servicos = new List<Servico>
			{
        new Servico{ClienteId = 1, Descricao = "Corte de cabelo", Data = new DateTime(2016,4,1,8,30,0), Preco = 65m},
        new Servico{ClienteId = 2, Descricao = "Relaxamento"    , Data = new DateTime(2016,4,1,8,30,0), Preco = 125m},
        new Servico{ClienteId = 3, Descricao = "Escovinha"      , Data = new DateTime(2016,4,1,8,30,0), Preco = 95m},
        new Servico{ClienteId = 4, Descricao = "Penteado"       , Data = new DateTime(2016,4,1,8,30,0), Preco = 250m},
        new Servico{ClienteId = 1, Descricao = "Corte de cabelo", Data = HorarioRandomico(DateTime.Today), Preco = 65m},
        new Servico{ClienteId = 2, Descricao = "Relaxamento"    , Data = HorarioRandomico(DateTime.Today), Preco = 125m},
        new Servico{ClienteId = 3, Descricao = "Escovinha"      , Data = HorarioRandomico(DateTime.Today), Preco = 95m},
        new Servico{ClienteId = 4, Descricao = "Penteado"       , Data = HorarioRandomico(DateTime.Today), Preco = 250m},
			};

			servicos.ForEach(s => context.Servicos.Add(s));
			context.SaveChanges();
    }

	  private static DateTime HorarioRandomico(DateTime date)
	  {
	    var randon = new Random();
	    return new DateTime(date.Year, date.Month, date.Day, randon.Next(24), randon.Next(60), 0);
	  }
	}
}