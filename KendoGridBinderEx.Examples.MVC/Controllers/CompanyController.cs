﻿using System.Web.Mvc;
using KendoGridBinder.Examples.MVC.Data.Entities;
using KendoGridBinder.Examples.MVC.Data.Service;

namespace KendoGridBinder.Examples.MVC.Controllers
{
    public class CompanyController : BaseGridController<Company, Company>
    {
        private readonly CompanyService _companyService;

        public CompanyController()
            : base(CompositionRoot.ResolveService<CompanyService>())
        {
            _companyService = (CompanyService)Service;
        }

        [HttpGet]
        public JsonResult GetJson()
        {
            var entities = _companyService.GetAll();

            return Json(entities, JsonRequestBehavior.AllowGet);
        }
    }
}