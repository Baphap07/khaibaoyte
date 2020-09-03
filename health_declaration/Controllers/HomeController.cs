using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using health_declaration.Models;
using health_declaration.ViewModels;

namespace health_declaration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IGateRepository gateRepository { get; }
        public IProvinceRepository provinceRepository { get; }
        public IDistrictRepository districtRepository { get; }
        public IWardRepository wardRepository { get; }
        public IMedical_Declaration medicalRepository { get; }
        public ISymptomRepository symptomRepository { get; }

        public HomeController(ILogger<HomeController> logger,
            IGateRepository gateRepository,
            IProvinceRepository provinceRepository,
            IDistrictRepository districtRepository,
            IWardRepository wardRepository,
            IMedical_Declaration medicalRepository,
            ISymptomRepository symptomRepository
            )
        {
            _logger = logger;
            this.gateRepository = gateRepository;
            this.provinceRepository = provinceRepository;
            this.districtRepository = districtRepository;
            this.wardRepository = wardRepository;
            this.medicalRepository = medicalRepository;
            this.symptomRepository = symptomRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var wards = wardRepository.Gets().ToList();
            ViewBag.wards = wards;
            var districts = districtRepository.Gets().ToList();
            ViewBag.districts = districts;
            var provinces = provinceRepository.Gets().ToList();
            ViewBag.provinces = provinces;
            var gates = gateRepository.Gets().ToList();
            ViewBag.gates = gates;

            return View();
        }
        [Route("/Home/GetsDistrictByProvinceId/{id}")]
        public JsonResult GetsDistrictByProvinceId(int id)
        {
            List<District> districts = districtRepository.GetsByProvinceId(id).ToList();
            return Json(new { districts});
        }
        [HttpPost]
        [Route("/Home/GetsWardByProvinceId")]
        public JsonResult GetsWardByDistrictId([FromBody] RequestsWard requestsWard)
        {
            List<Ward> wards = wardRepository.GetsByDistrictId(requestsWard).ToList();
            return Json(new { wards });
        }
       

        [HttpPost]
        [Route("/Home/Index")]
        public IActionResult Index(HomeCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var symptom = new Symptom()
                {
                    Fever = model.Sot,
                    Sob = model.Sob,
                    Nausea = model.Nausea,
                    Sorethroat = model.Sorethroat,
                    Skinrash = model.Skinrash,
                    Bots = model.Bots,
                    Cough = model.Cough,
                    Diarhea = model.Diarhea
                };
                int symptomId = symptomRepository.Create(symptom);
                var dedical = new Medical_Declaration()
                {
                    UserName = model.UserName,
                    GateId = model.GateId,
                    Dob = model.Dob,
                    Gender = model.Gender,
                    Phone = model.Phone,
                    Email = model.Email,
                    Address = model.Address,
                    SymptonId=symptomId,
                    PassportNumber = model.PassportNumber,
                    ProvinceId = model.ProvinceId,
                    DistrictId = model.DistrictId,
                    WardId = model.WardId,
                    Description = model.Description,
                    Departure_day = model.Departure_day,
                    Entry_date = model.Entry_date,
                    start_place=model.Start_Place,
                    destination=model.Destination,
                    Contact_Oj=model.Contact_Oj,
                    Contact_Pp=model.Contact_Pp,
                    vacxin=model.Vacxin
                    
                };
                var newmedical = medicalRepository.Create(dedical);
                return RedirectToAction("Privacy", "Home");
                ;
            }
            var wards = wardRepository.Gets().ToList();
            ViewBag.wards = wards;
            var districts = districtRepository.Gets().ToList();
            ViewBag.districts = districts;
            var provinces = provinceRepository.Gets().ToList();
            ViewBag.provinces = provinces;
            var gates = gateRepository.Gets().ToList();
            ViewBag.gates = gates;
            return View(model);


        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
