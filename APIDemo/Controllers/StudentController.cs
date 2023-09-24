using Microsoft.AspNetCore.Mvc;
using System.Data;
//using System.Data.sql;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students =new List<Student>();
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {   
            return students.FirstOrDefault(s=>s.ID==id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            students.Add(value);
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            int i= students.FindIndex(s => s.ID == id);    
            if(i>=0)
                students[i]=value;
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            students.RemoveAll(s=>s.ID==id);
        }

       
    }
}
