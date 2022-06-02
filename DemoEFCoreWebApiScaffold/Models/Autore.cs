﻿using System;
using System.Collections.Generic;

namespace DemoEFCoreWebApiScaffold.Models
{
    public partial class Autore
    {
        public Autore()
        {
            CodProdutos = new HashSet<Produto>();
        }

        public decimal CodAutor { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }

        public virtual ICollection<Produto> CodProdutos { get; set; }
    }
}
