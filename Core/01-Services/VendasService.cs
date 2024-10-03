using Core._02_Repository;
using Core._03_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._02_Repository;

namespace Core._01_Services
{
    public class VendasService
    {
        public VendasRepository repository { get; set; }
        public VendasService(string _config)
        {
            repository = new VendasRepository(_config);
        }
        public void Adicionar(Vendas produto)
        {
            repository.Adicionar(produto);
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }

        public List<Vendas> Listar()
        {
            return repository.Listar();
        }
        public Vendas BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }
        public void Editar(Vendas editPessoa)
        {
            repository.Editar(editPessoa);
        }
    }
}
