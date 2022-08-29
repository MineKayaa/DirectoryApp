using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryApp.Entities.ModelDB
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string  CompanyName { get; set; }


     
    }
}
