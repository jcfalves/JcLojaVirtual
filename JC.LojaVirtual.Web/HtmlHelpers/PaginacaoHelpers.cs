using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

using System.Web.Mvc;
using JC.LojaVirtual.Web.Models;


namespace JC.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        //Total de Paginas  = 3

        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int,string>paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i < paginacao.TotalPagina; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);
            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}