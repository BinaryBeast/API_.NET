using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BinaryBeast.Service.Entities;

namespace BinaryBeast.Service.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BinaryBeastService service = new BinaryBeastService("TODO INSERT");

            dynamic result = service.TournamentService.GetBracketsAsync("xHotS1307027").Result;


        }
    }
}
