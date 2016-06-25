﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Profile;
using Ghsaa.Models;
namespace Ghsaa.Controllers
{

    //[RequireHttps]
    public class HomeController : Controller
    {

      
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
          public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

            public ActionResult FileUpload(HttpPostedFileBase file)
    {
        if (file != null)
        {
            string pic = System.IO.Path.GetFileName(file.FileName);
            string path = System.IO.Path.Combine(
                                   Server.MapPath("~/Images/profile"), pic); 
            // file is uploaded
            file.SaveAs(path);

            // save the image path path to the database or you can send image 
            // directly to database
            // in-case if you want to store byte[] ie. for DB
            using (MemoryStream ms = new MemoryStream()) 
            {
                 file.InputStream.CopyTo(ms);
                 byte[] array = ms.GetBuffer();
            }

        }
        // after successfully uploading redirect the user
        return RedirectToAction("actionname", "controller name");
    }
    }
}