using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MisClientes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Descripción del proposito el método.
        /// </summary>
        /// <param name="parametro1">El valor del paramatro 1.</param>
        /// <param name="parametro2">El valor del parametro 2.</param>
        /// <returns>Descripción de la salida.</returns>
        /// <remarks>
        /// Petición de ejemplo:
        ///
        ///     Get /ruta/5/10
        ///
        /// </remarks>
        /// <response code="200">Condiciones en las que se regresa.</response>
        /// <response code="400">Condiciones en las que se regresa.</response>

        [HttpGet]
        public IEnumerable<WeatherForecast> Get(int parametro1,int parametro2)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
