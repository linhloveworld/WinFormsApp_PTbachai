namespace WinFormsApp_PTbachai
{
    public partial class Form_tinhPTbachai : Form
    {
        public Form_tinhPTbachai()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, denta, x1, x2;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);
            string kq;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        kq = "PT có vô số nghiệm";
                    }
                    else //c khac 0
                    {
                        kq = "PT có vô nghiệm";
                    }
                }
                else // b khac 0
                {
                    kq = String.Format("PT có nghiệm là {0}", ((-c) / b));
                }
            }
            else //a khac 0
            {
                denta = b * b - 4 * a * c;
                if (denta < 0)
                {
                    kq = "PT vô nghiệm";
                }
                else if (denta == 0)
                {
                    kq = String.Format("PT có nghiệm kép là  {0}", ((-b) / (2 * a)));
                }
                else //denta>0
                {
                    x1 = (-b + Math.Sqrt(denta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                    kq = String.Format("PT có 2 nghiệm kép là x1 = {0}\n va x2= {1}",x1,x2);
                }
            }
            txtkqTinh.Text = kq;
        }
    }
}