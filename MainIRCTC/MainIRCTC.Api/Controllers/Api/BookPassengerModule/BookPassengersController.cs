using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.Domain.BookPassengerModule;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.BookPassengerModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class BookPassengersController : BaseDomainController<Passenger, Passenger>

    {
        public BookPassengersController(IBookPassengerDomain domain):base(domain) {}

    }
}
