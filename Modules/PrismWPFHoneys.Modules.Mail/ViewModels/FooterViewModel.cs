using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Modules.Mail.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        private string _caption;
        public string Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        public FooterViewModel()
        {
            Caption = "Mail footer";
        }
    }
}
