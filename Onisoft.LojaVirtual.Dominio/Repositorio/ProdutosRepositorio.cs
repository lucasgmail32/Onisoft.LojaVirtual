﻿using System.Collections.Generic;
using Onisoft.LojaVirtual.Dominio.Entidade;

namespace Onisoft.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
