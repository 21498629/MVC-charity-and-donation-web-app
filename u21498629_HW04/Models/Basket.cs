using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21498629_HW04.Models
{
    public class Basket: Donate
    {
        public string Items { get; set; }

        public Basket()
        {

        }

        public Basket(string name, string surname, string email, int cellphone, string items)
        {
            Items = items;
        }

        public override HttpPostedFileBase uploadFile()
        {
            return File;
        }
    }
}