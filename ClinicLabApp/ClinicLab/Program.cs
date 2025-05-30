using System;
using System.Windows.Forms;
using ClinicLab.Presentation;

namespace ClinicLab
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);



            // Kjo esht forma qe hapet tani per tani, vetem per testim 
            // ju qe do punoni ne module te tjera, si AdminDashboard ose Login etj
            // thjesht ndryshojeni rreshtin poshte sipas nevojes:
            //
            // Application.Run(new AdminDashboardForm());
            // Application.Run(new LoginForm());
            //
            // Nese nuk e ndryshoni kur ti beni run do ju hapet forma e punonjesit te laboratorit 
            System.Windows.Forms.Application.Run(new LabWorkerForm()); 

        }
    }
}




