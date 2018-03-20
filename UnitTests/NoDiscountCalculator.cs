﻿using System.Collections.Generic;
using System.Linq;

namespace Basket.UnitTests
{
    /// <summary>
    /// Discount Calculator that does not apply discounts
    /// for unit test purposes, provides allows cleaner
    /// unit tests than using a Mocking interface.
    /// </summary>
    public class NoDiscountCalculator : IDiscountCalculator
    {
        public decimal Calculate(List<BasketItem> basketItems)
        {
            return basketItems.Sum(x => x.Product.Price * x.Count);
        }
    }
}