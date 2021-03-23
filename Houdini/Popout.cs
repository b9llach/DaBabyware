using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Houdini
{
    public partial class Popout : Form
    {
        private readonly Random _random;
        public Popout()
        {
            _random = new Random();
            InitializeComponent();
            
        }

        public static string p_weapon;
        public static string p_attachment;
        public static string p_scope;

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        private void Popout_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Popout_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Popout_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        public void on_load()
        {

            //a_label.Text = "ATTACHMENT: " + p_attachment;
            //weapon_label.Text = "WEAPON: " + p_weapon;
            //scope_label.Text = "SCOPE: " + p_scope;
            //MessageBox.Show(p_attachment);
            Task t = Task.Factory.StartNew(() => DoWork(_random));
        }

        private void DoWork(Random random)
        {
            while (true)
            {
                int result = random.Next(1000);
                Thread.Sleep(10);
                Invoke(new Action<int>(UpdateGuiText), result);
            }
        }

        private void UpdateGuiText(int result)
        {
            weapon_label.Text = "Weapon: " + DaBabyware.weapon;
            a_label.Text = "Attachment: " + DaBabyware.attachment;
            scope_label.Text = "Scope: " + DaBabyware.scope;
            active_label.Text = "Active: " + DaBabyware.activ.ToString().ToUpper();
            label1.Text = "Blatant: " + DaBabyware.blatant.ToString().ToUpper();
        }

        private void Popout_Load(object sender, EventArgs e)
        {
            on_load();
        }

        private void a_label_Click(object sender, EventArgs e)
        {

        }

        private void scope_label_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //public static void update_labels ()
        //{
        //    a_label.Text = p_attachment;
        //    weapon_label.Text = p_weapon;
        //    scope_label.Text = p_scope;
        //}

    }
}
