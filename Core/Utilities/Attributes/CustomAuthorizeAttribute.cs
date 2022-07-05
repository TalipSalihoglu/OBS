


using Core.Entities.Concrete;
using Core.Enums;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Web.Mvc;

namespace Core.Utilities.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AllowAnonymousAttribute : Attribute
    { }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomAuthorizeAttribute : Attribute, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter
    {
        private readonly IList<Roles> _roles;

        public CustomAuthorizeAttribute(params Roles[] roles)
        {
            _roles = roles ?? new Roles[] { };
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // skip authorization if action is decorated with [AllowAnonymous] attribute
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;

            // authorization
            var user = (User)context.HttpContext.Items["User"];
            var userRole = (Roles)user.RoleId;
            if (user == null || (_roles.Any() && !_roles.Contains(userRole)))
            {
                // not logged in or role not authorized
                throw new InvalidOperationException("Unauthorized - 401");
                //context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
