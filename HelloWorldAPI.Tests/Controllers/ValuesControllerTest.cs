using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using HelloWorldAPI.Controllers;

namespace HelloWorldAPI.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() > 0);
            foreach (var item in result)
            {
                Assert.IsTrue(!string.IsNullOrWhiteSpace(item));
            }
        }

        [TestMethod]
        public void GetById()
        {
            //Place Holder for Future Tests. 
        }

        [TestMethod]
        public void Post()
        {
            //Place Holder for Future Tests. 
        }

        [TestMethod]
        public void Put()
        {
            //Place Holder for Future Tests. 
        }

        [TestMethod]
        public void Delete()
        {
            //Place Holder for Future Tests. 
        }
    }
}
