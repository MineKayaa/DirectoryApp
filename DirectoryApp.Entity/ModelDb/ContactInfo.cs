using System;
using System.Collections.Generic;
using System.Text;

namespace DirectoryApp.Entity.ModelDb
{
    public class ContactInfo : BaseEntity, IEntity
    {
        public virtual  InfoType InfoType { get; set; }

        public string InfoContent { get; set; }
    }
}
