/*  OrderTest.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void OrderCalculatesCorrectCostWithOneOrder()
        {
            Brontowurst bw = new Brontowurst();
            Order order = new Order();
            order.Items.Add(bw);
            Assert.Equal(5.36, order.SubtotalCost, 2);
            Assert.Equal(5.84, order.TotalCost, 2);
        }

        [Fact]
        public void OrderCanTakeMultipleOrders()
        {
            Order order = new Order();
            order.Items.Add(new Brontowurst());
            order.Items.Add(new DinoNuggets());
            order.Items.Add(new TRexKingBurger());
            order.Items.Add(new Fryceritops
            {
                Size = Size.Large
            });
            order.Items.Add(new Tyrannotea());
            order.Items.Add(new Sodasaurus
            {
                Size = Size.Large
            });
            order.Items.Add(new Water());

            Assert.Equal(23.60, order.SubtotalCost, 2);
            Assert.Equal(25.71, order.TotalCost, 2);
        }
    }
}
