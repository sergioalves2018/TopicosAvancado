//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clsBanco
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estacionamento
    {
        public int id { get; set; }
        public Nullable<System.DateTime> dataEntrada { get; set; }
        public Nullable<System.DateTime> dataSaida { get; set; }
        public string descricao { get; set; }
        public string nomeCliente { get; set; }
        public string telefone { get; set; }
        public Nullable<decimal> valor { get; set; }
    }
}