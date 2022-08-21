using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21498629_HW04.Models
{
    public class Item: Basket
    {
        public Item()
        {

        }

        public Item(string name, string surname, string email, int cellphone, string items)
        {

        }

        public override HttpPostedFileBase uploadFile()
        {
            return File;
        }
    }
}