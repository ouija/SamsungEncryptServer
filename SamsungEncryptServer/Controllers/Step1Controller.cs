using SamsungEncryptServer.Encryption;
using SamsungEncryptServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SamsungEncryptServer.Controllers
{
    public class Step1Controller : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetStep1(Step1Request request)
        {
            if(ModelState.IsValid)
            {
                SpcApiWrapper w = new SpcApiWrapper();
                w.Initialize(request.deviceId);
                String code = w.GenerateServerHello(request.pin);
                return Request.CreateResponse(HttpStatusCode.OK, new { code = code});
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { error = "Invalid Input" });
            }

        }
    }
}
