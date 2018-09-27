using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML;
namespace api.Controllers
{
    [Route("api/[controller]")]
    public class PredictController : Controller
    {
        [HttpPost]
        public string Post([FromBody] QBFantasyGame qBFantasyGame)
        {
            var model = PredictionModel.ReadAsync<QBFantasyGame
                                       , QBFantasyGamePointsPrediction>("model.zip").Result;
            var prediction = model.Predict(qBFantasyGame);
            return prediction.FantPt.ToString();
        }
    }
}
