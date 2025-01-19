
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BarberShopV2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        protected bool IsValidOperation()
        {
            return true;
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (IsValidOperation())
            {
                return new ObjectResult(result);
            }

            return BadRequest(new { 
                
                //result 
            
            });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if(!modelState.IsValid)
            { 
            }

            return CustomResponse();
        }

        protected void ErrorNotification(string message)
        {

        }
    }
}
