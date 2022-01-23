using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiect.Utilities
{
    public class AuthorizationAttribute : Attribute, IAuthorizationFilter
    {
        private readonly ICollection<Role> _roles;

        public AuthorizationAttribute(params Role[] roles)
        {
            _roles = roles;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var unauthorizeStatusCodeObject = new JsonResult(new { Message = "Undauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };

            if (_roles == null)
            {
                context.Result = unauthorizeStatusCodeObject;
            }

            var user = (User)context.HttpContext.Items["User"];

            if (user == null|| !_roles.Contains(user.Role))
            {
                context.Result = unauthorizeStatusCodeObject;
            }
        }
        
    }
}
