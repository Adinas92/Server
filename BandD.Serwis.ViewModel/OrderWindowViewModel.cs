using BandD.Serwis.Model;
using BandD.Serwis.ViewModel.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandD.Serwis.ViewModel
{
    public class OrderWindowViewModel : BaseViewClass
    {
        public MailModel mailModel;
        
            public MailModel mailmodel
        {
            get { return mailModel; }
            set { mailModel = value; OnPropertyChanged(); }


        }
    }
}
