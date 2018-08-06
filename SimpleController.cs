using System;
using System.Collections.Generic;
using System.Web.Http;

namespace SimpleWebApp
{
	public class SimpleController : ApiController
	{
		// GET api/values 
		public IEnumerable<string> Get()
		{
			return new string[] { DateTime.Now.ToString(), "foo", "bar" };
		}

		// GET api/values/5 
		public string Get(int id)
		{
			return $"foobar_{id}";
		}

		// POST api/values 
		public void Post([FromBody]string value)
		{
			throw new NotImplementedException("POST NOT IMPLEMENTED");
		}

		// PUT api/values/5 
		public void Put(int id, [FromBody]string value)
		{
			throw new NotImplementedException("PUT NOT IMPLEMENTED");
		}

		// DELETE api/values/5 
		public void Delete(int id)
		{
			throw new NotImplementedException("DELETE NOT IMPLEMENTED");
		}
	}
}
