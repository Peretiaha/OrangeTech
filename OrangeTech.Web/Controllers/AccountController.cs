using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using OrangeTech.BLL.Interfaces;
using OrangeTech.Models.Models;
using OrangeTech.Web.ViewModels;

namespace OrangeTech.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public AccountController(IUserService userService, IRoleService roleService, IMapper mapper)
        {
            _userService = userService;
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        [HttpGet("account/login")]
        public IActionResult LoginAsync()
        {
            return View();
        }

        [HttpPost("account/login")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginAsync(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var IsExist = _userService.Login(_mapper.Map<LoginViewModel, User>(loginViewModel));
                if (IsExist)
                {
                    var user = _userService.GetUserByEmail(loginViewModel.Email);
                    var claims = GenerateClaimsForUser(user);
                    var principal = CreatePrincipal(claims);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(nameof(loginViewModel.Password), "Invalid login or password");
            return View(loginViewModel);
        }

        [HttpGet("account/registration")]
        public IActionResult Registration()
        {
            var registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registration(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<RegisterViewModel, User>(registerViewModel);
                user.RoleId = _roleService.GetByName("Guest").RoleId;
                _userService.Create(user);
                return RedirectToAction("LoginAsync");
            }

            return View(registerViewModel);
        }

        private ClaimsPrincipal CreatePrincipal(IEnumerable<Claim> claims) =>
            new ClaimsPrincipal(new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));

        private IEnumerable<Claim> GenerateClaimsForUser(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email)
            };

            claims.AddRange(new List<Claim> {
                new Claim(ClaimTypes.Role, user.Role.Name)
            });

            return claims;
        }
    }
}