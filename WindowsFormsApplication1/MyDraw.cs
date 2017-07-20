using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MyDraw : Control
    {
        public Panel panel1;        

        public MyDraw()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            this.ResumeLayout(false);

            panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.PlaceGame_Paint);

        }

        private void PlaceGame_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
