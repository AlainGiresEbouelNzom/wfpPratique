using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Business
{
    public class MainWindowsBusiness
    {
        public string TiltleOfMainWindow { get; set; }
        public List<Models.Etudiant>  EtudiantList { get; set; }

        public MainWindowsBusiness()
        {
            TiltleOfMainWindow = "Hello from the other side";
            EtudiantList = new List<Models.Etudiant>();

            EtudiantList.Add(new Models.Etudiant("Gires"));
            EtudiantList.Add(new Models.Etudiant("Suzanne"));
            EtudiantList.Add(new Models.Etudiant("Mireille"));
            EtudiantList.Add(new Models.Etudiant("Edith"));
            EtudiantList.Add(new Models.Etudiant("Chanel-A"));
        }
    }
}
