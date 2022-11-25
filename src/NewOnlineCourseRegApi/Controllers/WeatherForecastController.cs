using MediatR;
using Microsoft.AspNetCore.Mvc;
using NewOnlineCourseReg.Application.Commands;

namespace NewOnlineCourseRegApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       // private readonly CourseRegistrationFormService _service;
        private readonly ISender _sender;

        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ISender sender
        )
        {
            _logger = logger;
            
            _sender= sender;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }


        [HttpPost("addcourse")]
        public async Task<IActionResult> AddNewCourse([FromBody] AddNewCourseCommand request)
        {
            //  var users = await _service.AddNewCourseAsync(request);
           // var model = new AddNewCourseCommand(request);
            var result = await _sender.Send(request);
         return  result.Match< IActionResult >(Left: value=> NotFound("Baddd"),Right: value=> Ok(value));
            //return Ok(result);
        }
    }
}