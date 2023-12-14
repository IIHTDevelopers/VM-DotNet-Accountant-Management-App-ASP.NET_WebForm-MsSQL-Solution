using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AccountantManagementApp.DAL.Interfaces;
using AccountantManagementApp.Model;

namespace AccountantManagementApp.DAL.Services
{
    public class AccountantService : Interfaces.IAccountantService
    {
        private Interfaces.IAccountantRepository _repository;

        public AccountantService(Interfaces.IAccountantRepository repository)
        {
            _repository = repository;
        }


        public string GetAll()
        {
            return _repository.GetAll();
        }

        public string Add()
        {
            return _repository.Add();
        }

        public string Update()
        {
            return _repository.Update();
        }

        public string Delete()
        {
            return _repository.Delete();
        }

        public AccountantModel GetById(string id)
        {
            return _repository.GetById(id);
        }
    }
}