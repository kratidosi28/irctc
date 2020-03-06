using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.Domain.CardModule;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace MainIRCTC.Api.Controllers.CardModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
	
	public class CardsController : BaseDomainController<Card, Card>

    {
        public CardsController(ICardDomain domain):base(domain) {}

    }
}
