using Microsoft.AspNetCore.Mvc;
using Demo_API.Context;
using Demo_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo_API.Context
{
    [Route("api/[controller]")]
    [ApiController]
    public class HocSinhController : ControllerBase
    {
        private AppDbContext context;
        public HocSinhController()
        {
            context = new AppDbContext();
        }
        // GET: api/<HocSinhController>
        [HttpGet]
        public ActionResult Get()
        {
            var lstHocSinh = context.HocSinhs.ToList();
            return Ok(lstHocSinh);
        }

        // GET api/<HocSinhController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var hocSinh = context.HocSinhs.Find(id);
            if (hocSinh == null)
            return NotFound($"ko tim thay hoc sinh cos id la {id}");
            return Ok(hocSinh);
        }

        // POST api/<HocSinhController>
        [HttpPost]
        public ActionResult Post([FromBody] HocSinh hocSinh)
        {
            context.HocSinhs.Add(hocSinh);
            context.SaveChanges();
            return CreatedAtAction("Post", hocSinh);
        }

        // PUT api/<HocSinhController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] HocSinh hocSinh)
        {
            var hocSinhHientai=context.HocSinhs.Find(id);
            if (hocSinhHientai == null)
                return NotFound($"ko tim thay hoc sinh cos id la {id}");
            hocSinhHientai.HoTen=hocSinh.HoTen;
            hocSinhHientai.Email = hocSinh.Email;
            hocSinhHientai.SDT = hocSinh.SDT;
            hocSinhHientai.NgaySinh = hocSinh.NgaySinh;
            hocSinhHientai.LopId = hocSinh.LopId;
            context.HocSinhs.Update(hocSinhHientai);
            context.SaveChanges();
            return Ok("Thanh cong");

        }

        // DELETE api/<HocSinhController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var hocSinhHientai = context.HocSinhs.Find(id);
            if (hocSinhHientai == null)
                return NotFound($"ko tim thay hoc sinh cos id la {id}");
            context.HocSinhs.Update(hocSinhHientai);
            context.SaveChanges();
            return Ok("Thanh cong");
        }
    }
}
