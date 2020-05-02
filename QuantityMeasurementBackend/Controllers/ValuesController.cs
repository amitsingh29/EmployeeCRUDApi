using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;
using Manager;
using Microsoft.AspNetCore.Mvc;
using Model;
using QuantityMeasurementBacken;

namespace QuantityMeasurementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        MSMQ messagingQueue = new MSMQ();
        public IManager manager;

        public ValuesController(IManager manager)
        {
            this.manager = manager;
        }

        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeettoInch(QuantityModel value)
        {
            var result = this.manager.FeetToInch(value);

            if (result >= 0)
            {
                messagingQueue.sendMessage("Feet", result);
                return this.Ok(result);
                

            }
            return this.BadRequest();
        }


        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(QuantityModel value)
        {
            var result = this.manager.InchToFeet(value);

            if (result >= 0)
            {
                messagingQueue.sendMessage("Inch= ", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("MeterToCentimeter")]
        [HttpPost]
        public IActionResult MetertoCentimeter(QuantityModel value)
        {
            var result = this.manager.MeterToCentimeter(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("CentimeterToMeter")]
        [HttpPost]
        public IActionResult CentimetertoMeter(QuantityModel value)
        {
            var result = this.manager.CentimeterToMeter(value);

            if (result >= 0)
            {
                messagingQueue.sendMessage("Centimeter= ", result);
                return this.Ok(result);
                

            }
            return this.BadRequest();
        }

        [Route("KilogramToGram")]
        [HttpPost]
        public IActionResult KgtoGm(QuantityModel value)
        {
            var result = this.manager.KilogramToGram(value);

            if (result >= 0)
            {
                messagingQueue.sendMessage("Kg= ", result);
                return this.Ok(result);
               

            }
            return this.BadRequest();
        }

        [Route("GramToKilogram")]
        [HttpPost]
        public IActionResult GmtoKg(QuantityModel value)
        {
            var result = this.manager.GramToKilogram(value);

            if (result >= 0)
            {
                messagingQueue.sendMessage("Gram= ", result);
                return this.Ok(result);
               

            }
            return this.BadRequest();
        }
    }
}
