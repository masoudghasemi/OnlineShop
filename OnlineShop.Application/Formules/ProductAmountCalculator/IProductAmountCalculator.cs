using OnlineShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Formules.ProductAmountCalculator
{
    public interface IProductAmountCalculator
    {



        public int Calculate(ProductCategory productCategory);
    }
}
