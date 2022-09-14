using RazorPagesPizza.Models;
using RazorPagesPizza.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDETAug2022.Models;



namespace MyFirstUnitTests
{
    public class MyClass_PizzaLib
    {
        [Fact]

        public void TestGetAllPizzas()
        {
            int expected = 2;
            int actual = PizzaService.GetAll().Count;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_AddPizza()
        {
            Pizza p = new Pizza { Name = "xxx", Size = PizzaSize.Medium, IsGlutenFree = true };

            PizzaService.Add(p);
            Pizza verify = PizzaService.Get(3);

            Assert.Equal(3, PizzaService.GetAll().Count);

            Assert.NotNull(verify.Id);

        }
        [Fact]
        public void Test_DeletePizza()
        {


        }
    }
}
