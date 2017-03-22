﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Survey.Models;

namespace Survey.Admin.Anket
{
    public partial class Onizleme : System.Web.UI.Page
    {
        AnketEntities db = new AnketEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request.QueryString["anket-id"]))
            {
                Response.Redirect("/Admin/Dashboard.apsx");
            }
            
            test.anketid = Convert.ToInt32(Request.QueryString["anket-id"]);
            var bas = db.Sorular.Where(s => s.Anket_ID == test.anketid).FirstOrDefault();
            lblBaslik.Text = bas.Anketler.Anket_Adi.ToString();
            var soruListe = db.Sorular.Where(s => s.Anket_ID == test.anketid).ToList();
            rptListe.DataSource = soruListe;
            rptListe.DataBind();   
                       
        }

        protected void rptListe_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Repeater rpt = (Repeater)e.Item.FindControl("rpt2Liste");
            //RadioButtonList rbl = (RadioButtonList)e.Item.FindControl("rbSec");
            CheckBoxList ckb = (CheckBoxList)e.Item.FindControl("ckbSec");
            test.soruid = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Soru_ID").ToString());
            var secListe = db.Secenekler.Where(s => s.Soru_ID == test.soruid).ToList();

            ckb.DataSource = secListe;
            ckb.DataTextField = "Secenek_Adi";
            ckb.DataValueField = "Secenek_ID";
            ckb.DataBind();

            //rbl.DataSource = secListe;
            //rbl.DataTextField = "Secenek_Adi";
            //rbl.DataValueField = "Secenek_ID";
            //rbl.DataBind();
        }
    }
}