using static ReaLTaiizor.Drawing.Poison.PoisonPaint;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GithubClicker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            this.cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            this.cyberButton4 = new ReaLTaiizor.Controls.CyberButton();
            this.cyberButton5 = new ReaLTaiizor.Controls.CyberButton();
            this.dungeonTrackBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.cyberButton8 = new ReaLTaiizor.Controls.CyberButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.cyberButton7 = new ReaLTaiizor.Controls.CyberButton();
            this.cyberButton6 = new ReaLTaiizor.Controls.CyberButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonCheckBox4 = new ReaLTaiizor.Controls.RibbonCheckBox();
            this.ribbonCheckBox3 = new ReaLTaiizor.Controls.RibbonCheckBox();
            this.ribbonCheckBox2 = new ReaLTaiizor.Controls.RibbonCheckBox();
            this.ribbonCheckBox1 = new ReaLTaiizor.Controls.RibbonCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cyberButton1
            // 
            this.cyberButton1.Alpha = 20;
            this.cyberButton1.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton1.Background = true;
            this.cyberButton1.Background_WidthPen = 3F;
            this.cyberButton1.BackgroundPen = true;
            this.cyberButton1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton1.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton1.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton1.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton1.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton1.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton1.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton1.Effect_1 = true;
            this.cyberButton1.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton1.Effect_1_Transparency = 25;
            this.cyberButton1.Effect_2 = true;
            this.cyberButton1.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton1.Effect_2_Transparency = 20;
            this.cyberButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.cyberButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton1.Lighting = false;
            this.cyberButton1.LinearGradient_Background = false;
            this.cyberButton1.LinearGradientPen = false;
            this.cyberButton1.Location = new System.Drawing.Point(39, 264);
            this.cyberButton1.Name = "cyberButton1";
            this.cyberButton1.PenWidth = 15;
            this.cyberButton1.Rounding = true;
            this.cyberButton1.RoundingInt = 20;
            this.cyberButton1.Size = new System.Drawing.Size(163, 37);
            this.cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton1.TabIndex = 6;
            this.cyberButton1.Tag = "Cyber";
            this.cyberButton1.TextButton = "Auto Clicker";
            this.cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton1.Timer_Effect_1 = 5;
            this.cyberButton1.Timer_RGB = 300;
            this.cyberButton1.Click += new System.EventHandler(this.cyberButton1_Click);
            // 
            // cyberButton3
            // 
            this.cyberButton3.Alpha = 20;
            this.cyberButton3.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton3.Background = true;
            this.cyberButton3.Background_WidthPen = 3F;
            this.cyberButton3.BackgroundPen = true;
            this.cyberButton3.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton3.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton3.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton3.Effect_1 = true;
            this.cyberButton3.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton3.Effect_1_Transparency = 25;
            this.cyberButton3.Effect_2 = true;
            this.cyberButton3.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton3.Effect_2_Transparency = 20;
            this.cyberButton3.Font = new System.Drawing.Font("Arial", 10F);
            this.cyberButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton3.Lighting = false;
            this.cyberButton3.LinearGradient_Background = false;
            this.cyberButton3.LinearGradientPen = false;
            this.cyberButton3.Location = new System.Drawing.Point(231, 262);
            this.cyberButton3.Name = "cyberButton3";
            this.cyberButton3.PenWidth = 15;
            this.cyberButton3.Rounding = true;
            this.cyberButton3.RoundingInt = 20;
            this.cyberButton3.Size = new System.Drawing.Size(164, 39);
            this.cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton3.TabIndex = 8;
            this.cyberButton3.Tag = "Cyber";
            this.cyberButton3.TextButton = "Imput Key";
            this.cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton3.Timer_Effect_1 = 5;
            this.cyberButton3.Timer_RGB = 300;
            // 
            // cyberButton4
            // 
            this.cyberButton4.Alpha = 20;
            this.cyberButton4.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton4.Background = true;
            this.cyberButton4.Background_WidthPen = 3F;
            this.cyberButton4.BackgroundPen = true;
            this.cyberButton4.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton4.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton4.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton4.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton4.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton4.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton4.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton4.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton4.Effect_1 = true;
            this.cyberButton4.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton4.Effect_1_Transparency = 25;
            this.cyberButton4.Effect_2 = true;
            this.cyberButton4.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton4.Effect_2_Transparency = 20;
            this.cyberButton4.Font = new System.Drawing.Font("Arial", 10F);
            this.cyberButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton4.Lighting = false;
            this.cyberButton4.LinearGradient_Background = false;
            this.cyberButton4.LinearGradientPen = false;
            this.cyberButton4.Location = new System.Drawing.Point(424, 262);
            this.cyberButton4.Name = "cyberButton4";
            this.cyberButton4.PenWidth = 15;
            this.cyberButton4.Rounding = true;
            this.cyberButton4.RoundingInt = 20;
            this.cyberButton4.Size = new System.Drawing.Size(165, 39);
            this.cyberButton4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton4.TabIndex = 9;
            this.cyberButton4.Tag = "Cyber";
            this.cyberButton4.TextButton = "Anti AFK";
            this.cyberButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton4.Timer_Effect_1 = 5;
            this.cyberButton4.Timer_RGB = 300;
            // 
            // cyberButton5
            // 
            this.cyberButton5.Alpha = 20;
            this.cyberButton5.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton5.Background = true;
            this.cyberButton5.Background_WidthPen = 3F;
            this.cyberButton5.BackgroundPen = true;
            this.cyberButton5.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton5.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton5.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton5.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton5.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton5.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton5.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton5.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton5.Effect_1 = true;
            this.cyberButton5.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton5.Effect_1_Transparency = 25;
            this.cyberButton5.Effect_2 = true;
            this.cyberButton5.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton5.Effect_2_Transparency = 20;
            this.cyberButton5.Font = new System.Drawing.Font("Arial", 10F);
            this.cyberButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton5.Lighting = false;
            this.cyberButton5.LinearGradient_Background = false;
            this.cyberButton5.LinearGradientPen = false;
            this.cyberButton5.Location = new System.Drawing.Point(618, 262);
            this.cyberButton5.Name = "cyberButton5";
            this.cyberButton5.PenWidth = 15;
            this.cyberButton5.Rounding = true;
            this.cyberButton5.RoundingInt = 20;
            this.cyberButton5.Size = new System.Drawing.Size(165, 39);
            this.cyberButton5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton5.TabIndex = 16;
            this.cyberButton5.Tag = "Cyber";
            this.cyberButton5.TextButton = "Mods";
            this.cyberButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton5.Timer_Effect_1 = 5;
            this.cyberButton5.Timer_RGB = 300;
            // 
            // dungeonTrackBar1
            // 
            this.dungeonTrackBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dungeonTrackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dungeonTrackBar1.DrawValueString = false;
            this.dungeonTrackBar1.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.dungeonTrackBar1.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.dungeonTrackBar1.JumpToMouse = false;
            this.dungeonTrackBar1.Location = new System.Drawing.Point(32, 32);
            this.dungeonTrackBar1.Maximum = 10;
            this.dungeonTrackBar1.Minimum = 0;
            this.dungeonTrackBar1.MinimumSize = new System.Drawing.Size(40, 19);
            this.dungeonTrackBar1.Name = "dungeonTrackBar1";
            this.dungeonTrackBar1.Size = new System.Drawing.Size(78, 22);
            this.dungeonTrackBar1.TabIndex = 22;
            this.dungeonTrackBar1.Text = "dungeonTrackBar1";
            this.dungeonTrackBar1.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dungeonTrackBar1.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonTrackBar1.Value = 0;
            this.dungeonTrackBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.dungeonTrackBar1.ValueToSet = 0F;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.cyberButton8);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.cyberButton7);
            this.panel1.Controls.Add(this.cyberButton6);
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ribbonCheckBox4);
            this.panel1.Controls.Add(this.ribbonCheckBox3);
            this.panel1.Controls.Add(this.ribbonCheckBox2);
            this.panel1.Controls.Add(this.ribbonCheckBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dungeonTrackBar1);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 137);
            this.panel1.TabIndex = 23;
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton6.IconColor = System.Drawing.Color.Black;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(702, 11);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(93, 45);
            this.iconButton6.TabIndex = 26;
            this.iconButton6.Text = "        Self Delete";
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // cyberButton8
            // 
            this.cyberButton8.Alpha = 20;
            this.cyberButton8.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton8.Background = true;
            this.cyberButton8.Background_WidthPen = 3F;
            this.cyberButton8.BackgroundPen = true;
            this.cyberButton8.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton8.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton8.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton8.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton8.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton8.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton8.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton8.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton8.Effect_1 = true;
            this.cyberButton8.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton8.Effect_1_Transparency = 25;
            this.cyberButton8.Effect_2 = true;
            this.cyberButton8.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton8.Effect_2_Transparency = 20;
            this.cyberButton8.Font = new System.Drawing.Font("Arial", 9F);
            this.cyberButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton8.Lighting = false;
            this.cyberButton8.LinearGradient_Background = false;
            this.cyberButton8.LinearGradientPen = false;
            this.cyberButton8.Location = new System.Drawing.Point(303, 84);
            this.cyberButton8.Name = "cyberButton8";
            this.cyberButton8.PenWidth = 15;
            this.cyberButton8.Rounding = true;
            this.cyberButton8.RoundingInt = 20;
            this.cyberButton8.Size = new System.Drawing.Size(70, 18);
            this.cyberButton8.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton8.TabIndex = 35;
            this.cyberButton8.Tag = "Cyber";
            this.cyberButton8.TextButton = "[none]";
            this.cyberButton8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton8.Timer_Effect_1 = 5;
            this.cyberButton8.Timer_RGB = 300;
            // 
            // iconButton4
            // 
            this.iconButton4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 35;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(507, 84);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(93, 45);
            this.iconButton4.TabIndex = 24;
            this.iconButton4.Text = "        Youtube";
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // cyberButton7
            // 
            this.cyberButton7.Alpha = 20;
            this.cyberButton7.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton7.Background = true;
            this.cyberButton7.Background_WidthPen = 3F;
            this.cyberButton7.BackgroundPen = true;
            this.cyberButton7.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton7.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton7.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton7.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton7.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton7.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton7.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton7.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton7.Effect_1 = true;
            this.cyberButton7.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton7.Effect_1_Transparency = 25;
            this.cyberButton7.Effect_2 = true;
            this.cyberButton7.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton7.Effect_2_Transparency = 20;
            this.cyberButton7.Font = new System.Drawing.Font("Arial", 9F);
            this.cyberButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton7.Lighting = false;
            this.cyberButton7.LinearGradient_Background = false;
            this.cyberButton7.LinearGradientPen = false;
            this.cyberButton7.Location = new System.Drawing.Point(303, 56);
            this.cyberButton7.Name = "cyberButton7";
            this.cyberButton7.PenWidth = 15;
            this.cyberButton7.Rounding = true;
            this.cyberButton7.RoundingInt = 20;
            this.cyberButton7.Size = new System.Drawing.Size(70, 18);
            this.cyberButton7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton7.TabIndex = 34;
            this.cyberButton7.Tag = "Cyber";
            this.cyberButton7.TextButton = "[none]";
            this.cyberButton7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton7.Timer_Effect_1 = 5;
            this.cyberButton7.Timer_RGB = 300;
            // 
            // cyberButton6
            // 
            this.cyberButton6.Alpha = 20;
            this.cyberButton6.BackColor = System.Drawing.Color.Transparent;
            this.cyberButton6.Background = true;
            this.cyberButton6.Background_WidthPen = 3F;
            this.cyberButton6.BackgroundPen = true;
            this.cyberButton6.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton6.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton6.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton6.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton6.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton6.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.cyberButton6.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.cyberButton6.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.cyberButton6.Effect_1 = true;
            this.cyberButton6.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.cyberButton6.Effect_1_Transparency = 25;
            this.cyberButton6.Effect_2 = true;
            this.cyberButton6.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.cyberButton6.Effect_2_Transparency = 20;
            this.cyberButton6.Font = new System.Drawing.Font("Arial", 9F);
            this.cyberButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cyberButton6.Lighting = false;
            this.cyberButton6.LinearGradient_Background = false;
            this.cyberButton6.LinearGradientPen = false;
            this.cyberButton6.Location = new System.Drawing.Point(303, 32);
            this.cyberButton6.Name = "cyberButton6";
            this.cyberButton6.PenWidth = 15;
            this.cyberButton6.Rounding = true;
            this.cyberButton6.RoundingInt = 20;
            this.cyberButton6.Size = new System.Drawing.Size(70, 18);
            this.cyberButton6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.cyberButton6.TabIndex = 26;
            this.cyberButton6.Tag = "Cyber";
            this.cyberButton6.TextButton = "[none]";
            this.cyberButton6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cyberButton6.Timer_Effect_1 = 5;
            this.cyberButton6.Timer_RGB = 300;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Twitch;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 35;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(606, 84);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(93, 45);
            this.iconButton5.TabIndex = 25;
            this.iconButton5.Text = "        Twitch";
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Discord;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(705, 84);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(93, 45);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "            Discord";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(217, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Key do Pause";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(217, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Key do Pause";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(217, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Key to Close";
            // 
            // ribbonCheckBox4
            // 
            this.ribbonCheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox4.BaseColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox4.CheckBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(205)))));
            this.ribbonCheckBox4.CheckBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.ribbonCheckBox4.CheckBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(120)))), ((int)(((byte)(117)))));
            this.ribbonCheckBox4.CheckBorderColorB = System.Drawing.Color.WhiteSmoke;
            this.ribbonCheckBox4.Checked = false;
            this.ribbonCheckBox4.CheckedColor = System.Drawing.Color.Black;
            this.ribbonCheckBox4.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ribbonCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbonCheckBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ribbonCheckBox4.ForeColor = System.Drawing.Color.White;
            this.ribbonCheckBox4.Location = new System.Drawing.Point(32, 107);
            this.ribbonCheckBox4.Name = "ribbonCheckBox4";
            this.ribbonCheckBox4.Size = new System.Drawing.Size(103, 14);
            this.ribbonCheckBox4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ribbonCheckBox4.TabIndex = 30;
            this.ribbonCheckBox4.Text = "Sound 1";
            this.ribbonCheckBox4.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // ribbonCheckBox3
            // 
            this.ribbonCheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox3.BaseColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox3.CheckBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(205)))));
            this.ribbonCheckBox3.CheckBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.ribbonCheckBox3.CheckBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(120)))), ((int)(((byte)(117)))));
            this.ribbonCheckBox3.CheckBorderColorB = System.Drawing.Color.WhiteSmoke;
            this.ribbonCheckBox3.Checked = false;
            this.ribbonCheckBox3.CheckedColor = System.Drawing.Color.Black;
            this.ribbonCheckBox3.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ribbonCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbonCheckBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ribbonCheckBox3.ForeColor = System.Drawing.Color.White;
            this.ribbonCheckBox3.Location = new System.Drawing.Point(32, 90);
            this.ribbonCheckBox3.Name = "ribbonCheckBox3";
            this.ribbonCheckBox3.Size = new System.Drawing.Size(103, 14);
            this.ribbonCheckBox3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ribbonCheckBox3.TabIndex = 29;
            this.ribbonCheckBox3.Text = "Sound 1";
            this.ribbonCheckBox3.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // ribbonCheckBox2
            // 
            this.ribbonCheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox2.BaseColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox2.CheckBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(205)))));
            this.ribbonCheckBox2.CheckBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.ribbonCheckBox2.CheckBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(120)))), ((int)(((byte)(117)))));
            this.ribbonCheckBox2.CheckBorderColorB = System.Drawing.Color.WhiteSmoke;
            this.ribbonCheckBox2.Checked = false;
            this.ribbonCheckBox2.CheckedColor = System.Drawing.Color.Black;
            this.ribbonCheckBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ribbonCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbonCheckBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ribbonCheckBox2.ForeColor = System.Drawing.Color.White;
            this.ribbonCheckBox2.Location = new System.Drawing.Point(32, 56);
            this.ribbonCheckBox2.Name = "ribbonCheckBox2";
            this.ribbonCheckBox2.Size = new System.Drawing.Size(103, 14);
            this.ribbonCheckBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ribbonCheckBox2.TabIndex = 28;
            this.ribbonCheckBox2.Text = "Old Mouse";
            this.ribbonCheckBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // ribbonCheckBox1
            // 
            this.ribbonCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox1.BaseColor = System.Drawing.Color.Transparent;
            this.ribbonCheckBox1.CheckBackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(201)))), ((int)(((byte)(205)))));
            this.ribbonCheckBox1.CheckBackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(186)))), ((int)(((byte)(190)))));
            this.ribbonCheckBox1.CheckBorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(120)))), ((int)(((byte)(117)))));
            this.ribbonCheckBox1.CheckBorderColorB = System.Drawing.Color.WhiteSmoke;
            this.ribbonCheckBox1.Checked = false;
            this.ribbonCheckBox1.CheckedColor = System.Drawing.Color.Black;
            this.ribbonCheckBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ribbonCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ribbonCheckBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.ribbonCheckBox1.ForeColor = System.Drawing.Color.White;
            this.ribbonCheckBox1.Location = new System.Drawing.Point(32, 73);
            this.ribbonCheckBox1.Name = "ribbonCheckBox1";
            this.ribbonCheckBox1.Size = new System.Drawing.Size(103, 14);
            this.ribbonCheckBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.ribbonCheckBox1.TabIndex = 27;
            this.ribbonCheckBox1.Text = "Razer";
            this.ribbonCheckBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(28, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Sound Click";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.BackgroundImage = global::GithubClicker.Properties.Resources.p5;
            this.iconPictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 165;
            this.iconPictureBox5.Location = new System.Drawing.Point(618, 39);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(165, 219);
            this.iconPictureBox5.TabIndex = 15;
            this.iconPictureBox5.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.BackgroundImage = global::GithubClicker.Properties.Resources.p4;
            this.iconPictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 165;
            this.iconPictureBox4.Location = new System.Drawing.Point(424, 39);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(165, 219);
            this.iconPictureBox4.TabIndex = 3;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox3.BackgroundImage")));
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 164;
            this.iconPictureBox3.Location = new System.Drawing.Point(231, 39);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(164, 219);
            this.iconPictureBox3.TabIndex = 2;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::GithubClicker.Properties.Resources.p3;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 163;
            this.iconPictureBox1.InitialImage = null;
            this.iconPictureBox1.Location = new System.Drawing.Point(39, 39);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(163, 219);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(763, 1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(29, 29);
            this.iconButton2.TabIndex = 25;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 20;
            this.iconButton3.Location = new System.Drawing.Point(796, 1);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(29, 29);
            this.iconButton3.TabIndex = 24;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(822, 502);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cyberButton5);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.cyberButton4);
            this.Controls.Add(this.cyberButton3);
            this.Controls.Add(this.cyberButton1);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonafide";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private ReaLTaiizor.Controls.CyberButton cyberButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private ReaLTaiizor.Controls.DungeonTrackBar dungeonTrackBar1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Label label3;
        private ReaLTaiizor.Controls.RibbonCheckBox ribbonCheckBox1;
        private ReaLTaiizor.Controls.RibbonCheckBox ribbonCheckBox4;
        private ReaLTaiizor.Controls.RibbonCheckBox ribbonCheckBox3;
        private ReaLTaiizor.Controls.RibbonCheckBox ribbonCheckBox2;
        private Label label2;
        private Label label1;
        private Label label4;
        private ReaLTaiizor.Controls.CyberButton cyberButton8;
        private ReaLTaiizor.Controls.CyberButton cyberButton7;
        private ReaLTaiizor.Controls.CyberButton cyberButton6;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}