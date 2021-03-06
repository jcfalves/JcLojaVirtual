﻿using System;
using System.Collections.Generic;

using System.Linq;

using System.Web;
using System.Web.Mvc;

using JC.LojaVirtual.Dominio.Repositorio;
//using JC.LojaVirtual.Web.Models;

using System.Web.UI.WebControls;


namespace JC.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 3;


        //
        // GET: /Vitrine/
        public ActionResult ListaProdutos(int pagina =1)
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p => p.Descricao)
                .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);

            return View(produtos);
        }
	}
}