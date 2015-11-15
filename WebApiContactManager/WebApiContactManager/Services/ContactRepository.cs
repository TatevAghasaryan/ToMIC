using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiContactManager.Models;

namespace WebApiContactManager.Services
{
    public class ContactRepository
    {
        public Contact[] GetAllContact()
        {
            return new Contact[] 
            {
                new Contact
                {
                    Id = 1,
                    Name = "Tatev"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Arev"
                }
            };
        }

    }
}