using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento{ get; set; }
        public ICollection<RecordVendas> Vendas { get; set; } = new List<RecordVendas>();

        public Vendedor() 
        {

        }

        public Vendedor(int id, string nome, string email, DateTime datanascimento, double salariobase, Departamento departamento) 
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = datanascimento;
            SalarioBase = salariobase;
            Departamento = departamento;
        
        }

        public void AddVendedor(RecordVendas rs) 
        {
            Vendas.Add(rs);
        }

        public void RemoveVendedor(RecordVendas rs)
        {
            Vendas.Remove(rs);
        }

        public double TotalVendas(DateTime inicial, DateTime final) 
        {
            return Vendas.Where(rs => rs.Date >= inicial && rs.Date <= final).Sum(rs => rs.Montante);
        }
    }

}
