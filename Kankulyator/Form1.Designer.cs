
namespace Kankulyator
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
            System.Windows.Forms.Button NavbarBtn;
            System.Windows.Forms.Button historyBtn;
            this.panelEkran = new System.Windows.Forms.Panel();
            this.amalTxt = new System.Windows.Forms.Label();
            this.ekranTxt = new System.Windows.Forms.Label();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.calculatorTxt = new System.Windows.Forms.Label();
            this.panelKlaviatura = new System.Windows.Forms.Panel();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.kopaytirishBtn = new System.Windows.Forms.Button();
            this.yopQavsBtn = new System.Windows.Forms.Button();
            this.Btn1x = new System.Windows.Forms.Button();
            this.ochQavsBtn = new System.Windows.Forms.Button();
            this.bolishBtn = new System.Windows.Forms.Button();
            this.ildizBtn = new System.Windows.Forms.Button();
            this.x2Btn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.ochirBtn = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.vergulBtn = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.negativBtn = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.tenglikBtn = new System.Windows.Forms.Button();
            this.ekranTxtBox = new System.Windows.Forms.TextBox();
            NavbarBtn = new System.Windows.Forms.Button();
            historyBtn = new System.Windows.Forms.Button();
            this.panelEkran.SuspendLayout();
            this.panelNavBar.SuspendLayout();
            this.panelKlaviatura.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavbarBtn
            // 
            NavbarBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            NavbarBtn.BackColor = System.Drawing.SystemColors.Window;
            NavbarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            NavbarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            NavbarBtn.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            NavbarBtn.Location = new System.Drawing.Point(3, 3);
            NavbarBtn.Name = "NavbarBtn";
            NavbarBtn.Size = new System.Drawing.Size(33, 36);
            NavbarBtn.TabIndex = 0;
            NavbarBtn.Text = "※";
            NavbarBtn.UseVisualStyleBackColor = false;
            NavbarBtn.Click += new System.EventHandler(this.NavbarBtn_Click);
            // 
            // historyBtn
            // 
            historyBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            historyBtn.BackColor = System.Drawing.SystemColors.Window;
            historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            historyBtn.Font = new System.Drawing.Font("Leelawadee", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            historyBtn.Location = new System.Drawing.Point(378, 3);
            historyBtn.Name = "historyBtn";
            historyBtn.Size = new System.Drawing.Size(35, 36);
            historyBtn.TabIndex = 2;
            historyBtn.Text = "©";
            historyBtn.UseVisualStyleBackColor = false;
            historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // panelEkran
            // 
            this.panelEkran.BackColor = System.Drawing.SystemColors.Control;
            this.panelEkran.Controls.Add(this.ekranTxtBox);
            this.panelEkran.Controls.Add(this.amalTxt);
            this.panelEkran.Controls.Add(this.panelNavBar);
            this.panelEkran.Location = new System.Drawing.Point(3, 4);
            this.panelEkran.Name = "panelEkran";
            this.panelEkran.Size = new System.Drawing.Size(425, 185);
            this.panelEkran.TabIndex = 0;
            // 
            // amalTxt
            // 
            this.amalTxt.AutoSize = true;
            this.amalTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amalTxt.Location = new System.Drawing.Point(17, 76);
            this.amalTxt.Name = "amalTxt";
            this.amalTxt.Size = new System.Drawing.Size(0, 25);
            this.amalTxt.TabIndex = 2;
            // 
            // ekranTxt
            // 
            this.ekranTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ekranTxt.AutoSize = true;
            this.ekranTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ekranTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ekranTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ekranTxt.Location = new System.Drawing.Point(259, 0);
            this.ekranTxt.Name = "ekranTxt";
            this.ekranTxt.Size = new System.Drawing.Size(41, 44);
            this.ekranTxt.TabIndex = 1;
            this.ekranTxt.Text = "0";
            this.ekranTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ekranTxt.Click += new System.EventHandler(this.ekranTxt_Click);
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panelNavBar.Controls.Add(historyBtn);
            this.panelNavBar.Controls.Add(this.calculatorTxt);
            this.panelNavBar.Controls.Add(this.ekranTxt);
            this.panelNavBar.Controls.Add(NavbarBtn);
            this.panelNavBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelNavBar.Location = new System.Drawing.Point(3, 3);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(419, 44);
            this.panelNavBar.TabIndex = 0;
            // 
            // calculatorTxt
            // 
            this.calculatorTxt.AutoSize = true;
            this.calculatorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorTxt.Location = new System.Drawing.Point(71, 7);
            this.calculatorTxt.Name = "calculatorTxt";
            this.calculatorTxt.Size = new System.Drawing.Size(154, 32);
            this.calculatorTxt.TabIndex = 1;
            this.calculatorTxt.Text = "Calculator";
            // 
            // panelKlaviatura
            // 
            this.panelKlaviatura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelKlaviatura.Controls.Add(this.plusBtn);
            this.panelKlaviatura.Controls.Add(this.minusBtn);
            this.panelKlaviatura.Controls.Add(this.kopaytirishBtn);
            this.panelKlaviatura.Controls.Add(this.yopQavsBtn);
            this.panelKlaviatura.Controls.Add(this.Btn1x);
            this.panelKlaviatura.Controls.Add(this.ochQavsBtn);
            this.panelKlaviatura.Controls.Add(this.bolishBtn);
            this.panelKlaviatura.Controls.Add(this.ildizBtn);
            this.panelKlaviatura.Controls.Add(this.x2Btn);
            this.panelKlaviatura.Controls.Add(this.cBtn);
            this.panelKlaviatura.Controls.Add(this.ochirBtn);
            this.panelKlaviatura.Controls.Add(this.Btn2);
            this.panelKlaviatura.Controls.Add(this.Btn3);
            this.panelKlaviatura.Controls.Add(this.Btn6);
            this.panelKlaviatura.Controls.Add(this.Btn9);
            this.panelKlaviatura.Controls.Add(this.Btn5);
            this.panelKlaviatura.Controls.Add(this.Btn8);
            this.panelKlaviatura.Controls.Add(this.Btn4);
            this.panelKlaviatura.Controls.Add(this.Btn7);
            this.panelKlaviatura.Controls.Add(this.vergulBtn);
            this.panelKlaviatura.Controls.Add(this.Btn0);
            this.panelKlaviatura.Controls.Add(this.negativBtn);
            this.panelKlaviatura.Controls.Add(this.Btn1);
            this.panelKlaviatura.Controls.Add(this.tenglikBtn);
            this.panelKlaviatura.Location = new System.Drawing.Point(3, 195);
            this.panelKlaviatura.Name = "panelKlaviatura";
            this.panelKlaviatura.Size = new System.Drawing.Size(425, 432);
            this.panelKlaviatura.TabIndex = 1;
            // 
            // plusBtn
            // 
            this.plusBtn.BackColor = System.Drawing.SystemColors.Window;
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(309, 293);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(107, 61);
            this.plusBtn.TabIndex = 26;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.BackColor = System.Drawing.SystemColors.Window;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBtn.Location = new System.Drawing.Point(309, 226);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(107, 61);
            this.minusBtn.TabIndex = 25;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // kopaytirishBtn
            // 
            this.kopaytirishBtn.BackColor = System.Drawing.SystemColors.Window;
            this.kopaytirishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kopaytirishBtn.Location = new System.Drawing.Point(309, 159);
            this.kopaytirishBtn.Name = "kopaytirishBtn";
            this.kopaytirishBtn.Size = new System.Drawing.Size(107, 61);
            this.kopaytirishBtn.TabIndex = 24;
            this.kopaytirishBtn.Text = "×";
            this.kopaytirishBtn.UseVisualStyleBackColor = false;
            this.kopaytirishBtn.Click += new System.EventHandler(this.kopaytirishBtn_Click);
            // 
            // yopQavsBtn
            // 
            this.yopQavsBtn.BackColor = System.Drawing.SystemColors.Window;
            this.yopQavsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yopQavsBtn.Location = new System.Drawing.Point(209, 25);
            this.yopQavsBtn.Name = "yopQavsBtn";
            this.yopQavsBtn.Size = new System.Drawing.Size(94, 61);
            this.yopQavsBtn.TabIndex = 8;
            this.yopQavsBtn.Text = ")";
            this.yopQavsBtn.UseVisualStyleBackColor = false;
            this.yopQavsBtn.Click += new System.EventHandler(this.factorialBtn_Click);
            // 
            // Btn1x
            // 
            this.Btn1x.BackColor = System.Drawing.SystemColors.Window;
            this.Btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn1x.Location = new System.Drawing.Point(209, 92);
            this.Btn1x.Name = "Btn1x";
            this.Btn1x.Size = new System.Drawing.Size(94, 61);
            this.Btn1x.TabIndex = 22;
            this.Btn1x.Text = "1/x";
            this.Btn1x.UseVisualStyleBackColor = false;
            this.Btn1x.Click += new System.EventHandler(this.Btn1x_Click);
            // 
            // ochQavsBtn
            // 
            this.ochQavsBtn.BackColor = System.Drawing.SystemColors.Window;
            this.ochQavsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ochQavsBtn.Location = new System.Drawing.Point(109, 25);
            this.ochQavsBtn.Name = "ochQavsBtn";
            this.ochQavsBtn.Size = new System.Drawing.Size(94, 61);
            this.ochQavsBtn.TabIndex = 11;
            this.ochQavsBtn.Text = "(";
            this.ochQavsBtn.UseVisualStyleBackColor = false;
            this.ochQavsBtn.Click += new System.EventHandler(this.foizBtn_Click);
            // 
            // bolishBtn
            // 
            this.bolishBtn.BackColor = System.Drawing.SystemColors.Window;
            this.bolishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bolishBtn.Location = new System.Drawing.Point(309, 92);
            this.bolishBtn.Name = "bolishBtn";
            this.bolishBtn.Size = new System.Drawing.Size(107, 61);
            this.bolishBtn.TabIndex = 23;
            this.bolishBtn.Text = "÷";
            this.bolishBtn.UseVisualStyleBackColor = false;
            this.bolishBtn.Click += new System.EventHandler(this.bolishBtn_Click);
            // 
            // ildizBtn
            // 
            this.ildizBtn.BackColor = System.Drawing.SystemColors.Window;
            this.ildizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ildizBtn.Location = new System.Drawing.Point(9, 92);
            this.ildizBtn.Name = "ildizBtn";
            this.ildizBtn.Size = new System.Drawing.Size(94, 61);
            this.ildizBtn.TabIndex = 21;
            this.ildizBtn.Text = "√x";
            this.ildizBtn.UseVisualStyleBackColor = false;
            this.ildizBtn.Click += new System.EventHandler(this.ildizBtn_Click);
            // 
            // x2Btn
            // 
            this.x2Btn.BackColor = System.Drawing.SystemColors.Window;
            this.x2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2Btn.Location = new System.Drawing.Point(109, 92);
            this.x2Btn.Name = "x2Btn";
            this.x2Btn.Size = new System.Drawing.Size(94, 61);
            this.x2Btn.TabIndex = 20;
            this.x2Btn.Text = "x^2";
            this.x2Btn.UseVisualStyleBackColor = false;
            this.x2Btn.Click += new System.EventHandler(this.x2Btn_Click);
            // 
            // cBtn
            // 
            this.cBtn.BackColor = System.Drawing.SystemColors.Window;
            this.cBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBtn.Location = new System.Drawing.Point(9, 25);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(94, 61);
            this.cBtn.TabIndex = 19;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = false;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // ochirBtn
            // 
            this.ochirBtn.BackColor = System.Drawing.SystemColors.Window;
            this.ochirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ochirBtn.Location = new System.Drawing.Point(309, 25);
            this.ochirBtn.Name = "ochirBtn";
            this.ochirBtn.Size = new System.Drawing.Size(107, 61);
            this.ochirBtn.TabIndex = 18;
            this.ochirBtn.Text = "«";
            this.ochirBtn.UseVisualStyleBackColor = false;
            this.ochirBtn.Click += new System.EventHandler(this.ochirBtn_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.SystemColors.Window;
            this.Btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn2.Location = new System.Drawing.Point(109, 293);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(94, 61);
            this.Btn2.TabIndex = 17;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.SystemColors.Window;
            this.Btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn3.Location = new System.Drawing.Point(209, 293);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(94, 61);
            this.Btn3.TabIndex = 16;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.SystemColors.Window;
            this.Btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn6.Location = new System.Drawing.Point(209, 226);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(94, 61);
            this.Btn6.TabIndex = 15;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.Btn6_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.SystemColors.Window;
            this.Btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn9.Location = new System.Drawing.Point(209, 159);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(94, 61);
            this.Btn9.TabIndex = 14;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.Btn9_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.SystemColors.Window;
            this.Btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn5.Location = new System.Drawing.Point(109, 226);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(94, 61);
            this.Btn5.TabIndex = 13;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.Btn5_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.SystemColors.Window;
            this.Btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn8.Location = new System.Drawing.Point(109, 159);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(94, 61);
            this.Btn8.TabIndex = 12;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.Btn8_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.SystemColors.Window;
            this.Btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn4.Location = new System.Drawing.Point(9, 226);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(94, 61);
            this.Btn4.TabIndex = 10;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.SystemColors.Window;
            this.Btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn7.Location = new System.Drawing.Point(9, 159);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(94, 61);
            this.Btn7.TabIndex = 9;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.Btn7_Click);
            // 
            // vergulBtn
            // 
            this.vergulBtn.BackColor = System.Drawing.SystemColors.Window;
            this.vergulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vergulBtn.Location = new System.Drawing.Point(209, 360);
            this.vergulBtn.Name = "vergulBtn";
            this.vergulBtn.Size = new System.Drawing.Size(94, 61);
            this.vergulBtn.TabIndex = 7;
            this.vergulBtn.Text = ",";
            this.vergulBtn.UseVisualStyleBackColor = false;
            this.vergulBtn.Click += new System.EventHandler(this.vergulBtn_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.SystemColors.Window;
            this.Btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn0.Location = new System.Drawing.Point(109, 360);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(94, 61);
            this.Btn0.TabIndex = 6;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.Btn0_Click);
            // 
            // negativBtn
            // 
            this.negativBtn.BackColor = System.Drawing.SystemColors.Window;
            this.negativBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.negativBtn.Location = new System.Drawing.Point(9, 360);
            this.negativBtn.Name = "negativBtn";
            this.negativBtn.Size = new System.Drawing.Size(94, 61);
            this.negativBtn.TabIndex = 5;
            this.negativBtn.Text = "±";
            this.negativBtn.UseVisualStyleBackColor = false;
            this.negativBtn.Click += new System.EventHandler(this.negativBtn_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.SystemColors.Window;
            this.Btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn1.Location = new System.Drawing.Point(9, 293);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(94, 61);
            this.Btn1.TabIndex = 4;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // tenglikBtn
            // 
            this.tenglikBtn.BackColor = System.Drawing.SystemColors.Window;
            this.tenglikBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tenglikBtn.Location = new System.Drawing.Point(309, 360);
            this.tenglikBtn.Name = "tenglikBtn";
            this.tenglikBtn.Size = new System.Drawing.Size(107, 61);
            this.tenglikBtn.TabIndex = 3;
            this.tenglikBtn.Text = "=";
            this.tenglikBtn.UseVisualStyleBackColor = false;
            this.tenglikBtn.Click += new System.EventHandler(this.tenglikBtn_Click);
            // 
            // ekranTxtBox
            // 
            this.ekranTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ekranTxtBox.Location = new System.Drawing.Point(9, 126);
            this.ekranTxtBox.Multiline = true;
            this.ekranTxtBox.Name = "ekranTxtBox";
            this.ekranTxtBox.Size = new System.Drawing.Size(407, 47);
            this.ekranTxtBox.TabIndex = 3;
            this.ekranTxtBox.TextChanged += new System.EventHandler(this.ekranTxtBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 628);
            this.Controls.Add(this.panelKlaviatura);
            this.Controls.Add(this.panelEkran);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEkran.ResumeLayout(false);
            this.panelEkran.PerformLayout();
            this.panelNavBar.ResumeLayout(false);
            this.panelNavBar.PerformLayout();
            this.panelKlaviatura.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEkran;
        private System.Windows.Forms.Panel panelKlaviatura;
        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Label calculatorTxt;
        private System.Windows.Forms.Label ekranTxt;
        private System.Windows.Forms.Label amalTxt;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button kopaytirishBtn;
        private System.Windows.Forms.Button bolishBtn;
        private System.Windows.Forms.Button Btn1x;
        private System.Windows.Forms.Button ildizBtn;
        private System.Windows.Forms.Button x2Btn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button ochirBtn;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button ochQavsBtn;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button yopQavsBtn;
        private System.Windows.Forms.Button vergulBtn;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button negativBtn;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button tenglikBtn;
        private System.Windows.Forms.TextBox ekranTxtBox;
    }
}

