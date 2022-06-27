using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDExampleApp.Models.Response;

namespace TDDExampleApp.Test
{
    [TestClass]
    public class InventoryResponse
    {
        [TestMethod]
        public void IfQuantityEqualsZeroReturnsUnavailable()
        {
            //arrange
            string productId = "p93531907";
            decimal quantity = 0;
            bool available = false;

            //act
            var item = new Item(productId, quantity);
            available = item.AvailableVerify(item.Quantity);
            item.Available = available;

            //assert
            Assert.IsNotNull(item);
            Assert.IsTrue(item.Quantity == 0);
            Assert.IsTrue(item.Available == false);
        }

        [TestMethod]
        public void IfQuantityGreaterThanZeroReturnsAvailable()
        {
            //arrange
            string productId = "p93531907";
            decimal quantity = 9;
            bool available = true;

            //act
            var item = new Item(productId, quantity);
            available = item.AvailableVerify(item.Quantity);
            item.Available = available;

            //assert
            Assert.IsNotNull(item);
            Assert.IsTrue(item.Quantity > 0);
            Assert.IsTrue(item.Available == true);
        }
    }
}
