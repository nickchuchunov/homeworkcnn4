using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        // Возможность сохранить температуру в указанное время  POST



        (DateTime timespin, int? Temperature) ValuesHolder; // кортеж 


        [HttpPost("SevTemperature")]
       public (DateTime timespin, int? Temperature) controlletSevTemperature (DateTime time, int holder )
        {

            while  (DateTime.Now==time) {  (DateTime timespin, int Temperature)  ValuesHolder = (time, holder); return ValuesHolder; }

            return ValuesHolder;

        }











        // Возможность отредактировать показатель температуры в указанное время  PATCH

        [HttpPost("SevTemperature")]
        public (DateTime timespin, int? Temperature) controlletEditingTemperature(DateTime time, int holder) { while (time == ValuesHolder.timespin) { ValuesHolder.Temperature = holder;  return ValuesHolder; } return ValuesHolder; }








        //возможность удалить показатель температуры в указанный промежуток времени PATCH

       


        [HttpPatch("DeleteTemperature")]
        public (DateTime timespin, int? Temperature) controlletDeleteTemperature(DateTime time, int holder) { while (time == ValuesHolder.timespin) { int? _null =null ; ValuesHolder.Temperature = _null; }; return ValuesHolder; }


        //Возможность прочитать список показателей температуры за указанный промежуток времени  GET


        [HttpGet("RedTemperature")]
        public (DateTime timespin, int? Temperature) controlletRedeTemperature(DateTime time) { while (time == ValuesHolder.timespin) { return ValuesHolder; } return ValuesHolder; }




        




















    }
}
