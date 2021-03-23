using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using System.Threading;
using System.Runtime.InteropServices;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Media;

namespace Houdini
{
    public partial class DaBabyware : Form
    {
        public static bool activ = false;
        public static bool humanize = false;
        public static bool tts = false;
        public static bool blatant = false;
        public static bool weapon_detect = false;

        public static int randomizer = 1;
        public static double sense = .24;
        public static int fov = 90;

        public static string file_name;

        public static string weapon;
        public static string attachment;
        public static string scope;

        public static int f2 = 0x71;
        public static int f3 = 0x72;
        public static int f4 = 0x73;
        public static int f5 = 0x74;
        public static int f6 = 0x75;
        public static int f7 = 0x76;
        public static int f8 = 0x77;
        public static int f9 = 0x78;

        public static int ins = 0x2D;

        public static int n0 = 0x60;
        public static int n1 = 0x61;
        public static int n2 = 0x62;
        public static int n3 = 0x63;
        public static int n4 = 0x64;
        public static int n5 = 0x65;
        public static int n6 = 0x66;
        public static int n7 = 0x67;
        public static int n8 = 0x68;
        public static int n9 = 0x69;

        public static int ak_vk;
        public static int thompson_vk;
        public static int custom_vk;
        public static int lr_vk;
        public static int mp5_vk;
        public static int m249_vk;
        public static int activ_vk;
        public static int tts_vk;
        public static int hmade_vk;
        public static int holo_vk;
        public static int eightx_vk;
        public static int sixteenx_vk;
        public static int nosight_vk;
        public static int nobarrel_vk;
        public static int surpressor_vk;
        public static int blatant_vk;
        public static int crosshair_vk;

        bool overlay = false;

        bool discord = false;
        public static bool crosshairbool = false;

        private readonly Random _random;

        /// <summary>
        /// 
        /// </summary>
        /// 
        //public void on_start()
        //{
        //    Thread overlay_form = new Thread(overlay_thread);
        //    overlay_form.Start();
        //}

        //public void overlay_thread()
        //{
        //    Form popout = new Popout();
        //}
        //public void stop_ot()
        //{
        //    pop
        //}
        public void init_configs()
        {
            try
                
            {
                foreach (string line in File.ReadAllLines("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\DaBaby\\DaBaby.hfg"))
                {
                    if (line.StartsWith("attachment"))
                    {
                        attachment = line.Split('=')[1];
                        comboBox3.SelectedItem = attachment;
                        
                    }
                    if (line.StartsWith("weapon"))
                    {
                        weapon = line.Split('=')[1];
                        comboBox1.SelectedItem = weapon;
                        
                    }
                    if (line.StartsWith("scope"))
                    {
                        scope = line.Split('=')[1];
                        comboBox2.SelectedItem = scope;

                    }
                    //if (line.StartsWith("tts_bool"))
                    //{
                    //    //MessageBox.Show(line.Split('=')[1].ToLower());
                    //    tts = !bool.Parse(line.Split('=')[1].ToLower());
                    //    checkBox2.Checked = tts;
                    //    //MessageBox.Show(tts.ToString());

                    //}
                    //if (line.StartsWith("discord"))
                    //{
                    //    discord = bool.Parse(line.Split('=')[1].ToLower());
                    //    checkBox3.Checked = discord;
                    //    Setup();
                    //}
                    if (line.StartsWith("randomizer"))
                    {
                        randomizer = int.Parse(line.Split('=')[1]);
                        trackBar1.Value = randomizer;
                    }
                    if (line.StartsWith("sense"))
                    {
                        sense = double.Parse(line.Split('=')[1]);
                        textBox1.Text = line.Split('=')[1];

                    }
                    if (line.StartsWith("fov"))
                    {
                        fov = int.Parse(line.Split('=')[1]);
                        textBox2.Text = line.Split('=')[1];
                    }

                    if (line.StartsWith("ak_vk"))
                    {
                        ak_vk = int.Parse(line.Split('=')[1]);
                        ak_keybind.SelectedItem = int_to_keybind(ak_vk);

                    }
                    if (line.StartsWith("thompson_vk"))
                    {
                        thompson_vk = int.Parse(line.Split('=')[1]);
                        thompson_keybind.SelectedItem = int_to_keybind(thompson_vk);
                    }
                    if (line.StartsWith("mp5_vk"))
                    {
                        mp5_vk = int.Parse(line.Split('=')[1]);
                        mp5_keybind.SelectedItem = int_to_keybind(mp5_vk);
                    }
                    if (line.StartsWith("lr_vk"))
                    {
                        lr_vk = int.Parse(line.Split('=')[1]);
                        lr_keybind.SelectedItem = int_to_keybind(lr_vk);
                    }
                    if (line.StartsWith("m249_vk"))
                    {
                        m249_vk = int.Parse(line.Split('=')[1]);
                        m249_keybind.SelectedItem = int_to_keybind(m249_vk);

                    }
                    if (line.StartsWith("custom_vk"))
                    {
                        custom_vk = int.Parse(line.Split('=')[1]);
                        custom_keybind.SelectedItem = int_to_keybind(custom_vk);

                    }
                    if (line.StartsWith("activ_vk"))
                    {
                        activ_vk = int.Parse(line.Split('=')[1]);
                        activ_keybind.SelectedItem = int_to_keybind(activ_vk);

                    }
                    if (line.StartsWith("tts_vk"))
                    {
                        tts_vk = int.Parse(line.Split('=')[1]);
                        blatant_keybind.SelectedItem = int_to_keybind(tts_vk);

                    }
                    if (line.StartsWith("hmade_vk"))
                    {
                        hmade_vk = int.Parse(line.Split('=')[1]);
                        hmade_keybind.SelectedItem = int_to_keybind(hmade_vk);
                    }
                    if (line.StartsWith("holo_vk"))
                    {
                        holo_vk = int.Parse(line.Split('=')[1]);
                        holo_keybind.SelectedItem = int_to_keybind(holo_vk);

                    }
                    if (line.StartsWith("eightx_vk"))
                    {
                        eightx_vk = int.Parse(line.Split('=')[1]);
                        eightx_keybind.SelectedItem = int_to_keybind(eightx_vk);
                    }
                    if (line.StartsWith("sixteenx_vk"))
                    {
                        sixteenx_vk = int.Parse(line.Split('=')[1]);
                        sixteenx_keybind.SelectedItem = int_to_keybind(sixteenx_vk);

                    }
                    if (line.StartsWith("nosight_vk"))
                    {
                        nosight_vk = int.Parse(line.Split('=')[1]);
                        nosight_keybind.SelectedItem = int_to_keybind(nosight_vk);

                    }
                    if (line.StartsWith("nobarrel_vk"))
                    {
                        nobarrel_vk = int.Parse(line.Split('=')[1]);
                        nobarrel_keybind.SelectedItem = int_to_keybind(nobarrel_vk);

                    }
                    if (line.StartsWith("surpressor_vk"))
                    {
                        surpressor_vk = int.Parse(line.Split('=')[1]);
                        surpressor_keybind.SelectedItem = int_to_keybind(surpressor_vk);
                    }
                    if (line.StartsWith("blatant_vk"))
                    {
                        blatant_vk = int.Parse(line.Split('=')[1]);
                        blatant_keybind.SelectedItem = int_to_keybind(blatant_vk);
                    }
                    //if (line.StartsWith("crosshair_vk"))
                    //{
                    //    crosshair_vk = int.Parse(line.Split('=')[1]);
                    //    crosshair_keybind.SelectedItem = int_to_keybind(crosshair_vk);
                    //}


                }
                //config_combo.SelectedItem = "";
                MessageBox.Show("CONFIG LOADED!");
            }
            catch
            {
                MessageBox.Show("CONFIG NOT FOUND!");

            }
        }

        public DiscordRpcClient Client { get; private set; }

        public void Setup()
        {
            Client = new DiscordRpcClient("823913803162451989");  //Creates the client
            Client.Initialize();                            //Connects the client
            Client.SetPresence(new RichPresence()
            {
                Details = "LES GOOOO",
                State = "CHEATING IN RUST",
                Assets = new Assets()
                {
                    LargeImageKey = "dababy",
                    LargeImageText = "DaBaby",
                    //SmallImageKey = ""
                }
            });
        }

        public void CloseDC()
        {
            Client.ClearPresence();
        }

        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0,0);
        //private readonly Random _random;
        public DaBabyware()
        {

            //Setup();
            
            InitializeComponent();
            init_configs();

            //on_load();
            //string exePath = Application.ExecutablePath;
            //string dll_path = exePath.Replace("Dababyware.exe", "lesgo.wav");

            //System.Media.SoundPlayer player = new System.Media.SoundPlayer(dll_path);
            //player.Play();
            SoundPlayer sound = new SoundPlayer(Properties.Resources.lesgo);
            sound.Play();

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
                // loops thread every second
                Thread.Sleep(1000);
                Invoke(new Action<int>(CaptureScreen), 0);
            }
        }
        private void CaptureScreen(int x)
        {

            // for weapon detection

            //Graphics myGraphics = this.CreateGraphics();
            //Size s = this.Size;
            //memoryImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            //memoryGraphics.CopyFromScreen(970, 1290, 2438, 1290, memoryImage.Size);
            //memoryImage.Save(@"C:\\Users\\billy\\source\\repos\\WeaponDetection\\WeaponDetection\\bin\\Debug\\screen.png");
            //using (Image<Gray, byte> sourceImage = new Image<Gray, byte>("C:\\Users\\billy\\source\\repos\\WeaponDetection\\WeaponDetection\\bin\\Debug\\screen.png"))
            //{
            //    using (Image<Gray, byte> templateImage = new Image<Gray, byte>("C:\\Users\\billy\\Downloads\\mp52.png"))
            //    {
            //        Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            //        double[] minValues, maxValues;
            //        Point[] minLocations, maxLocations;
            //        resultImage.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            //        //label1.Text = "mp5: " + maxValues[0].ToString();
            //        if (weapon_detect == true)
            //        {
            //            if (maxValues[0] > .6)
            //            {
            //                weapon = "MP5";
            //                //MessageBox.Show("mp5 1");
            //            }
            //        }
            //    }
            //}
            //using (Image<Gray, byte> sourceImage = new Image<Gray, byte>("C:\\Users\\billy\\source\\repos\\WeaponDetection\\WeaponDetection\\bin\\Debug\\screen.png"))
            //{
            //    using (Image<Gray, byte> templateImage = new Image<Gray, byte>("C:\\Users\\billy\\Downloads\\mp53.png"))
            //    {
            //        Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            //        double[] minValues, maxValues;
            //        Point[] minLocations, maxLocations;
            //        resultImage.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            //        //label6.Text = "mp5 (2): " + maxValues[0].ToString();
            //        if (weapon_detect == true)
            //        {
            //            if (maxValues[0] > .6)
            //            {
            //                weapon = "MP5";
            //                //MessageBox.Show("mp5 2");
            //            }
            //        }
            //    }
            //}
            //using (Image<Gray, byte> sourceImage = new Image<Gray, byte>("C:\\Users\\billy\\source\\repos\\WeaponDetection\\WeaponDetection\\bin\\Debug\\screen.png"))
            //{
            //    using (Image<Gray, byte> templateImage = new Image<Gray, byte>("C:\\Users\\billy\\Downloads\\ak4.png"))
            //    {
            //        Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            //        double[] minValues, maxValues;
            //        Point[] minLocations, maxLocations;
            //        resultImage.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            //       // label2.Text = "ak: " + maxValues[0].ToString();
            //        if (weapon_detect == true)
            //        {
            //            if (maxValues[0] > .6)
            //            {
            //                weapon = "AK47";
            //                //MessageBox.Show("ak 1");
            //            }
            //        }
            //    }
            //}
            //using (Image<Gray, byte> sourceImage = new Image<Gray, byte>("C:\\Users\\billy\\source\\repos\\WeaponDetection\\WeaponDetection\\bin\\Debug\\screen.png"))
            //{
            //    using (Image<Gray, byte> templateImage = new Image<Gray, byte>("C:\\Users\\billy\\Downloads\\akblue.png"))
            //    {
            //        Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            //        double[] minValues, maxValues;
            //        Point[] minLocations, maxLocations;
            //        resultImage.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            //       // label5.Text = "ak (2): " + maxValues[0].ToString();
            //        if (weapon_detect == true)
            //        {
            //            if (maxValues[0] > .6)
            //            {
            //                weapon = "AK47";
            //                //MessageBox.Show("ak 2");
            //            }
            //        }
            //    }
            //}
            //using (Image<Gray, byte> sourceImage = new Image<Gray, byte>("C:\\Users\\billy\\source\\repos\\WeaponDetection\\WeaponDetection\\bin\\Debug\\screen.png"))
            //{
            //    using (Image<Gray, byte> templateImage = new Image<Gray, byte>("C:\\Users\\billy\\Downloads\\custom.png"))
            //    {
            //        Image<Gray, float> resultImage = sourceImage.MatchTemplate(templateImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed);

            //        double[] minValues, maxValues;
            //        Point[] minLocations, maxLocations;
            //        resultImage.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
            //       // label3.Text = "smg: " + maxValues[0].ToString();
            //    }
            //}

        }

        public static string int_to_keybind(int x)
        {
            if (x == 0x71)
            {
                return "F2";
            }
            if (x == 0x72)
            {
                return "F3";
            }
            if (x == 0x73)
            {
                return "F4";
            }
            if (x == 0x74)
            {
                return "F5";
            }
            if (x == 0x75)
            {
                return "F6";
            }
            if (x == 0x76)
            {
                return "F7";
            }
            if (x == 0x77)
            {
                return "F8";
            }
            if (x == 0x78)
            {
                return "F9";
            }
            if (x == 0x79)
            {
                return "F10";
            }
            if (x == 0x7A)
            {
                return "F11";
            }
            if (x == 0x7B)
            {
                return "F12";
            }
            if (x == 0x2D)
            {
                return "INS";
            }
            if (x == 0x26)
            {
                return "UP";
            }
            if (x == 0x28)
            {
                return "DOWN";
            }
            if (x == 0x25)
            {
                return "LEFT";
            }
            if (x == 0x27)
            {
                return "RIGHT";
            }
            if (x == 0x21)
            {
                return "PGUP";
            }
            if (x == 0x22)
            {
                return "PGDW";
            }
            if (x == 0x24)
            {
                return "HOME";
            }
            if (x == 0x23)
            {
                return "END";
            }
            else
            {
                return "UNKNOWN";
            }
        }

        public static int keybind_to_int(string x)
        {
            if (x == "F2")
            {
                return 0x71;
            }
            if (x == "F3")
            {
                return 0x72;
            }
            if (x == "F4")
            {
                return 0x73;
            }
            if (x == "F5")
            {
                return 0x74;
            }
            if (x == "F6")
            {
                return 0x75;
            }
            if (x == "F7")
            {
                return 0x76;
            }
            if (x == "F8")
            {
                return 0x77;
            }
            if (x == "F9")
            {
                return 0x78;
            }
            if (x == "F10")
            {
                return 0x79;
            }
            if (x == "F11")
            {
                return 0x7A;
            }
            if (x == "F12")
            {
                return 0x7B;
            }
            if (x == "INS")
            {
                return 0x2D;
            }
            if (x == "UP")
            {
                return 0x26;
            }
            if (x == "DOWN")
            {
                return 0x28;
            }
            if (x == "LEFT")
            {
                return 0x25;
            }
            if (x == "RIGHT")
            {
                return 0x27;
            }
            if (x == "PGUP")
            {
                return 0x21;
            }
            if (x == "PGDW")
            {
                return 0x22;
            }
            if (x == "HOME")
            {
                return 0x24;
            }
            if (x=="END")
            {
                return 0x23;
            }
            else
            {
                return -1;
            }
        }

        Form popout = new Popout();
        Form crosshair = new Crosshair();
       

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer sound = new SoundPlayer(Properties.Resources.huh);
            sound.Play();
            Thread.Sleep(1000);
            Environment.Exit(0);

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            activ = !activ;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            humanize = !humanize;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            scope = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachment = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            randomizer = trackBar1.Value;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float flt1 = float.Parse(textBox1.Text);
                sense = flt1;
            } catch
            {
                ;
            }
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                fov = int.Parse(textBox2.Text);
            }
            catch
            {
                ;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            tts = !tts;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) // save 
        {

            /* public static bool activ = false;
            public static bool humanize = false;
            public static bool tts = false;
            public static bool autogundetect = false;

            public static int randomizer = 1;
            public static double sense = .24;
            public static int fov = 90;

            public static string weapon;
            public static string attachment;
            public static string scope; */

        //public static int ak_vk;
        //public static int thompson_vk;
        //public static int custom_vk;
        //public static int lr_vk;
        //public static int mp5_vk;
        //public static int m249_vk;
        //public static int activ_vk;
        //public static int tts_vk;
        //public static int hmade_vk;
        //public static int holo_vk;
        //public static int eightx_vk;
        //public static int sixteenx_vk;
        //public static int nosight_vk;
        //public static int nobarrel_vk;
        //public static int surpressor_vk;

        string[] lines = { "weapon="+weapon,
                "attachment="+attachment, 
                "scope="+scope,
                //"tts_bool="+tts,
                //"discord="+discord,
                "randomizer="+randomizer, 
                "sense="+sense, 
                "fov=" + fov,
                "ak_vk="+ak_vk,
                "thompson_vk="+thompson_vk,
                "custom_vk="+custom_vk,
                "lr_vk="+lr_vk,
                "mp5_vk="+mp5_vk,
                "m249_vk="+m249_vk,
                "activ_vk="+activ_vk,
                "tts_vk="+tts_vk,
                "hmade_vk="+hmade_vk,
                "holo_vk="+holo_vk,
                "eightx_vk="+eightx_vk,
                "sixteenx_vk="+sixteenx_vk,
                "nosight_vk="+nosight_vk,
                "nobarrel_vk="+nobarrel_vk,
                "surpressor_vk="+surpressor_vk,
                "blatant_vk="+blatant_vk};

            // Set a variable to the Documents path.
            string docPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\DaBaby";

            string fileName =  "DaBaby.hfg";

            //textBox3.Text = "";

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, fileName)))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }
        }

        private void button3_Click(object sender, EventArgs e) // open



            //    "weapon="+weapon,
            //    "attachment="+attachment, 
            //    "scope="+scope,
            //    "tts="+tts,
            //    "randomizer="+randomizer, 
            //    "sense="+sense, 
            //    "fov=" + fov,
            //    "ak_vk="+ak_vk,
            //    "thompson_vk="+thompson_vk,
            //    "custom_vk="+custom_vk,
            //    "lr_vk="+lr_vk,
            //    "mp5_vk="+mp5_vk,
            //    "m249_vk="+m249_vk,
            //    "activ_vk="+activ,
            //    "tts_vk="+tts_vk,
            //    "hmade_vk="+hmade_vk,
            //    "holo_vk="+holo_vk,
            //    "eightx_vk="+eightx_vk,
            //    "sixteenx_vk="+sixteenx_vk,
            //    "nosight_vk="+nosight_vk,
            //    "nobarrel_vk="+nobarrel_vk,
            //    "surpressor_vk="+surpressor_vk
        {
            
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // save textbox
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            custom_vk = keybind_to_int(custom_keybind.Text);
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(ak_keybind.Text);
            ak_vk = keybind_to_int(ak_keybind.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            // mp5
            //MessageBox.Show(mp5_keybind.Text);
            mp5_vk = keybind_to_int(mp5_keybind.Text);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lr
            lr_vk = keybind_to_int(lr_keybind.Text);
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            m249_vk = keybind_to_int(m249_keybind.Text);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            thompson_vk = keybind_to_int(thompson_keybind.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            discord = !discord;
            if (discord == true)
            {
                Setup();
            }
            if (discord == false)
            {
                CloseDC();
            }
        }

        private void activ_keybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            activ_vk = keybind_to_int(activ_keybind.Text);
        }

        private void tts_keybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            blatant_vk = keybind_to_int(blatant_keybind.Text);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // handmade
            hmade_vk = keybind_to_int(hmade_keybind.Text);
            
        }

        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // holo
            holo_vk = keybind_to_int(holo_keybind.Text);
        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 8x
            eightx_vk = keybind_to_int(eightx_keybind.Text);
        }

        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // 16x
            sixteenx_vk = keybind_to_int(sixteenx_keybind.Text);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            nosight_vk = keybind_to_int(nosight_keybind.Text);
        }

        private void nobarrel_keybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            nobarrel_vk = keybind_to_int(nobarrel_keybind.Text);
        }

        private void comboBox7_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            surpressor_vk = keybind_to_int(surpressor_keybind.Text);
        }

        private void comboBox4_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }
        private void overlay_checkbox_CheckedChanged(object sender, EventArgs e)
        {

            overlay = !overlay;

            if (overlay == true)
            {
                popout.Show();

            }
            else
            {
                popout.Hide();
                //popout.Dispose();
            }
        }

        private void blatant_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            blatant = !blatant;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //// weapon detect
            crosshairbool = !crosshairbool;

            if (crosshairbool == true)
            {
                crosshair.Show();
            }
            else
            {
                crosshair.Hide();
            }



        }

        private void crosshair_keybind_SelectedIndexChanged(object sender, EventArgs e)
        {
            //crosshair_vk = keybind_to_int(crosshair_keybind.Text);
        }

        private void autoweapondetect_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            weapon_detect = !weapon_detect;
        }
    }
}
