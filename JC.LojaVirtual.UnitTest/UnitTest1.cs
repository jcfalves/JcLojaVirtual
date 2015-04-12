using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

using System.Linq;


namespace JC.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        public void TestMethod1()
        {
        }


        //O operador Take e usado para selecionar os primeiros n objetos de uma Coleção
        [TestMethod]
        public void Take()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var resultado = from num in numeros.Take(5) select num;

            int[] teste = { 5, 4, 1, 3 , 9};

            CollectionAssert.AreEqual(resultado.ToArray(), teste);


        }


        //O operador Skip ignora  o(s) primeiro(s) n objetos de uma Coleção
        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;
            int[] teste = { 1, 3, 9 };

            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }



    }
}
