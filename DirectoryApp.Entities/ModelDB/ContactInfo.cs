using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryApp.Entities.ModelDB
{
    public class ContactInfo : BaseEntity
    {
        public virtual InfoType InfoType { get; set; }

        public string InfoContent { get; set; }
    }
}
