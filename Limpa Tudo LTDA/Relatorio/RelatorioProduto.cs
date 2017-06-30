using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Relatorio
{
    public class RelatorioProduto
    {
        public static void relatorioProdutos()
        {
            List<Camadas.Model.Produto> lstProd = new List<Camadas.Model.Produto>();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            lstProd = bllProd.Select();
            string folder = Diretorio.diretorioRaiz();
            string arquivo = folder + @"\RelatorioProdutos.html";
            using (StreamWriter sw = new StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine(@"<meta http-equiv=\Content-type\Content=\'html; charset=utf-8\'");
                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatorio de Produtos</h1>");
                sw.WriteLine("<table>");
                sw.WriteLine("<tr>");
                sw.WriteLine("<th width ='30px'  align='right'>ID</th>");
                sw.WriteLine("<th width ='60px' align='left'>DESCRICAO</th>");
                sw.WriteLine("<th width ='30px' align='left'>VALOR</th>");
                sw.WriteLine("<th width ='30px' align='left'>STATUS</th>");
                sw.WriteLine("</tr>");
                foreach (Camadas.Model.Produto produto in lstProd)
                {
                    sw.WriteLine("<tr>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + produto.id + "</td>");
                    sw.WriteLine("<td width ='30px'  align='right'>" + produto.descricao + "</td>");
                    sw.WriteLine("<td width ='30px' align='left'>" + produto.valor + "</td>");
                    sw.WriteLine("<td width ='15px'  align='right'>" + produto.status + "</td>");
                    sw.WriteLine("</tr>");
                }
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
