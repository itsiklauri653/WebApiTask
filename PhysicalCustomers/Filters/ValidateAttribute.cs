using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace PhysicalCustomers.Web.Filters
{
    public class ValidateAttribute : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {

            }

            await next();
        }
    }
}
