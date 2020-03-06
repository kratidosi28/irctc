using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.Domain.TrainModule;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.TrainModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
	
	public class TrainBookingsController : BaseDomainController<BookTrainResult, BookTrainResult>

    {
        public TrainBookingsController(ITrainBookingDomain domain):base(domain) {}

    }
}
