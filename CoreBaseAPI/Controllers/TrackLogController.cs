using CoreBaseLib.Models;
using CoreBaseLib.Sample;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreBase.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TrackLogController : ControllerBase
    {
        private readonly ITrackLog _TrackLog;
        public TrackLogController(ITrackLog TrackLog)
        {
            _TrackLog = TrackLog;
        }

        [HttpPost]
        public ActionResult<string> AddtoCart([FromBody] AddtoCartlgModel data)
        {
            var result = _TrackLog.AddtoCartlgAddData(data);

            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> AddPaymentInfo([FromBody] AddPaymentInfolgModel data)
        {
            var result = _TrackLog.AddPaymentInfolgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> AddToWishlist([FromBody] AddToWishlistlgModel data)
        {
            var result = _TrackLog.AddToWishlistlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> CompleteRegistration([FromBody] CompleteRegistrationlgModel data)
        {
            var result = _TrackLog.CompleteRegistrationlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> InitiateCheckout([FromBody] InitiateCheckoutlgModel data)
        {
            var result = _TrackLog.InitiateCheckoutlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> PageView([FromBody] PageViewlgModel data)
        {
            var result = _TrackLog.PageViewlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> Purchase([FromBody] PurchaselgModel data)
        {
            var result = _TrackLog.PurchaselgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> Search([FromBody] SearchlgModel data)
        {
            var result = _TrackLog.SearchlgAddData(data);
            return new JsonResult(result);
        }

        [HttpPost]
        public ActionResult<string> Subscribe([FromBody] SubscribelgModel data)
        {
            var result = _TrackLog.SubscribelgAddData(data);
            return new JsonResult(result);
        }


    }
}
