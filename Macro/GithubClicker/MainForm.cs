using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using GithubClicker.Sample.Other;
using GithubClicker.Sample.Combat;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GithubClicker.Sample.Other;
using GithubClicker.Sample.Combat;
using InputSimulatorStandard;
using InputSimulatorStandard.Native;
using System.Threading;
using System.Windows.Data;
using System.Media;
using System.Windows.Forms;
using System.Media;
using Microsoft.VisualBasic.Devices;

namespace GithubClicker
{
    public partial class MainForm : Form
    {
        readonly Random rndSeed = new Random(Guid.NewGuid().GetHashCode());
        private System.Windows.Forms.Timer timer;

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private SoundPlayer player3;
        

        private bool isPlaying = false;

        private string audioFilePath = @"C:\Users\Henrique\AppData\Roaming\bonafideclient\tec2.wav";
        public MainForm()
        {
            InitializeComponent();

            Region = Region.FromHrgn(WinApi.CreateRoundRectRgn(0, 0, Width, Height, 15, 15)); /* create rounded borders on form */

            Task.Run(() => GetSlots());         /* runs a new task after MainForm has finished intializing components, which will basically run in a loop and always be on */
            Task.Run(() => DoLeftClick());      /* ..... */
            Task.Run(() => DoRightClick());
            Task.Run(() => Randomisation());

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; // Intervalo em milissegundos (ajuste conforme necessário)
            timer.Tick += Timer_Tick;
            timer.Start();


            simulator = new InputSimulator();
            //35 = 20
            //50 = 15/16


        }


        private async void Timer_Tick(object sender, EventArgs e)
        {
            // Verifique se o software está minimizado ou se está em foco (na frente de outras janelas)
            //if (WindowState == FormWindowState.Minimized || this.ContainsFocus)
            //{
            SoundPlayer player3 = new SoundPlayer(audioFilePath);
            //return;
            //}
            //MCHelper.GetMinecraftWindow();

            // Verifique o estado dos botões laterais do mouse
            if ((GetAsyncKeyState((int)Keys.XButton1) & 0x8000) != 0)
            {

                if (tl.Text == "XButton1")
                {
                    // btBindLeft está escrito como "XButton1", então simule um clique do botão esquerdo
                    simulator.Mouse.LeftButtonDown();
                    simulator.Mouse.LeftButtonUp();
                    if (isPlaying == false)
                    {
                        isPlaying = true;
                        if (siticoneCustomCheckBox6.Checked)
                            player3.Play();
                    }
                }

                if (tr.Text == "XButton1")
                {
                    // btBindRight está escrito como "XButton1", então simule um clique do botão direito
                    simulator.Mouse.RightButtonDown();
                    simulator.Mouse.RightButtonUp();
                    if (isPlaying == false)
                    {
                        isPlaying = true;
                        if (siticoneCustomCheckBox6.Checked)
                            player3.Play();
                    }
                }
            }
            else if ((GetAsyncKeyState((int)Keys.XButton2) & 0x8000) != 0)
            {
                if (tl.Text == "XButton2")
                {
                    // btBindLeft está escrito como "XButton2", então simule um clique do botão esquerdo
                    simulator.Mouse.LeftButtonDown();
                    simulator.Mouse.LeftButtonUp();
                    if (isPlaying == false)
                    {       
                        isPlaying = true;
                        if (siticoneCustomCheckBox6.Checked)
                            player3.Play();
                    }
                }
                if (tr.Text == "XButton2")
                {
                    // btBindRight está escrito como "XButton2", então simule um clique do botão direito
                    simulator.Mouse.RightButtonDown();
                    simulator.Mouse.RightButtonUp();
                    if (isPlaying == false)
                    {
                        isPlaying = true;
                        if (siticoneCustomCheckBox6.Checked)
                            player3.Play();
                    }
                }
            }
            else
            {
                // Nenhum dos botões XButton1 ou XButton2 está pressionado
                isPlaying = false;

                if (siticoneCustomCheckBox6.Checked)
                    player3.Stop();
            }
        }


        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            /* moves the gui when left click is held */
            if (e.Button == MouseButtons.Left)
            {
                WinApi.ReleaseCapture();
                WinApi.SendMessage(Handle, WinApi.WM_NCLBUTTONDOWN, WinApi.HT_CAPTION, 0);

            }

        }

        private void sldLeftCPS_ValueChanged(object sender, EventArgs e)
        {
            lbLeftCPS.Text = $"CPS: {sldLeftCPS.Value}";

            if (sldLeftCPS.Value == 16)
            {
                timer.Interval = 50;
            }

            if (sldLeftCPS.Value == 20)
            {
                timer.Interval = 35;
            }

            if (sldLeftCPS.Value == 11)
            {
                timer.Interval = 80;
            }
        }

        #region Sliders event


        private void sldRightCPS_ValueChanged(object sender, EventArgs e)
        {
            lbRightCPS.Text = $"CPS: {sldRightCPS.Value}";

            if (sldRightCPS.Value == 16)
            {
                timer.Interval = 50;
            }

            if (sldRightCPS.Value == 20)
            {
                timer.Interval = 35;
            }

            if (sldRightCPS.Value == 11)
            {
                timer.Interval = 80;
            }
        }

        #endregion



        #region Binds


        #region Set binds

        private int leftBind = 0; /* 0 = no key */
        private bool bindingMode = false; // Variável para controlar se estamos no modo de vinculação

        private void btBindLeft_Click(object sender, EventArgs e)
        {
            bindingMode = true; // Ativa o modo de vinculação
            btBindLeft.Text = "[NONE]"; // Atualiza o texto do botão para indicar que estamos aguardando um clique ou tecla

            // Aguarde a entrada do usuário
            Task.Run(() =>
            {
                while (bindingMode)
                {

                    if ((GetAsyncKeyState((int)Keys.LButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão esquerdo do mouse (LButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            btBindLeft.Text = "[NONE]";
                            bindingMode = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.RButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão direito do mouse (RButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            btBindLeft.Text = "[NONE]";
                            bindingMode = false; // Saia do modo de vinculação
                        }));
                    }

                    Thread.Sleep(100); // Aguarde um curto período antes de verificar novamente
                }
            });
        }

        private void btBindLeft_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    leftBind = 0;               /* set leftBind to no key */
                    btBindLeft.Text = "[NONE]"; /* set the label to be None */
                    bindingMode = false;
                    break;

                default:                        /* default = any key that has been pressed */
                    leftBind = (int)e.KeyCode;
                    btBindLeft.Text = "[" + e.KeyCode + "]";
                    bindingMode = false;
                    break;

            }

            if (e.KeyCode == Keys.Escape)
            {
                bindingMode = false; // Saia do modo de vinculação se a tecla Escape for pressionada
                btBindLeft.Text = "[NONE]"; // Atualize o texto do botão para indicar que nenhum botão foi vinculado
            }
        }
        private int rightBind = 0;

        private void btBindRight_Click(object sender, EventArgs e)
        {
            bindingMode = true; // Ativa o modo de vinculação
            btBindLeft.Text = "[NONE]"; // Atualiza o texto do botão para indicar que estamos aguardando um clique ou tecla

            // Aguarde a entrada do usuário
            Task.Run(() =>
            {
                while (bindingMode)
                {
                    // Verifique se ocorreu um clique de mouse
                    if ((GetAsyncKeyState((int)Keys.XButton1) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão lateral do mouse XButton1 pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            btBindRight.Text = "XButton1";
                            bindingMode = true; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.XButton2) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão lateral do mouse XButton2 pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            btBindRight.Text = "XButton2";
                            bindingMode = true; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.LButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão esquerdo do mouse (LButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            btBindRight.Text = "[NONE]";
                            bindingMode = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.RButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão direito do mouse (RButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            btBindRight.Text = "[NONE]";
                            bindingMode = false; // Saia do modo de vinculação
                        }));
                    }

                    // Verifique se ocorreu um pressionamento de tecla
                    for (int i = 1; i <= 255; i++)
                    {
                        if (GetAsyncKeyState(i) != 0)
                        {
                            // Uma tecla foi pressionada
                            this.Invoke((MethodInvoker)(() =>
                            {
                                btBindLeft.Text = "[" + ((Keys)i).ToString() + "]";
                                bindingMode = false; // Saia do modo de vinculação
                            }));
                        }
                    }

                    Thread.Sleep(100); // Aguarde um curto período antes de verificar novamente
                }
            });
        }

        private void btBindRight_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    rightBind = 0;               /* set leftBind to no key */
                    btBindRight.Text = "[NONE]"; /* set the label to be None */
                    break;

                default:                        /* default = any key that has been pressed */
                    rightBind = (int)e.KeyCode;
                    btBindRight.Text = "[" + e.KeyCode + "]";
                    break;
            }

            if (e.KeyCode == Keys.Escape)
            {
                bindingMode = false; // Saia do modo de vinculação se a tecla Escape for pressionada
                btBindRight.Text = "[NONE]"; // Atualize o texto do botão para indicar que nenhum botão foi vinculado
            }
        }
        #endregion



        #region Binds timer
        private void Binding_Tick(object sender, EventArgs e)
        {
            if (WinApi.GetAsyncKeyState(leftBind) != 0) tgLeft.Checked = !tgLeft.Checked;       /* if key held is leftBind, then it will unable / disable toggle */
            
            if (WinApi.GetAsyncKeyState(rightBind) != 0) tgRight.Checked = !tgRight.Checked;    /* if key held is rightBind, then it will unable / disable toggle */
        }
        #endregion


        #endregion



        #region Slot whitelist

        private byte currentSlot = 1; /* default current slot set to 1 */
        private async void GetSlots()
        {
            for (; ; ) /* will loop and never stop, until it breaks */
            {
                await Task.Delay(50);

                GetKeyPressed();        /* get pressed key to get current slot position */

                IsWhitelistedLeft();    /* bool checking if the current left slot is whitelisted */
                IsWhitelistedRight();   /* same but for right click */
            }
        }


        private void GetKeyPressed()
        {
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS1) != 0) currentSlot = 1; /* if get pressed is D1, current slot = 1 */
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS2) != 0) currentSlot = 2; /* if get pressed is D2, current slot = 2 */
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS3) != 0) currentSlot = 3; /* if get pressed is D3, current slot = 3 */
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS4) != 0) currentSlot = 4; /* ........ */
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS5) != 0) currentSlot = 5;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS6) != 0) currentSlot = 6;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS7) != 0) currentSlot = 7;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS8) != 0) currentSlot = 8;
            if (WinApi.GetAsyncKeyState(DefaultKeys.keyS9) != 0) currentSlot = 9;
        }



        private bool IsWhitelistedLeft()
        {
            switch (currentSlot)
            {
                case 1: return tgLeft.Checked && slotL1.Checked; /* if current slot = 1, it'll check if tgLeft AND slotL1 is checked, if not, slot is considered unwhitelisted */
                case 2: return tgLeft.Checked && slotL2.Checked; /* if current slot = 2, it'll check if tgLeft AND slotL2 is checked, if not, slot is considered unwhitelisted */
                case 3: return tgLeft.Checked && slotL3.Checked;
                case 4: return tgLeft.Checked && slotL4.Checked;
                case 5: return tgLeft.Checked && slotL5.Checked; /* ........ */
                case 6: return tgLeft.Checked && slotL6.Checked;
                case 7: return tgLeft.Checked && slotL7.Checked;
                case 8: return tgLeft.Checked && slotL8.Checked;
                case 9: return tgLeft.Checked && slotL9.Checked;
            }
            return false;
        }

        private bool IsWhitelistedRight()
        {
            switch (currentSlot)
            {
                case 1: return tgRight.Checked && slotR1.Checked; /* if current slot = 1, it'll check if tgRight AND slotR1 is checked, if not, slot is considered unwhitelisted */
                case 2: return tgRight.Checked && slotR2.Checked; /* if current slot = 2, it'll check if tgRight AND slotR2 is checked, if not, slot is considered unwhitelisted */
                case 3: return tgRight.Checked && slotR3.Checked;
                case 4: return tgRight.Checked && slotR4.Checked;
                case 5: return tgRight.Checked && slotR5.Checked; /* ........ */
                case 6: return tgRight.Checked && slotR6.Checked;
                case 7: return tgRight.Checked && slotR7.Checked;
                case 8: return tgRight.Checked && slotR8.Checked;
                case 9: return tgRight.Checked && slotR9.Checked;
            }
            return false;
        }

        #endregion



        #region Randomisation

        private int randomisedCPSL = 10; /* setting a variable for the randomisation, that will be used for the average cps */
        private int randomisedCPSR = 10;
        private InputSimulator simulator;
        
        private async void Randomisation()
        {
            /* basic randomisation system */

            for (; ; ) /* will loop and never stop, until it breaks */
            {
                await Task.Delay(1000);

                int 

                /* randomises the int value in a range of -3, 3 */
                randomisedCPSL = rndSeed.Next((int)sldLeftCPS.Value - (int)colorSlider2.Value,
                                              (int)sldLeftCPS.Value + (int)colorSlider2.Value);

                randomisedCPSR = rndSeed.Next((int)sldRightCPS.Value - (int)colorSlider2.Value,
                                              (int)sldRightCPS.Value + (int)colorSlider2.Value);
            }

            
        }

        #endregion



        #region Left clicker

        private async void DoLeftClick()
        {
            //player2 = new SoundPlayer(audioFilePath2);
            for (; ; ) /* will loop and never stop, until it breaks */
            {
                await Task.Delay(1000 / (randomisedCPSR)); /* gets the delay interval for cps, 1000 / 10 (cps) for example will get 100 delay, 100 x 10 = 1000 (ms) ; 1000ms = 1 second. (basically average cps per second) */

                MCHelper.GetMinecraftWindow(); /* gets minecraft process */

                if ((cbMenus.Checked && !ClickerExtensionHandle.InMenu()) || !cbMenus.Checked) /* checks if "Disable in menu" checkbox is checked AND if you arent in menu ; OR if "Disable in menu" checkbox is unchecked without checking if u are in menus (that'll skip the checking if in menu part) */
                    LeftConds();
                



            }
        }

        private void LeftConds()
        {
            
            //SoundPlayer player2 = new SoundPlayer(audioFilePath2);

            if (IsWhitelistedLeft() && tgLeft.Checked)
            {
                if ((cbMenus.Checked && !ClickerExtensionHandle.InMenu()) || !cbMenus.Checked)
                {
                    if (cbShiftLeft.Checked && WinApi.GetAsyncKeyState(Keys.LShiftKey) != 0) return;

                    if ((!cbRMB.Checked && WinApi.GetAsyncKeyState(WinApi.VK_LBUTTON) < 0) || (cbRMB.Checked && MouseButtons == MouseButtons.Left))
                    {
                        if (!cbBBlocks.Checked)
                        {
                            //player2.Play(); // Reproduza o som antes de simular o clique
                            LeftClicker.SendMessageLeftClick();
                        }
                        else
                        {
                            //player2.Play(); // Reproduza o som antes de simular o clique
                            LeftClicker.SendMessageLeftClickBreakBlocks();
                        }
                    }
                }
            }
        }

        #endregion



        #region Right clicker

        private async void DoRightClick()
        {
            for (; ; )
            {
                /* same exact procedure as left clicker but for the right clicker :) */

                await Task.Delay(1000 / randomisedCPSR);

                MCHelper.GetMinecraftWindow();

                RightConds();
            }
        }

        private void RightConds()
        {
            if (IsWhitelistedRight() && tgRight.Checked)
            {
                if (cbShiftRight.Checked && WinApi.GetAsyncKeyState(Keys.LShiftKey) != 0) return;

                if (WinApi.GetAsyncKeyState(WinApi.VK_RBUTTON) < 0)
                {
                    //player2.Play(); // Reproduza o som antes de simular o clique
                    RightClicker.SendMessageRightClick();
                }
            }
        }

        #endregion




        #region Destruct

        private void pbDestruct_Click(object sender, EventArgs e)
        {
            /* super basic destruct */

            foreach (Control currentControl in Controls) /* for each Control that we get in Controls */
            {
                currentControl.Dispose(); /* dispose all Control that are in Conrols */
            }

            Task.Delay(1000).Wait();

            Dispose();
            Environment.Exit(0); /* exit */
        }

        #endregion
        bool bindingMode2 = true;
        private void tl_Click(object sender, EventArgs e)
        {
            bindingMode2 = true; // Ativa o modo de vinculação
            tl.Text = "[NONE]"; // Atualiza o texto do botão para indicar que estamos aguardando um clique ou tecla

            // Aguarde a entrada do usuário
            Task.Run(() =>
            {
                while (bindingMode2)
                {
                    // Verifique se ocorreu um clique de mouse
                    if ((GetAsyncKeyState((int)Keys.XButton1) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão lateral do mouse XButton1 pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tl.Text = "XButton1";
                            bindingMode2 = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.XButton2) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão lateral do mouse XButton2 pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tl.Text = "XButton2";
                            bindingMode2 = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.LButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão esquerdo do mouse (LButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tl.Text = "[NONE]";
                            bindingMode2 = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.RButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão direito do mouse (RButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tl.Text = "[NONE]";
                            bindingMode2 = false; // Saia do modo de vinculação
                        }));
                    }

                    Thread.Sleep(100); // Aguarde um curto período antes de verificar novamente
                }
            });

        }
        bool bindingMode3 = true;
        private void tr_Click(object sender, EventArgs e)
        {
            bindingMode3 = true; // Ativa o modo de vinculação
            tr.Text = "[NONE]"; // Atualiza o texto do botão para indicar que estamos aguardando um clique ou tecla

            // Aguarde a entrada do usuário
            Task.Run(() =>
            {
                while (bindingMode3)
                {
                    // Verifique se ocorreu um clique de mouse
                    if ((GetAsyncKeyState((int)Keys.XButton1) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão lateral do mouse XButton1 pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tr.Text = "XButton1";
                            bindingMode3 = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.XButton2) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão lateral do mouse XButton2 pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tr.Text = "XButton2";
                            bindingMode3 = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.LButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão esquerdo do mouse (LButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tr.Text = "[NONE]";
                            bindingMode3 = false; // Saia do modo de vinculação
                        }));
                    }
                    else if ((GetAsyncKeyState((int)Keys.RButton) & 0x8000) != 0)
                    {
                        Thread.Sleep(100);
                        // Botão direito do mouse (RButton) pressionado
                        this.Invoke((MethodInvoker)(() =>
                        {
                            tr.Text = "[NONE]";
                            bindingMode3 = false; // Saia do modo de vinculação
                        }));
                    }

                    Thread.Sleep(100); // Aguarde um curto período antes de verificar novamente
                }
            });

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            foreach (Control currentControl in Controls) /* for each Control that we get in Controls */
            {
                currentControl.Dispose(); /* dispose all Control that are in Conrols */
            }

            Task.Delay(100).Wait();

            Dispose();
            Environment.Exit(0); /* exit */
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            // Minimiza a janela principal
            this.WindowState = FormWindowState.Minimized;
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            //ReproduzirAudio();
        }

        private void colorSlider1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void colorSlider2_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
