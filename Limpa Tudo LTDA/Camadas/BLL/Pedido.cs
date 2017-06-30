using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.BLL
{
    public class Pedido
    {
        public List<Model.Pedido> Select()
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            return dalPed.Select();
        }

        public List<Model.Pedido> SelectById(int id)
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            return dalPed.SelectById(id);
        }

        public List<Model.Pedido> SelectByCliente(int cliente)
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            return dalPed.SelectByCliente(cliente);
        }

        public void Insert(Model.Pedido Pedido)
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            dalPed.Insert(Pedido);
        }

        public void Update(Model.Pedido Pedido)
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            dalPed.Update(Pedido);
        }

        public void Delete(Model.Pedido Pedido)
        {
            DAL.Pedido dalPed = new DAL.Pedido();
            dalPed.Delete(Pedido);
        }
    }
}
