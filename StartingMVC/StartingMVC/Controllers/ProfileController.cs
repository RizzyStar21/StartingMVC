using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartingMVC.Models;

namespace StartingMVC.Controllers
{
    public class ProfileController : Controller
    {
        //rizwan.com/Profile/RizzyStar21
        public ActionResult Index(string id)
        {
            Profile viewProfile = new Profile();

            switch(id)
            {
                case "RizzyStar21":
                    viewProfile.Username = id;
                    viewProfile.FirstName = "Rizwan";
                    viewProfile.LastName = "Something";
                    viewProfile.Age = "12";
                    viewProfile.Email = "chunkymonkey55@aol.com";
                    viewProfile.FavoriteColor = "Dark like my soul";
                    break;

                case "HaseebMohammed":
                    viewProfile.Username = id;
                    viewProfile.FirstName = "Haseeb";
                    viewProfile.LastName = "Mohammed";
                    viewProfile.Age = "28";
                    viewProfile.Email = "hunckymonkey55@aol.com";
                    viewProfile.FavoriteColor = "Big like my stomach";
                    break;

                case "TaiyyabIIT":
                    viewProfile.Username = id;
                    viewProfile.FirstName = "Taiyyab";
                    viewProfile.LastName = "Ahmed";
                    viewProfile.Age = "19";
                    viewProfile.Email = "Imsocool69@aol.com";
                    viewProfile.FavoriteColor = "Food Food Food";
                    break;

                case "Fayyajul":
                    viewProfile.Username = id;
                    viewProfile.FirstName = "Fayyaz";
                    viewProfile.LastName = "Haysaand";
                    viewProfile.Age = "Autistic";
                    viewProfile.Email = "imsmartsosmartthanksme@aol.com";
                    viewProfile.FavoriteColor = "Your so smart ... thanks me";
                    break;
            }


            return View(viewProfile);
        }
    }
}