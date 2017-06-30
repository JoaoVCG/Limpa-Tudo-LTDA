using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Relatorio
{
    public class RelatorioCliente
    {
        public static void RelatorioClientes()
        {

            List<Camadas.Model.Cliente> lstCli = new List<Camadas.Model.Cliente>();
            Camadas.BLL.Cliente bllCli = new Camadas.BLL.Cliente();
            lstCli = bllCli.Select();

            string folder = Diretorio.diretorioRaiz();
            string arquivo = folder + @"\RelatorioClientes.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatorio de Clientes</h1>");
                sw.WriteLine("<table>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px'  align='right'>ID</th>");
                sw.WriteLine("<th width ='120px' align='left'>NOME</th>");
                sw.WriteLine("<th width ='90px'  align='right'>ENDERECO</th>");
                sw.WriteLine("<th width ='90px'  align='right'>CIDADE</th>");
                sw.WriteLine("<th width ='90px'  align='right'>ESTADO</th>");
                sw.WriteLine("<th width ='30px'  align='center'>TELEFONE</th>");
                sw.WriteLine("</tr>");
                foreach(Camadas.Model.Cliente cliente in lstCli)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + cliente.id + "</td>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + cliente.nome + "</td>");
                    sw.WriteLine("<td width ='15px'  align='right'>" + cliente.endereco + "</td>");
                    sw.WriteLine("<td width ='30px'  align='center'>" + cliente.cidade + "</td>");
                    sw.WriteLine("<td width ='30px'  align='center'>" + cliente.estado + "</td>");
                    sw.WriteLine("<td width ='30px'  align='center'>" + cliente.telefone + "</td>");
                    sw.WriteLine("</tr>");
                }
            }
            System.Diagnostics.Process.Start(arquivo);

        }
    }
}