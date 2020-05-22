using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OrangeTech.BLL.Interfaces;
using OrangeTech.Models.Models;
using OrangeTech.Web.ViewModels;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;

namespace OrangeTech.Web.Controllers
{
    public class WorkController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IWorkService _workService;

        public WorkController(IWorkService workService, IMapper mapper)
        {
            _workService = workService;
            _mapper = mapper;
        }

        [HttpGet("works")]
        public IActionResult GetAll(int page = 1)
        {
            var worksViewModels = _mapper.Map<IEnumerable<Work>, IEnumerable<WorkShortViewModel>>(_workService.GetAll());
            var model = PagingList.Create(worksViewModels, 5, page);
            return View(model);            
        }

        [HttpPost("works/add")]
        public IActionResult Create(WorkViewModel workViewModel)
        {
            if (workViewModel.Images.Count < 5 && workViewModel.Images.Count > 0)
            {
                var work = _mapper.Map<WorkViewModel, Work>(workViewModel);
                _workService.Create(work);
                return RedirectToAction("GetAll");
            }

            return View(workViewModel);
        }

        [HttpGet("works/add")]
        public IActionResult Create()
        {
            if (User.IsInRole("Admin"))
            {
                return View();
            }

            return RedirectToAction("Login", "Account", "");
        }

        [HttpGet("works/remove")]
        public IActionResult Remove(Guid workId)
        {

            if (User.IsInRole("Admin"))
            {
                _workService.Delete(workId);
                return RedirectToAction("GetAll");
            }

            return RedirectToAction("Login", "Account", "");
        }

        [HttpGet("works/{workId}/details")]
        public IActionResult Details(Guid workId)
        {
            var work = _workService.GetById(workId);
            return View(work);
        }
    }
}