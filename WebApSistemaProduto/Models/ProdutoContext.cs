using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApSistemaProduto.Models
{
    public class ProdutoContext : DbContext
    {
     
    
        public ProdutoContext() : base("name=ProdutoContext")
        {
        }

        public DbSet<Produto> Produtoes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<WebApSistemaProduto.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<WebApSistemaProduto.Models.Pedido> Pedidoes { get; set; }
    }
}
