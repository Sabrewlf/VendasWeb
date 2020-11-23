using System;
using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class RecordVendas
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Montante { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor{ get; set; }

        public RecordVendas() 
        {

        }

        public RecordVendas(int id, DateTime data, double montante, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Date = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
