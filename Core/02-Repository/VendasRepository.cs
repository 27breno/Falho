using Core._03_Entidades;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repository
{
    public class VendasRepository
    {
        private readonly string ConnectionString;
        public VendasRepository(string connectioString)
        {
            ConnectionString = connectioString;
        }
        public void Adicionar(Vendas endereco)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Vendas>(endereco);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            Vendas endereco = BuscarPorId(id);
            connection.Delete<Vendas>(endereco);
        }
        public void Editar(Vendas endereco)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<Vendas>(endereco);
        }
        public List<Vendas> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Vendas>().ToList();
        }
      
        public Vendas BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<Vendas>(id);
        }
    }
}
