using System;
using System.Collections.Generic;
using health_declaration.Models;
using Microsoft.AspNetCore.Mvc;

namespace health_declaration.Controllers
{
    public class ManagerController:Controller
    {
        private readonly IMedical_Declaration medical_Declaration;

        public ManagerController(IMedical_Declaration medical_Declaration)
        {
            this.medical_Declaration = medical_Declaration;
        }
        public IActionResult Index()
        {
            IEnumerable<Medical_Declaration> medical = medical_Declaration.Gets();
            return View(medical);
        }
    }
}
