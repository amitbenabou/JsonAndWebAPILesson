using CalculatorWebAPI.DTO;
using CollectionViewLesson.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.Collections.Generic;

namespace CalculatorWebAPI.Controllers
{
    [Route("MonkeyApi")]
    [ApiController]
    public class MonkeysWebAPI : ControllerBase
    {
        [HttpGet("ReadAllMonkeys")]
        public IActionResult ReadMonkeys()
        {
            MonkeyListDto list = new MonkeyListDto
            {
                Monkeys = new List<MonkeyDto>()
            };
            MonkeyList monkeys = new MonkeyList();
            foreach(Monkey m in monkeys.Monkeys)
            {
                list.Monkeys.Add(new MonkeyDto()
                {
                    Name = m.Name,
                    ImageUrl = m.ImageUrl,
                    Location = m.Location,
                    IsFavorite = m.IsFavorite,
                    Details = m.Details
                });
            }
            return Ok(list);
        }
    }
}
