// using Assesment;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Assessment.Dtos;
namespace Assessment.Controllers
{
    [ApiController]
    [Route("Acc")]
    public class AccsController : ControllerBase
    {
        private static readonly List<AccDto> Acc = new()
        {
            new AccDto(Guid.NewGuid(),"19950828","saving","Capitec","open",300,DateTimeOffset.UtcNow),
            new AccDto(Guid.NewGuid(),"19960829","fixed","NedBank","open",4000,DateTimeOffset.UtcNow),
            new AccDto(Guid.NewGuid(),"19970830","pending","Standard","open",10,DateTimeOffset.UtcNow)
        };

        // Operation in thr Rest Api

        // Get /Acc
        [HttpGet]
        public IEnumerable<AccDto> Get()
        {
            return Acc;
        }

        // Get /Acc/{id}
        [HttpGet("{id}")]
        public ActionResult<AccDto> GetById(Guid id)
        {
            var ac = Acc.Where(ac => ac.Id == id).SingleOrDefault();

            if(ac == null)
            {
                return NotFound();
            }
            return ac;
        }

        // for creating a new account,withdrawal
        [HttpPost]
        public ActionResult<AccDto> Post(CreateAccDto createAccDto)
        {
            var ac = new AccDto(Guid.NewGuid(), createAccDto.accName, createAccDto.accType, createAccDto.name, createAccDto.status, createAccDto.accBalance, DateTimeOffset.UtcNow);
            if(createAccDto.accBalance >= ac.accBalance && createAccDto.accType != "inactive")
            {
                return NoContent();
            }
            // if(createAccDto.accType == "Fixed Account" && createAccDto.accBalance == )
            Acc.Add(ac);
            return CreatedAtAction(nameof(GetById), new { id = ac.Id, ac });
        }

        // // This is a method to update AccInformation/withdrawal
        // // route /Acc/{id}
        // [HttpPut("{id}")]
        // public IActionResult Put(Guid id, UpdateAccDto updateAccDto)
        // {
        //     // Finding the Account in which updates are going to be made 
        //     var existingAcc = Acc.Where(ac => ac.Id == id).SingleOrDefault();

        //     var updatedAcc = existingAcc with
        //     {
        //         accName = updateAccDto.accName,
        //         accBalance = updateAccDto.accBalance,
        //         accType = updateAccDto.accType,
        //         name = updateAccDto.name,
        //         status = updateAccDto.status

        //     };

        //     var index = Acc.FindIndex(exists => exists.Id == id);
        //     Acc[index] = updatedAcc;

        //     return NoContent();
        // }
    }
}