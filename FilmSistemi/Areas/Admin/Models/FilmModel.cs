﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FilmSistemi.Models;
namespace FilmSistemi.Areas.Admin.Models
{
    public class FilmModel
    {
        public Movies Movies { get; set; }
        public Actors Actors { get; set; }
        public Categories Categories { get; set; }
        //public MoviePicture Picture { get; set; }

        //, FilmModel actor
        //  Actors artiz = new Actors();
    }
}