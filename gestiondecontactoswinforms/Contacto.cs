﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestiondecontactoswinforms
{
    public class Contacto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }


        public Contacto()
        {
            id = 0;
            name = string.Empty;
            email = string.Empty;
            phone = string.Empty;
        }

    }


}
