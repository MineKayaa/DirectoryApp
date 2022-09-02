using System;
using System.Collections.Generic;
using System.Text;
using DirectoryApp.DAL.Interface;
using DirectoryApp.DAL.Repositories;
using DirectoryApp.Entity.ModelDb;

namespace DirectoryApp.DAL.Concrete
{
    public class ContactInfoDAL : BaseRepository<ContactInfo>, IContactInfoDAL
    {
        private readonly ModelContext modelContext;

        public ContactInfoDAL(ModelContext context) : base(context)
        {
            this.modelContext = context;
        }

    }
}
