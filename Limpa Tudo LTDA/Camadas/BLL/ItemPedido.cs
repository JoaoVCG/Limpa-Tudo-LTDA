using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.BLL
{
    public class ItemPedido
    {
        public List<Model.ItemPedido> Select()
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            return dalItmPed.Select();
        }

        public List<Model.ItemPedido> SelectById(int id)
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            return dalItmPed.SelectById(id);
        }

        public List<Model.ItemPedido> SelectByPedido(int pedido)
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            return dalItmPed.SelectByPedido(pedido);
        }

        public void Insert(Model.ItemPedido ItemPedido)
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            Model.Produto produto = new Model.Produto();
            List<Model.Produto> lstProd = new List<Model.Produto>();
            lstProd = bllProd.SelectById(ItemPedido.produto);
            produto = lstProd[0];
            produto.status = 'V';
            bllProd.Update(produto);
            dalItmPed.Insert(ItemPedido);
        }

        public void Update(Model.ItemPedido ItemPedido)
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            dalItmPed.Update(ItemPedido);
        }

        public void Delete(Model.ItemPedido ItemPedido)
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            dalItmPed.Delete(ItemPedido);
        }

        public void Baixa(Model.ItemPedido ItemPedido)
        {
            DAL.ItemPedido dalItmPed = new DAL.ItemPedido();
            Camadas.BLL.Produto bllProd = new Camadas.BLL.Produto();
            Model.Produto produto = new Model.Produto();
            List<Model.Produto> lstProd = new List<Model.Produto>();
            lstProd = bllProd.SelectById(ItemPedido.produto);
            produto = lstProd[0];
            produto.status = 'L';
            bllProd.Update(produto);
            dalItmPed.Update(ItemPedido);
        }
    }
}
