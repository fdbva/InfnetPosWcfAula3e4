using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using News.Tests.PublicacaoService;

namespace News.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var noticia = new Noticia
            {
                Id = Guid.NewGuid(),
                Titulo = "Sonho do dia",
                Conteudo = "Dólar cai a R$2,00",
                Publicacao = DateTime.Now,
                Expiracao = DateTime.Now.AddDays(1)
            };
            var client = new PublicacaoServiceClient();
            client.Open();
            var qtdNoticiasAntes = client.ObterNoticiasPublicadas().Length;
            var resultPublicarNoticia = client.PublicarNoticia(noticia);
            var qtdNoticiasDepois = client.ObterNoticiasPublicadas().Length;
            client.Close();

            Assert.IsTrue(resultPublicarNoticia);
            Assert.AreEqual(qtdNoticiasAntes+1, qtdNoticiasDepois);
        }
    }
}
