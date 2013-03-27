using AuthenticationCodeApi.Models;

namespace AuthenticationCodeApi.Controllers
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class AuthenticationObjController : ApiController
    {

        AuthenticationObj[] objs = new AuthenticationObj[] 
        { 
            new AuthenticationObj { Id = "AZ035T29Z1984", Status = "AUTHENTICATED"},
            new AuthenticationObj { Id = "BadId", Status = "DRILL"}
            
        };

        public IEnumerable<AuthenticationObj> GetAllProducts()
        {
            return objs;
        }

        public AuthenticationObj GetObjById(String id)
        {
            var AthenObj = objs.FirstOrDefault((p) => p.Id == id);
            if (AthenObj == null)
            {
                AthenObj = objs.FirstOrDefault((p) => p.Id == "BadId");
            }
            return AthenObj;
        }

        public IEnumerable<AuthenticationObj> GetAthenticationObjByCategory(string code)
        {
            return objs.Where(
                (p) => string.Equals(p.Id, code,
                    StringComparison.OrdinalIgnoreCase));
        }

    }
}
