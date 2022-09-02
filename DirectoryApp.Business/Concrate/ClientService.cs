using System;
using System.Collections.Generic;
using System.Text;
using DirectoryApp.DAL;
using DirectoryApp.DAL.Interface;
using DirectoryApp.Entity.ModelDb;

namespace DirectoryApp.Business.Concrate
{
    public class ClientService : IClientService
    {
        private readonly IClientDAL _clientDal;
        private readonly ModelContext _dbContext;
        public ClientService(IClientDAL clientDal, ModelContext dbContext)
        {
            this._clientDal = clientDal;
            this._dbContext = dbContext;
        }

        public void Add(Client client)
        {
            _clientDal.Add(client);
        }

        public Client Get()
        {
            return _clientDal.Get();
        }
        public void Delete(Client client)
        {
            _clientDal.Delete(client);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientDal.GetList();
        }

        public Client GetById(int id)
        {
            return _clientDal.GetById(id);
        }

        public void Update(Client client)
        {
            _clientDal.Update(client);
        }
    }
}
