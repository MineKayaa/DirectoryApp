using System;
using System.Collections.Generic;
using System.Text;
using DirectoryApp.DAL.Interface;
using DirectoryApp.DAL.Repositories;
using DirectoryApp.Entity.ModelDb;

namespace DirectoryApp.DAL.Concrete
{
    public class InfoTypeDAL : BaseRepository<InfoType>, IInfoTypeDAL
    {

    private readonly ModelContext modelContext;

    public InfoTypeDAL(ModelContext context) : base(context)
    {
        this.modelContext = context;
    }

}
}
