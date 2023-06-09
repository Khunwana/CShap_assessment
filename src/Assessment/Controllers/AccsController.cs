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
        public AccDto GetById(Guid id)
        {
            var ac = Acc.Where(ac => ac.Id == id).SingleOrDefault();
            return ac;
        }


    }
}