using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace QueuingCashier
{
    public partial class CashierWindowQueueForm : Form
    {
        private CashierClass cashier;
        private CustomerView cv;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }    
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();  
            DisplayCashierQueue(CashierClass.CashierQueue);             
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            cv = new CustomerView();
            cv.Show();
            CashierClass.CashierQueue.Dequeue();
            DisplayCashierQueue(CashierClass.CashierQueue);

           cv.lblServe.Text = CashierClass.CashierQueue.Peek();
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "CustomerView")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                cv = new CustomerView();
                cv.Show();
                Isopen = true;
            }

        }     
    }
}

