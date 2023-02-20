using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCOREMVC.Models
{
    public class HomeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> lista = new List<HomeModel>();

            item = new HomeModel();
            item.Id = 1;
            item.Nome = "Filipe";
            lista.Add(item);

            item = new HomeModel();
            item.Id = 2;
            item.Nome = "Aluno";
            lista.Add(item);

            return lista;
        }
    }
}
