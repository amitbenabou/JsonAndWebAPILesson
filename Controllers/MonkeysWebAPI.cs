using CalculatorWebAPI.DTO;
using CollectionViewLesson.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.Collections.Generic;

namespace CalculatorWebAPI.Controllers
{
    [Route("MonkeyAPI")]
    [ApiController]
    public class MonkeysWebAPI : ControllerBase
    {
        [HttpGet("GetAllMonkeys")]
        public IActionResult GetAllMonbkeys()
        {
            MonkeyListDto list = new MonkeyListDto();
            //list.Monkeys = new List<MonkeyDto>();

            //MonkeyList monkeys = new MonkeyList();

            //foreach (Monkey m in monkeys.Monkeys)
            //{
            //    list.Monkeys.Add(new MonkeyDto()
            //    {
            //        Name = m.Name,
            //        ImageUrl = m.ImageUrl,
            //        Location = m.Location,
            //        Details = m.Details
            //    });
            //}
            return Ok(list);
        }
        [HttpGet("ReadMonkeys")]
        public IActionResult ReadMonkey([FromQuery] string str)
        {
            MonkeyDto monkey = new MonkeyDto();
            MonkeyList monkeys = new MonkeyList();
            foreach (Monkey m in monkeys.Monkeys)
            {
                if (m.Name == str)
                {
                    monkey.Name = m.Name;
                    monkey.ImageUrl = m.ImageUrl;
                    monkey.Location = m.Location;
                    monkey.Details = m.Details;
                    return Ok(monkey);
                }
            }
            return NotFound();
        }
    }

}
