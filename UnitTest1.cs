using Microsoft.AspNetCore.Mvc.ModelBinding;
using FirstResponsiveWebAppTurner.Controllers;


namespace FirstResponsiveWebAppTurnerTest
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestGoodInput()
        {
            
            var AgeThisYear = new FirstResponsiveWebAppModel();

            AgeThisYear.BirthYear = 1992;
            int expected = 32;
            int? actual;

            
            actual = AgeThisYear.AgeThisYear();

           
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestZeroInput()
        {
            var AgeThisYear = new FirstResponsiveWebAppModel();

            AgeThisYear.BirthYear = 0;
            int expected = 2024;
            int? actual;

            actual = AgeThisYear.AgeThisYear();
            Assert.Equal(expected, actual);
        }

        [Fact]

        public void TestNegativeInput()

        {
            
            var AgeThisYear = new FirstResponsiveWebAppModel();

            AgeThisYear.BirthYear = -1;
            int expected = 2025;
            int? actual;

            actual = AgeThisYear.AgeThisYear();
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestInputGreaterThanCurrentYear() 
        {
            var AgeThisYear = new FirstResponsiveWebAppModel();

            AgeThisYear.BirthYear = 2025;
            int expected = -1;
            int? actual;

            actual = AgeThisYear.AgeThisYear();
            Assert.Equal(expected, actual);
        
        }
    }



}