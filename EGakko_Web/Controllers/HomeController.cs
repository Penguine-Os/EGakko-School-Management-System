﻿using EGakko_Models;
using EGakko_Web.Models;
using EGakko_Web.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EGakko_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Fields()
        {
            StudyFieldsViewModel studyFieldsViewModel = new StudyFieldsViewModel();
            studyFieldsViewModel.StudyFields = _unitOfWork.StudyFieldRepo.GetAll().Result;

            studyFieldsViewModel.Fields = _unitOfWork.FieldRepo
                                          .GetAll()
                                          .Result
                                          .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() });

            return View(studyFieldsViewModel);
        }
        public  IActionResult Search(StudyFieldsViewModel studyFieldsViewModel)
        {
            int fieldId = studyFieldsViewModel.FieldId;

            studyFieldsViewModel.Fields = _unitOfWork.FieldRepo
                                                      .GetAll().Result
                                                      .Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString() }); ;


            if (fieldId != 0)
            {
                studyFieldsViewModel.StudyFields = _unitOfWork.StudyFieldRepo
                                                             .GetListByFilter(x => x.FieldId == fieldId)
                                                             .Result;
                if (studyFieldsViewModel.StudyFields.Count() == 0)
                {

                    return BadRequest();
                }
                return View("Fields", studyFieldsViewModel);
            }

            return BadRequest();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
