using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AccountantManagementApp.DAL.Interfaces;

namespace AccountantManagementApp.DAL.Services
{
    public class AccountantRepository : Interfaces.IAccountantRepository
    {
        private AccountantDbContext _context;

        public AccountantRepository(AccountantDbContext context)
        {
            _context = context;
        }

        public Model.AccountantModel GetById(string id)
        {
            return _context.AccountantModels.FirstOrDefault(t => t.Id == int.Parse(id));
        }

        public string GetAll()
        {
            string qry = "select* from AccountantModels";
            return qry;
        }

        public string Add()
        {
            string qry = "insert into AccountantModels(Title, IsCompleted, DueDate)" +
                "values('";
            return qry;
        }

        public string Update()
        {
            var query = "update AccountantModels set Title='";
            return query;
        }

        public string Delete()
        {
            var query = "delete from AccountantModels where Id='";
            return query;
        }
    }
}