using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Abstract;

namespace Entities.DomainModels
{
    //sepet detayı
    public class CartLine: IDomainModel
    {
        public Product  Product { get; set; }
        public int Quantity { get; set; }
    }
}
