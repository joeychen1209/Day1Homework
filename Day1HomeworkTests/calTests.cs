using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ExpectedObjects;

namespace Day1Homework.Tests
{
    [TestClass()]
    public class calTests
    {
        [TestMethod()]
        public void SumTest_3筆一組取Cost總和()
        {

            var expected = new List<int>() { 6, 15, 24, 21 };
            var target = new cal();
            var actual = target.Sum<Prod>(GetData(), "Cost", 3);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void SumTest_4筆一組取Revenue總和()
        {

            var expected = new List<int>() { 50, 66, 60 };
            var target = new cal();
            var actual = target.Sum<Prod>(GetData(), "Revenue", 4);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        internal class Prod
        {
            public int Id { set; get; }
            public float Cost { set; get; }
            public decimal Revenue { set; get; }
            public long SellPrice { set; get; }
        }

        internal List<Prod> GetData()
        {
            var data = new List<Prod>
            {
                new Prod {Id=1,Cost=1,Revenue=11,SellPrice=21 },
                new Prod {Id=2,Cost=2,Revenue=12,SellPrice=22 },
                new Prod {Id=3,Cost=3,Revenue=13,SellPrice=23 },
                new Prod {Id=4,Cost=4,Revenue=14,SellPrice=24 },
                new Prod {Id=5,Cost=5,Revenue=15,SellPrice=25 },
                new Prod {Id=6,Cost=6,Revenue=16,SellPrice=26 },
                new Prod {Id=7,Cost=7,Revenue=17,SellPrice=27 },
                new Prod {Id=8,Cost=8,Revenue=18,SellPrice=28 },
                new Prod {Id=9,Cost=9,Revenue=19,SellPrice=29 },
                new Prod {Id=10,Cost=10,Revenue=20,SellPrice=30 },
                new Prod {Id=11,Cost=11,Revenue=21,SellPrice=31 }
            };

            return data;
        }
    }
}