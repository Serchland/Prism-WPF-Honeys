using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWPFHoneys.Modules.Calendar.ViewModels
{
    public class ButtonViewModel : BindableBase
    {
        private string _caption;
        public string Caption
        {
            get { return _caption; }
            set { SetProperty(ref _caption, value); }
        }

        public ButtonViewModel()
        {
            Caption = "Mail Button";
        }
    }
}
