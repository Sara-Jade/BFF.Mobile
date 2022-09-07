using BFF.Mobile.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BFF.Mobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileBFFController : ControllerBase
    {
        // GET: api/<MobileBFFController>
        [HttpGet("GetAllCustomers")]
        public async Task<List<CustomerDTO>> GetAllCustomers()
        {
            return await GetAllCustomersAsync();
        }

        private async Task<List<CustomerDTO>>
        GetAllCustomersAsync()
        {
            string baseURL = "https://localhost:7064/api/";
            string url = baseURL + "Customer/GetAllCustomers";

            using (HttpClient client = new HttpClient())
            {
                List<CustomerDTO> customerDTOs = new List<CustomerDTO>();

                using (HttpResponseMessage responseMessage = await client.GetAsync(url))
                {
                    using (HttpContent content = responseMessage.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        var customers = JsonConvert.DeserializeObject<List<CustomerDTO>>(data);

                        foreach (var customer in customers)
                        {
                            CustomerDTO customerDTO = new CustomerDTO();
                            customerDTO.Id = customer.Id;
                            customerDTO.FirstName = customer.FirstName;
                            customerDTO.LastName = customer.LastName;
                            customerDTO.Phone = null;
                            customerDTO.Address = null;
                            customerDTO.EmailAddress = null;
                            customerDTOs.Add(customerDTO);
                        }

                        return customerDTOs;
                    }
                }
            }
        }

        // GET api/<MobileBFFController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MobileBFFController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MobileBFFController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MobileBFFController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
