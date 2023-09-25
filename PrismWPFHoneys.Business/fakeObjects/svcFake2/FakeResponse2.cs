using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Business.fakeObjects.svcFake2
{
    public class FakeResponse2 : BusinessBase
    {
        private string _dummyString;
        public string DummyString
        {
            get { return _dummyString; }
            set { SetProperty(ref _dummyString, value); }
        }
    }
}