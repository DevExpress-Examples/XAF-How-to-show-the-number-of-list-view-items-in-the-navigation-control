using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;

using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Editors;
using System.Diagnostics;
using DevExpress.Persistent.Base.General;
using DevExpress.ExpressApp.SystemModule;

namespace dxTestSolution.Module.BusinessObjects {
     [DefaultClassOptions]
    public class Email : BaseObject { 
        public Email(Session session)
            : base(session) {
        }
      
        string _subject;
        public string Subject {
            get {
                return _subject;
            }
            set {
                SetPropertyValue(nameof(Subject), ref _subject, value);
            }
        }
     
    }
}