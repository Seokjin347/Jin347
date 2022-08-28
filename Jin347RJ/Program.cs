using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jin347RJ
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       public  static void mostrarinicio()
        {
            foreach (Form form in Application.OpenForms)
                if (form.Name == "Form1")
                    form.Show();

           
        }
        public static Form EstaAbierto(string nombre)
        {
            bool EstaAbierto = false;

            foreach (Form f in Application.OpenForms)
                if (f.Name == nombre)
                    return f;
            
                  
             

            return null;

        }
              public static void cerraraplicacion()
        {
            Application.ExitThread();
        }

    }
}
