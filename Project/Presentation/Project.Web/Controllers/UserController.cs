using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Project.Core.Domain.Users;
using Project.Services.Notifications;
using Project.Services.Roles;
using Project.Services.Users;
using Project.Web.Infrastructure.Mapper.Extensions;
using Project.Web.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace Project.Web.Controllers
{
    public class UserController : Controller
    {
        #region Fields

        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly INotificationService _notificationService;

        #endregion

        #region Constructor

        public UserController(IRoleService roleService, INotificationService notificationService,
            IUserService userService)
        {
            _roleService = roleService;
            _userService = userService;
            _notificationService = notificationService;
        }

        #endregion

        #region Methods

        public IActionResult Login(string returnUrl)
        {
            LoginModel loginModel = new LoginModel();
            loginModel.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Index()
        {
            return RedirectToAction("List");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var users = await _userService.GetUsersAsync();

            var list = users.Select(user => user.ToModel<UserModel>());

            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            UserModel model = new UserModel();
            model.AvailableRoles = await _roleService.GetRoleSelectList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserModel model)
        {
            var userRole = await _roleService.GetRoleAsync(model.SelectedRole);
            if (userRole == null)
            {
                ModelState.AddModelError("SelectedRole", "Selected role is not valid");
            }
            model.AvailableRoles = await _roleService.GetRoleSelectList();
            if (ModelState.IsValid)
            {
                var user = model.ToEntity<User>();
                UserRoleMapping roleMapping = new UserRoleMapping();
                var a = await _userService.InsertUsesAsync(user);
                roleMapping.IsActive = true;
                roleMapping.CreatedOn = DateTime.UtcNow;
                roleMapping.UserId = a;
                roleMapping.RoleId = model.SelectedRole;
                var b = await _userService.InsertUserRoleMappingAsync(roleMapping);
                UserEmailNotification userEmail = new UserEmailNotification();
                userEmail.CallBackUrl = "";
                userEmail.Password = user.Password;
                userEmail.UserEmail = "shubhampathade2001@gmail.com";
                userEmail.UserName = "Hrushi";
                //bool t = await _notificationService.USerRegistrationNotification(userEmail, "User.Registration.Notification");
                return RedirectToAction("List");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var entity = await _userService.GetUserAsync(id);
            var data = entity.ToModel<UserModel>();
            if (entity == null)
            {
                return RedirectToAction("List");
            }

            UserModel model = new UserModel()
            {
                Id = data.Id,
                Email = data.Email,
                MobileNo = data.MobileNo,
                Password = data.Password,
                UserName = data.UserName,
            };

            UserRoleMapping userRole = await _userService.GetUserAsyncByID(id);
            model.SelectedRole = userRole.RoleId;
            model.AvailableRoles = await _roleService.GetRoleSelectList();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var entity = await _userService.GetUserAsync(model.Id);
                if (entity == null)
                {
                    return RedirectToAction("List");
                }

                entity.Email = model.Email;
                entity.MobileNo = model.MobileNo;
                entity.Password = model.Password;
                entity.UserName = model.UserName;

                await _userService.UpdateUserAsync(entity);
                UserRoleMapping userRole = await _userService.GetUserAsyncByID(model.Id);
                userRole.RoleId = model.SelectedRole;
                userRole.ModifiedOn = DateTime.UtcNow;
                await _userService.UpdateUserRoleMappingAsync(userRole);
                return RedirectToAction("List");
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateUserDeviceToken(string token)
        {
            long userId = 1;
            var data = await _userService.GetUserAsync(userId);
            if (data == null)
            {
                return Json(new { success = false, message = "User does not exist" });
            }
            else
            {
                data.DeviceToken = token;
                await _userService.UpdateUserAsync(data);
                return Json(new { success = true, message = "User token updated successfully" });
            }
        }

        public async Task<ActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "User");
        }

        #endregion
    }
}
