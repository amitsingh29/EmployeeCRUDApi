using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace QuantityMeasurementBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public IManager manager;

        public ValuesController(IManager manager)
        {
            this.manager = manager;
        }

        [Route("FeettoInch")]
        [HttpPost]
        public IActionResult FeettoInch(QuantityModel value)
        {
            var result = this.manager.FeetToInch(value);

            if (result >= 0)
            {
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
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("MetertoCentimeter")]
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

        [Route("CentimetertoMeter")]
        [HttpPost]
        public IActionResult CentimetertoMeter(QuantityModel value)
        {
            var result = this.manager.CentimeterToMeter(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("KgtoGm")]
        [HttpPost]
        public IActionResult KgtoGm(QuantityModel value)
        {
            var result = this.manager.KilogramToGram(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("GmtoKg")]
        [HttpPost]
        public IActionResult GmtoKg(QuantityModel value)
        {
            var result = this.manager.GramToKilogram(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}
