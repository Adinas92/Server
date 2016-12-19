using BandD.Serwis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BandD.Serwis.ViewModel
{
    public class MainWindowViewModel
    {
        public MailModel mailModel = new MailModel();

        //czyli raz zmienna jest wywolywana jako metoda a za innym razem jest przekazywana jako zmienna? i do tego ta wlasciwosc get set?
        public string mail { get; set; }

        public MainWindowViewModel()
        {
            
            przekazDoModelu(mail);
        }

        private void przekazDoModelu(string mail)
        {
            mailModel.MailAddress = mail;
        }
    }
}
