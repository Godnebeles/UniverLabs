using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WpfProgressBarTest.ViewModels.Base;

namespace WpfProgressBarTest.Data
{
    [DataContract]
    public class ProgressData : ViewModel
    {
        [DataMember]
        private int _value = 50;

        [DataMember]
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
            }
        }
    }
}
