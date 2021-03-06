﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoMZ2;

namespace MobelZonen2.Controllers
{
    public class ProduktController : Controller
    {
        KategoriFac kf = new KategoriFac();
        ProduktFac pf = new ProduktFac();
        // GET: Produkt
        public ActionResult ListProdukter(int id)
        {
            ProduktListe pl = new ProduktListe();
            pl.KategoriNavn = kf.Get(id).Navn;
            pl.Produkter = pf.GetBy("KatID", id);

            return View(pl);
        }
    }
}
