using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.Domain.CustomerModule;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.CustomerModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
	
	public class CustomersController : BaseDomainController<Customer, Customer>

    {
        public CustomersController(ICustomerDomain domain):base(domain) {}

    }
}
