using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Relatorio
{
    public class RelatorioPedidos
    {
        public static void relatorioPedidos()
        {
            List<Camadas.Model.Pedido> lstPed = new List<Camadas.Model.Pedido>();
            Camadas.BLL.Pedido bllPed = new Camadas.BLL.Pedido();
            lstPed = bllPed.Select();
            string folder = Diretorio.diretorioRaiz();
            string arquivo = folder + @"\RelatorioPedidos.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatorio de Pedidos</h1>");
                sw.WriteLine("<table>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px'  align='right'>ID</th>");
                sw.WriteLine("<th width ='60px' align='left'>DATA</th>");
                sw.WriteLine("<th width ='30px' align='left'>CLIENTE</th>");
                sw.WriteLine("<th width ='50px' align='left'>NOME</th>");
                sw.WriteLine("</tr>");
                foreach (Camadas.Model.Pedido pedido in lstPed)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + pedido.id + "</td>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + pedido.data + "</td>");
                    sw.WriteLine("<td width ='30px' align='left'>" + pedido.cliente + "</td>");
                    sw.WriteLine("<td width ='15px'  align='right'>" + pedido.nome + "</td>");
                    sw.WriteLine("</tr>");
                }
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
