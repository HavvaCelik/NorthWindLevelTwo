using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.DomainModels
{
    public class Cart: IDomainModel
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        //Sepeti başlattığınız zaman citline ı olmaz o nedenle constructır ında instance oluşturulur.
        public List<CartLine> CartLines { get; set; }
       
    }
}
