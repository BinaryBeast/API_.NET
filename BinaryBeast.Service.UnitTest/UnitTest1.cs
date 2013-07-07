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
            BinaryBeastService service = new BinaryBeastService("07d9ccc26b546a3e3be2461ba3077051.51d713aa5aeaf7.78443715");

            dynamic result = service.TournamentService.GetBracketsAsync("xHotS1307027").Result;


        }
    }
}
