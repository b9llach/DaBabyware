using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;


namespace Houdini
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread recoil_thread = new Thread(MainScript);
            recoil_thread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DaBabyware());
        }
        //public static void u_o()
        //{
        //    Form popout = new Popout();
        //    popout.a_label = 
        //}
        static void MainScript()
        {

            if (!Directory.Exists("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\DaBaby"))
            {
                Directory.CreateDirectory("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Rust\\DaBaby");
            }
            
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Volume = 40;

            Weapons.ak ak = new Weapons.ak();
            Weapons.thompson thompson = new Weapons.thompson();
            Weapons.lr lr = new Weapons.lr();
            Weapons.smg smg = new Weapons.smg();
            Weapons.mp5 mp5 = new Weapons.mp5();
            Weapons.m249 m249 = new Weapons.m249();

            //Houdini.ak_vk = 0x71;
            //Houdini.thompson_vk = 0x72;
            //Houdini.custom_vk = 0x73;
            //Houdini.lr_vk = 0x74;
            //Houdini.mp5_vk = 0x75;
            //Houdini.m249_vk = 0x78;


            int mag = 0;

            //byte[] result = BitConverter.GetBytes(Script.GetAsyncKeyState());


            while (true)
            {
                
                if (BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.activ_vk))[0] == 1) //insert
                {
                    DaBabyware.activ = !DaBabyware.activ;
                    if (DaBabyware.tts)
                    {
                        if (DaBabyware.activ)
                            Script.TTS("Activated");
                        else
                            Script.TTS("Deactivated");
                    }
                }

                if (BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.ak_vk))[0] == 1) //f2
                {
                    DaBabyware.weapon = "AK47";
                    Popout.p_weapon = DaBabyware.weapon;

                    if (DaBabyware.tts == true)
                    {
                       Script.TTS("AK");
                    }
                }

           

                if (BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.tts_vk))[0] == 1)
                {
                    DaBabyware.tts = !DaBabyware.tts;
                }


                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.thompson_vk))[0] == 1)) //f3
                {
                    DaBabyware.weapon = "THOMPSON";
                    Popout.p_weapon = DaBabyware.weapon;

                    if (DaBabyware.tts)
                    {
                       Script.TTS("THOMPSON");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.custom_vk))[0] == 1)) //f4
                {
                    DaBabyware.weapon = "CUSTOM";
                    Popout.p_weapon = DaBabyware.weapon;

                    if (DaBabyware.tts)
                    {
                        Script.TTS("CUSTOM");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.lr_vk))[0] == 1)) //f5
                {
                    DaBabyware.weapon = "LR-300";
                    Popout.p_weapon = DaBabyware.weapon;

                    if (DaBabyware.tts)
                    {
                       Script.TTS("LR");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.mp5_vk))[0] == 1)) //f6
                {
                    DaBabyware.weapon = "MP5";
                    Popout.p_weapon = DaBabyware.weapon;

                    if (DaBabyware.tts)
                    {
                       Script.TTS("MP5");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.m249_vk))[0] == 1)) //f9
                {
                    DaBabyware.weapon = "M249";
                    Popout.p_weapon = DaBabyware.weapon;

                    if (DaBabyware.tts)
                    {
                       Script.TTS("M249");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.hmade_vk))[0] == 1)) //f9
                {
                    DaBabyware.scope = "HANDMADE";
                    Popout.p_scope = DaBabyware.scope;
                    if (DaBabyware.tts)
                    {
                        Script.TTS("HANDMADE");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.holo_vk))[0] == 1)) //f9
                {
                    DaBabyware.scope = "HOLOSIGHT";
                    Popout.p_scope = DaBabyware.scope;
                    if (DaBabyware.tts)
                    {
                        Script.TTS("HOLOSIGHT");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.eightx_vk))[0] == 1)) //f9
                {
                    DaBabyware.scope = "8X";
                    Popout.p_scope = DaBabyware.scope;
                    if (DaBabyware.tts)
                    {
                        Script.TTS("8 X");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.sixteenx_vk))[0] == 1)) //f9
                {
                    DaBabyware.scope = "16X";
                    Popout.p_scope = DaBabyware.scope;
                    if (DaBabyware.tts)
                    {
                        Script.TTS("16 X");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.nosight_vk))[0] == 1)) //f9
                {
                    DaBabyware.scope = "NONE";
                    Popout.p_scope = DaBabyware.scope;
                    
                    if (DaBabyware.tts)
                    {
                        Script.TTS("NO SIGHT");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.surpressor_vk))[0] == 1)) //f9
                {
                    DaBabyware.attachment = "SURPRESSOR";
                    Popout.p_attachment = DaBabyware.attachment;
                    if (DaBabyware.tts)
                    {
                        Script.TTS("SURPRESSOR");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.nobarrel_vk))[0] == 1)) //f9
                {
                    DaBabyware.attachment = "NONE";
                    Popout.p_attachment = DaBabyware.attachment;
                    if (DaBabyware.tts)
                    {
                        Script.TTS("NO BARREL");
                    }
                }

                if ((BitConverter.GetBytes(Script.GetAsyncKeyState(DaBabyware.blatant_vk))[0] == 1)) //f9
                {
                    DaBabyware.blatant = !DaBabyware.blatant;
                    if (DaBabyware.blatant == true)
                    {
                        if (DaBabyware.tts)
                            Script.TTS("BLATANT ON");
                    } else
                    {
                        if (DaBabyware.tts)
                            Script.TTS("BLATANT OFF");
                    }
                }

                //Popout.update_labels();
                

                if (DaBabyware.blatant == false)
                {
                    if (DaBabyware.activ && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
                    {

                        if (mag < ak.pattern.Length && DaBabyware.weapon == "AK47")
                        {
                            Script.Smoothing((double)ak.delay, (double)ak.control_time[mag], Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, ak.pattern[mag].x, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, (float)ak.pattern[mag].y, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer));
                            mag++;
                        }

                        if (mag < mp5.pattern.Length && DaBabyware.weapon == "MP5")
                        {
                            Script.Smoothing((double)mp5.delay, (double)mp5.delay, Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, mp5.pattern[mag].x, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, (float)mp5.pattern[mag].y, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer));
                            mag++;
                        }

                        if (mag < smg.pattern.Length && DaBabyware.weapon == "CUSTOM")
                        {
                            Script.Smoothing((double)smg.delay, (double)smg.delay, Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, smg.pattern[mag].x, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, (float)smg.pattern[mag].y, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer));
                            mag++;
                        }

                        if (mag < lr.pattern.Length && DaBabyware.weapon == "LR-300")
                        {
                            Script.Smoothing((double)lr.delay, (double)lr.delay, Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, lr.pattern[mag].x, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, (float)lr.pattern[mag].y, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < thompson.pattern.Length && DaBabyware.weapon == "THOMPSON")
                        {
                            Script.Smoothing((double)thompson.delay, (double)thompson.delay, Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, thompson.pattern[mag].x, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, (float)thompson.pattern[mag].y, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < m249.pattern.Length && DaBabyware.weapon == "M249")
                        {
                            Script.Smoothing((double)m249.delay, (double)m249.delay, Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, m249.pattern[mag].x, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsens(DaBabyware.sense, DaBabyware.fov, (float)m249.pattern[mag].y, Script.scopeToInt(), Script.barrelToInt()), DaBabyware.randomizer));
                            mag++;
                        }
                    }
                    else
                    {
                        mag = 0;
                    }
                } else if (DaBabyware.blatant == true)
                {

                    if (DaBabyware.activ && Mouse.IsKeyDown(Keys.LButton) && Mouse.IsKeyDown(Keys.RButton))
                    {
                        if (mag < ak.pattern.Length && DaBabyware.weapon == "AK47")
                        {
                            Script.Blatant(ak.delay, ak.control_time[mag], Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, ak.pattern[mag].x), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, ak.pattern[mag].y), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < mp5.pattern.Length && DaBabyware.weapon == "MP5")
                        {
                            Script.Blatant(mp5.delay, mp5.delay, Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, mp5.pattern[mag].x), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, mp5.pattern[mag].y), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < smg.pattern.Length && DaBabyware.weapon == "CUSTOM")
                        {
                            Script.Blatant(smg.delay, smg.delay, Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, smg.pattern[mag].x), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, smg.pattern[mag].y), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < lr.pattern.Length && DaBabyware.weapon == "LR-300")
                        {
                            Script.Blatant(lr.delay, lr.delay, Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, lr.pattern[mag].x), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, lr.pattern[mag].y), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < thompson.pattern.Length && DaBabyware.weapon == "THOMPSON")
                        {
                            Script.Blatant(thompson.delay, thompson.delay, Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, lr.pattern[mag].x), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, thompson.pattern[mag].y), DaBabyware.randomizer));
                            mag++;
                        }
                        if (mag < m249.pattern.Length && DaBabyware.weapon == "M249")
                        {
                            Script.Blatant(m249.delay, m249.delay, Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, m249.pattern[mag].x), DaBabyware.randomizer), Script.Randomize((float)Script.tofovandsensBLATANT((float)DaBabyware.sense, DaBabyware.fov, m249.pattern[mag].y), DaBabyware.randomizer));
                            mag++;
                        }

                    } else
                    {
                        mag = 0;
                    }
                }
                
            }
        }
        }
}
