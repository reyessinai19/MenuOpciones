using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;

namespace MiLoginSinai
{
    public partial class fmrlogin : Form
    {
        public fmrlogin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
              txtusuario.Clear();
            txtcontrasena.Clear();
        }
        private void btningresar_Click(Object sender, EventArgs e) 
        {
            if (txtusuario.Text == "sistemas" && txtcontrasena.Text == "4455")
            {
                frminicio frminicio = new frminicio();
                this.Hide();
                frminicio.Show(); 
            }
            else
            {
                MessageBox.Show("los datos ingresados son incorrectos");
                txtusuario.Clear() ;
                txtcontrasena.Clear() ;
            }
        }
    } 
} 

