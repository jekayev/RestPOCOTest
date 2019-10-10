namespace RestPOCOTest.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using RestPOCOTest.Poco;
    using UnitOfWork;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private Dev_CampregistrationContext _devCampregistrationContext;
        private UnitOfWork UnitOfWork;

        public ProductController()
        {
            this._devCampregistrationContext = new Dev_CampregistrationContext();
            this.UnitOfWork = new UnitOfWork(this._devCampregistrationContext);
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            //return new string[] { "value1", "value2" };
            //IQueryable<Camper> camper;
            //camper = this._devCampregistrationContext.Campers;
            //return Ok(camper);
           return Ok(this.UnitOfWork.IProductRepository.GetProduct());
         
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Camper camper)
        {
            _devCampregistrationContext.Campers.Add(camper);
            _devCampregistrationContext.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
