using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackaThoon.Models;
using HackaThoon.Repository;
using HackaThoon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HackaThoon.Controllers
{
    public class CompaniesController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompaniesController(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }
        public IActionResult Index(string SearchKeyword)
        {
            CompanyListViewModel companyListViewModel = new CompanyListViewModel();
            if (SearchKeyword == null)
            {
                companyListViewModel.Companies = _companyRepository.GetName(null);
            }
            else
            {
                companyListViewModel.Companies = _companyRepository.GetName(SearchKeyword);
            }
            
            return View(companyListViewModel);
        }

        public IActionResult Create()
        {
            CompanyListViewModel companyListViewModel = new CompanyListViewModel();
            
            return View(companyListViewModel);
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }

            _companyRepository.Create(company);
            _companyRepository.Commit();    
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int Id)
        {
            CompanyListViewModel companyListViewModel = new CompanyListViewModel();
            companyListViewModel.Company = _companyRepository.GetById(Id);
            companyListViewModel.Overview = _companyRepository.GetOverViewById(Id);
            return View(companyListViewModel);
        }

        public IActionResult Edit(int Id)
        {
            CompanyListViewModel companyListViewModel = new CompanyListViewModel();
            companyListViewModel.Company = _companyRepository.GetById(Id);
            if(companyListViewModel.Company == null)
            {
                return NotFound();
            }
            companyListViewModel.Overview = _companyRepository.GetOverViewById(Id);
            return View(companyListViewModel);
        }

        [HttpPost]
        public IActionResult Edit(Company company)
        {
            if (!ModelState.IsValid)
            {
                return View(company);
            }

            _companyRepository.Repair(company);
            var result = _companyRepository.Commit();
            if (result)
            {
                TempData["Message"] = "Edit successful";
            }
            else
            {
                TempData["Message"] = "Edit fail";
                
            }
            return RedirectToAction("Index");
        }
    }
}