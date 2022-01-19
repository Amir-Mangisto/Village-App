using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Village_App.Models;

namespace Village_App.Controllers.api
{
    public class CitizenController : ApiController
    {
        // GET: api/Citizen
        //public IHttpActionResult Get()
        //{
        //    try
        //    {           
        //        return Ok(new { CITIZENS = CitizenModel.Citizens.ToList() });
        //    }
        //    catch (SqlException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception err)
        //    {
        //        return BadRequest(err.Message);
        //    }
        //}

        //// GET: api/Citizen/5
        //public async Task<IHttpActionResult> Get(int id)
        //{
        //    try
        //    {
        //        Citizen citizen=await CitizenModel.Citizens.FindAsync(id);
        //        if (citizen.FirstName != null) return Ok(citizen);
        //        else { return NotFound(); }           
        //    }
        //    catch (SqlException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception err)
        //    {
        //        return BadRequest(err.Message);
        //    }
        //}

        //// POST: api/Citizen
        //public async Task<IHttpActionResult> Post([FromBody] Citizen addCitizen)
        //{
        //    try
        //    {
        //        CitizenModel.Citizens.Add(addCitizen);
        //        await CitizenModel.SaveChangesAsync();   
        //        return Ok("Citizen was added Successfully");
        //    }
        //    catch (SqlException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception err)
        //    {
        //        return BadRequest(err.Message);
        //    }
        //}

        //// PUT: api/Citizen/5
        //public async Task<IHttpActionResult> Put(int id, [FromBody] string value)
        //{
        //    try
        //    {
        //        return Ok();
        //    }
        //    catch (SqlException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception err)
        //    {
        //        return BadRequest(err.Message);
        //    }
        //}

        //// DELETE: api/Citizen/5
        //public async Task<IHttpActionResult> Delete(int id)
        //{
        //    try
        //    {
        //        return Ok();
        //    }
        //    catch (SqlException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //    catch (Exception err)
        //    {
        //        return BadRequest(err.Message);
        //    }
        //}
    }
}
