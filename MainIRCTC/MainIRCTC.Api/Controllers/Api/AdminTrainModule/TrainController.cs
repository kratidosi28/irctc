using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MainIRCTC.UnitOfWork.Main;
using MainIRCTC.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace MainIRCTC.Api.Controllers.AdminTrainModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class TrainController : BaseController<Train,Train,Train>

    {
        public TrainController(IAdminTrainUow uow):base(uow) {}

    }
}
