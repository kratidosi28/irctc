using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.Domain.PNRModule;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.PNRModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
	
	public class pnrsController : BaseDomainController<vPNR,vPNR>

    {
        public pnrsController(IpnrDomain domain):base(domain) {}

    }
}
