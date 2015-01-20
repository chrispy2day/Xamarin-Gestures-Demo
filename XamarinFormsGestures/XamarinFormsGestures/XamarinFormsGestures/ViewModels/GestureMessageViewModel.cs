using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace XamarinFormsGestures.ViewModels
{
    [ImplementPropertyChanged]
    public class GestureMessageViewModel
    {
        public string Message { get; set; }
    }
}
