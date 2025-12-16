using CropsDictonary.Core;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace CropsDictonary.Core.Tests
{
    public class UnitTest1
    {
        private ApplicationContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            return new ApplicationContext(options); 
        }

        private CropService CreateService(ApplicationContext context)
        {
            return new CropService(context);
        }

        [Fact]
        public void Test1()
        {
            var context = CreateContext();
            var service = CreateService(context);

            service.Add("Пшеница", 123, 22);
            Assert.Single(context.Crops);

            var crop = Assert.Single(context.Crops);
            Assert.Equal("Пшеница", crop.Name);
            Assert.Equal(123, crop.Price);
            Assert.Equal(22, crop.Quantity);
        }

        [Fact]
        public void Test2()
        {
            var context = CreateContext();
            var service = CreateService(context);

            var crop = new Crop
            {
                Name = "Кукуруз",
                Price = 94,
                Quantity = 991
            };

            context.Crops.Add(crop);
            context.SaveChanges();

            crop.Name = "Кукуруза";
            crop.Price = 49;
            crop.Quantity = 199;
            service.Edit(crop);

            var updated = Assert.Single(context.Crops);
            Assert.Equal("Кукуруза", updated.Name);
            Assert.Equal(49, updated.Price);
            Assert.Equal(199, updated.Quantity);
        }

        [Fact]
        public void Test3()
        {
            var context = CreateContext();
            var service = CreateService(context);

            var crop = new Crop
            {
                Name = "",
                Price = 200,
                Quantity = 2
            };

            context.Crops.Add(crop);
            context.SaveChanges();

            service.Delete(crop);
            Assert.Empty(context.Crops);
        }
    }
}
