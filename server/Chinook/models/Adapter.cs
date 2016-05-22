using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdminLibStore = AdminLib.Data.Store;

namespace Chinook.models {
    public class Adapter {

        public void Initialize() {

            AdminLibStore.Adapter.Declare<OracleAdapter>();

        }

    }
}