using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UserService.Controllers
{
    [Authorize] //Attribute for authorization - all the actions need to be authenticated.
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            //Instance of UserDB entities.
            using (UserDBEntities entities = new UserDBEntities())
            {
                //Return List of Users objects.
                return entities.Users.ToList();
            }
        }
    }
}
