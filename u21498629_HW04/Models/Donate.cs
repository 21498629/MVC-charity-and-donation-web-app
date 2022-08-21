using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21498629_HW04.Models
{
    public abstract class Donate
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Cellphone { get; set; }
        public bool NewsLetter { get; set; }
        public HttpPostedFileBase File { get; set; }



        public Donate()
        {

        }

        public Donate(string name, string surname, string email, int cellphone, bool newsletter, HttpPostedFileBase file)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Cellphone = cellphone;
            NewsLetter = newsletter;
            File = file;
        }

        public virtual HttpPostedFileBase uploadFile()
        {
            return File;
        }
    }
}