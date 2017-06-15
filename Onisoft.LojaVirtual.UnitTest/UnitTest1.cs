using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Onisoft.LojaVirtual.Web.Models;
using Onisoft.LojaVirtual.Web.HtmlHelpers;

namespace Onisoft.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTestOnisoft
    {
        [TestMethod]
        public void TestarSePaginacaoCorreta()
        {
            //Arrange
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 5,
                ItensTotal = 20
            };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            // Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);

            // Assert

            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString()
                );
        }
    }
}
