using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.Domain.CustomerLoginModule;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.CustomerLoginModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class CustomerLoginController : BaseDomainController<Customer,Customer>

    {
        public CustomerLoginController(ICustomerLoginDomain domain):base(domain) {}

    }
}
