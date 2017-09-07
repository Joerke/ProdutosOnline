﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApSistemaProduto.Models
{
    public class ItemDoPedido
    {
        public int ID { get; set; }
        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }
    }
}