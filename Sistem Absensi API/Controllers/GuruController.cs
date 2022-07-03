﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sistem_absensi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuruController : ControllerBase
    {
        private static List<User> guruList = new List<User>() {
            new User("34567" ,"firmanpanji", "lukaku000", "Guru", "Firman Panji Utama"),
            new User("09876" ,"qalbunsaliim", "qwerty123", "Wakil Kepala Sekolah", "Muhammad Qalbun Saliim")
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return guruList;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return guruList[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            if (cekPassword(value.password)) 
            {
                guruList.Add(value);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guruList.RemoveAt(id);
        }

        public static bool cekPassword(string password) 
        {
            if (password.Length <= 8)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
