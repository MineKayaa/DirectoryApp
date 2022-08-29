using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryApp.Entity.ModelDb
{
    public class Client :  BaseEntity , IEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string CompanyName { get; set; }

        public virtual ContactInfo ContactInfo { get; set; }
    }
}
