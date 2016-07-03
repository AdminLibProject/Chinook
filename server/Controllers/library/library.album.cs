using System.Net.Http;
using System.Web.Http;
using AdminLib.Http;

namespace Chinook.api.library {

    using Model = Chinook.models.library.Album;

    [RoutePrefix("api/library/album")]
    public class AlbumController : ModelController<Model> {

        // GET: api/library/album
        [Route("")]
        [HttpGet]
        public override HttpResponseMessage GetItems() {
            return base.GetItems();
        }

        // GET: api/library/album/{id}
        [Route("{id:int}")]
        [HttpGet]
        public override HttpResponseMessage GetItem(int id) {
            return base.GetItem(id : id);
        }

        // PATCH: api/library/album/{id}
        [HttpPatch]
        [Route("{id:int}")]
        public override HttpResponseMessage Update(int id, [FromBody] Model item) {
            return base.Update ( id   : id
                               , item : item);
        }

        // DELETE: api/library/album/{id}
        [Route("{id:int}")]
        [HttpDelete]
        public override HttpResponseMessage Delete(int id) {
            return base.Delete(id : id);
        }
    }
}