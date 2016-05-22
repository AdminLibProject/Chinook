using System.Net.Http;
using System.Web.Http;
using AdminLib.Http;
using AdminLib.Debug;
using Auth=AdminLib.App.Auth;
using AdminLib.Model.Interface;

namespace Chinook.app.chinehook.controller {

    [RoutePrefix("api")]
    internal class ApplicationController : BaseController {

        /******************** Structures ********************/
        public class SessionInformations : IQueryResult  {

            public string           id      { get; set; }
            public UserInformations user    { get; set; }

            public Debug            debug   { get; set; }
            public string           message { get; set; }
            
            /******************** Constructors ********************/
            public SessionInformations(Auth.Session session) {

                this.id = session.sessionId;

                if (session.user != null)
                    this.user = new UserInformations(session.user);
                else
                    this.user = null;
            }
        }

        public class UserInformations : IQueryResult {
            public int?   id       { get; set; }
            public string username { get; set; }
            public string email    { get; set; }

            public string message { get; set; }
            public Debug  debug   { get; set; }

            /******************** Constructors ********************/
            public UserInformations(Auth.User user) {
                this.id       = user.id;
                this.username = user.username;
                this.email    = user.email;
            }
        }

        /******************** Methods ********************/
        /// <summary>
        ///     Return informations about the current session
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("session")]
        public HttpResponseMessage GetSession() {

            SessionInformations session;

            session = new SessionInformations(this.session);

            return this.response(session);
        }
    }
}