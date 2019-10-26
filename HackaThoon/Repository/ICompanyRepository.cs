using HackaThoon.Context;
using HackaThoon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackaThoon.Repository
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetName(string name);
        void Create(Company company);
        bool Commit();
        Company GetById(int Id);
        Overview GetOverViewById(int Id);
        void Del(int Id);
        Company LastManStanding { get; }
        void Repair(Company company);
    }

    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _appDbContext;

        public CompanyRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public Company LastManStanding => throw new NotImplementedException();

        public bool Commit()
        {
            try
            {
                _appDbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Create(Company company)
        {
            _appDbContext.Companies.Add(company);
        }

        public void Del(int Id)
        {
            throw new NotImplementedException();
        }

        public Company GetById(int Id)
        {
            return _appDbContext.Companies.Find(Id);
        }

        public Overview GetOverViewById(int Id)
        {
            return _appDbContext.Overviews.FirstOrDefault(x => x.CompanyId == Id);
        }

        public IEnumerable<Company> GetName(string name)
        {
            if(name == null)
            {
                return _appDbContext.Companies.ToList();
            }
            else
            {
                return _appDbContext.Companies.Where(c => c.Name.Contains(name));
            }
            
        }

        public void Repair(Company company)
        {
            var demo = _appDbContext.Companies.Update(company);
            demo.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }


    }
}
