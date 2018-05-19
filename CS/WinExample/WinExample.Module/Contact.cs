using DevExpress.Xpo;

using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinExample.Module {
    [DefaultClassOptions]
    public class Contact : Person {
        public Contact(Session session) : base(session) { }
    }

}
