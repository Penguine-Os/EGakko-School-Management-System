using EGakko_Models;
using EGakko_Web.Models;
using EGakko_Web.Repositories;
using Microsoft.AspNetCore.Identity;
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
        private readonly SignInManager<CustomUser> _signInManager;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork,SignInManager<CustomUser> signInManager)
        {
            _signInManager = signInManager;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("index", "Home");

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
        public async Task<IActionResult> Teachers()
        {

            var task=  _unitOfWork.TeacherRepo.GetAllJoined(x => x.CustomUserTeacher);

            task.Result.ToList().ForEach(x => x.Subjects = _unitOfWork.TeacherRepo.GetTeacherSubjects(x.Id).Result.ToList());
         

            return View(await task);
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
