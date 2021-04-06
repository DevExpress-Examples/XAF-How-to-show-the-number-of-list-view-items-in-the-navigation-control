using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace ItemCount.Module.BusinessObjects {
    [DefaultClassOptions]
    public class Email : BaseObject {
        public Email(Session session) : base(session) { }

        string name;
        public string Name {
            get { return name; }
            set { SetPropertyValue(nameof(Name), ref name, value); }
        }
    }
}
