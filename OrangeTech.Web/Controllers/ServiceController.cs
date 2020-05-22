using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrangeTech.BLL.Interfaces;
using OrangeTech.Models.Models;
using OrangeTech.Web.ViewModels;
using ReflectionIT.Mvc.Paging;

namespace OrangeTech.Web.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService, IMapper mapper)
        {
            _serviceService = serviceService;
            _mapper = mapper;
        }

        [HttpGet("services")]
        public IActionResult GetAll(int page = 1)
        {
            var serviceShortViewModel = _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceShortViewModel>>(_serviceService.GetAll());
            var model = PagingList.Create(serviceShortViewModel, 5, page);
            return View(model);
        }

        [HttpPost("services/add")]
        public IActionResult Create(ServiceViewModel serviceViewModel)
        {
            if (serviceViewModel.Images.Count < 5 && serviceViewModel.Images.Count > 0)
            {
                var service = _mapper.Map<ServiceViewModel, Service>(serviceViewModel);
                _serviceService.Create(service);
                return RedirectToAction("GetAll");
            }

            return View(serviceViewModel);
        }

        [HttpGet("services/add")]
        public IActionResult Create()
        {
            if (User.IsInRole("Admin"))
            {
                return View();
            }

            return RedirectToAction("Login", "Account", "");
        }

        [HttpGet("services/remove")]
        public IActionResult Remove(Guid serviceId)
        {

            if (User.IsInRole("Admin"))
            {
                _serviceService.Delete(serviceId);
                return RedirectToAction("GetAll");
            }

            return RedirectToAction("Login", "Account", "");
        }

        [HttpGet("services/{serviceId}/details")]
        public IActionResult Details(Guid serviceId)
        {
            var service = _serviceService.GetById(serviceId);
            return View(service);
        }
    }
}