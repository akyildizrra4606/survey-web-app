﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Kullanici
{
    public partial class Liste : System.Web.UI.Page
    {
        AnketEntities1 db = new AnketEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            lvKullaniciListe.DataSource = db.Kullanici.ToList();
            lvKullaniciListe.DataBind();
        }

        protected void btnSil_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            var sil = db.Kullanici.Where(k => k.Kullanici_ID == id).FirstOrDefault();
            db.Kullanici.Remove(sil);
            db.SaveChanges();
            Response.Redirect("Liste.aspx");
        }
    }
}