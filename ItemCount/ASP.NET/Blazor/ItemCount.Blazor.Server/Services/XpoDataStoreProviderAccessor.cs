using System;
using DevExpress.ExpressApp.Xpo;

namespace ItemCount.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}
