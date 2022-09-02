using System;
using System.Collections.Generic;
using System.Text;
using DirectoryApp.Entity.ModelDb;

namespace DirectoryApp.Business.Concrate
{
    public interface IClientService
    {
        void Add(Client favoriItem);
        void Delete(Client favoriItem);

        Client GetById(int id);

        Client Get();
        IEnumerable<Client> GetAll();

        void Update(Client favoriItem);
    }
}
