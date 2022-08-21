using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace u21498629_HW04.Models
{
    public class Money : Donate
    {
        public int Amount {get; set;}
        public Money()
        {

        }

        public Money(string name, string surname, string email, int cellphone,bool newsletter, int amount, HttpPostedFileBase file)
        {
            Amount = amount;
        }

        public override HttpPostedFileBase uploadFile()
        {
            return File;
        }

    }
}