﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.BLL
{
    public class Produto
    {
        public List<Model.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public List<Model.Produto> SelectById(int id)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectById(id);
        }

        public List<Model.Produto> SelectByNome(string nome)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByNome(nome);
        }

        public void Insert(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Insert(Produto);
        }

        public void Update(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Update(Produto);
        }

        public void Delete(Model.Produto Produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            dalProd.Delete(Produto);
        }
    }
}
