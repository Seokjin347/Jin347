using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jin347RJ
{
    public partial class frmDashboard : Form
    {

        // Fields
        private Button currenButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;



        // Constructor
        public frmDashboard()
        {
            InitializeComponent();
            random = new Random();
        }

        // Methods
        private Color SelectThemeColor()
        {

            int Index = random.Next(ThemeColor.ColorList.Count);
            while(tempIndex== Index)
            {
                 Index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = Index;
            string color = ThemeColor.ColorList[Index];
            return ColorTranslator.FromHtml(color);

        }
       
        private void ActivateButton(object btnsender)
        {
            if(btnsender != null)
            {

                if (currenButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currenButton = (Button)btnsender;
                    currenButton.BackColor = color;
                    currenButton.ForeColor = Color.White;
                    currenButton.Font  = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }


            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
                    
        
                    
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.paneleEscritorio.Controls.Add(childForm);
            this.paneleEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbltitle.Text = childForm.Text;
        }
       


         private void btnRegistro_Click(object sender, EventArgs e)       
         {
            OpenChildForm(new Forms.Form347(), sender);
         }
       
        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Estudiantes347cs(), sender);
        }
           
      
        private void btnNotas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNotas(), sender);
        }
     
        private void btnAjustes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAjustes(), sender);
        }




      

       
    }
}
