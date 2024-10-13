using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
            Assert.That(result, Is.InstanceOf<ActionResult>());
        }

        [Test]
        public void GetCustomer_IdIsNonZero_ReturnOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(5);

            Assert.That(result, Is.TypeOf<Ok>());
            Assert.That(result, Is.InstanceOf<ActionResult>());
        }
    }
}
