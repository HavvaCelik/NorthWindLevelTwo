using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            //sepetin içindeki yani cartline daki =>  sepetin içindeki carline lara bak her bir cardline için 
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductID == product.ProductID);
            //cardline içi boş değilse cardline nin mquantitysini arttır
            if (cartLine!=null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
            }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productID)
        {
            cart.CartLines.Remove(item: cart.CartLines.FirstOrDefault(c => c.Product.ProductID == productID));
        }
    }
}
