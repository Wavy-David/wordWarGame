namespace WordWarGame
{
    partial class GameExhibit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLine1 = new System.Windows.Forms.Panel();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.lbPlayerNum = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbInputStatusValue = new System.Windows.Forms.Label();
            this.pnlLine2 = new System.Windows.Forms.Panel();
            this.pnlLineAlphabet_Top = new System.Windows.Forms.Panel();
            this.pnlLineAlphabet_Left = new System.Windows.Forms.Panel();
            this.pnlLineAlphabet_Bottom = new System.Windows.Forms.Panel();
            this.pnlLineAlphabet_Right = new System.Windows.Forms.Panel();
            this.pnlAlphabet = new System.Windows.Forms.Panel();
            this.lb_Z = new System.Windows.Forms.Label();
            this.lb_Y = new System.Windows.Forms.Label();
            this.lb_X = new System.Windows.Forms.Label();
            this.lb_W = new System.Windows.Forms.Label();
            this.lb_V = new System.Windows.Forms.Label();
            this.lb_U = new System.Windows.Forms.Label();
            this.lb_T = new System.Windows.Forms.Label();
            this.lb_S = new System.Windows.Forms.Label();
            this.lb_R = new System.Windows.Forms.Label();
            this.lb_Q = new System.Windows.Forms.Label();
            this.lb_P = new System.Windows.Forms.Label();
            this.lb_O = new System.Windows.Forms.Label();
            this.lb_N = new System.Windows.Forms.Label();
            this.lb_M = new System.Windows.Forms.Label();
            this.lb_L = new System.Windows.Forms.Label();
            this.lb_K = new System.Windows.Forms.Label();
            this.lb_J = new System.Windows.Forms.Label();
            this.lb_i = new System.Windows.Forms.Label();
            this.lb_H = new System.Windows.Forms.Label();
            this.lb_G = new System.Windows.Forms.Label();
            this.lb_F = new System.Windows.Forms.Label();
            this.lb_E = new System.Windows.Forms.Label();
            this.lb_D = new System.Windows.Forms.Label();
            this.lb_C = new System.Windows.Forms.Label();
            this.lb_B = new System.Windows.Forms.Label();
            this.lb_A = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlScoreTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btEnd = new System.Windows.Forms.Button();
            this.btRetry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlAlphabet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pnlLine1);
            this.panel1.Controls.Add(this.lbPlayerName);
            this.panel1.Controls.Add(this.lbPlayerNum);
            this.panel1.Controls.Add(this.btSubmit);
            this.panel1.Controls.Add(this.tbWord);
            this.panel1.Location = new System.Drawing.Point(387, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 132);
            this.panel1.TabIndex = 0;
            // 
            // pnlLine1
            // 
            this.pnlLine1.BackColor = System.Drawing.Color.White;
            this.pnlLine1.Location = new System.Drawing.Point(33, 51);
            this.pnlLine1.Name = "pnlLine1";
            this.pnlLine1.Size = new System.Drawing.Size(368, 1);
            this.pnlLine1.TabIndex = 4;
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbPlayerName.Location = new System.Drawing.Point(170, 27);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(76, 17);
            this.lbPlayerName.TabIndex = 3;
            this.lbPlayerName.Text = "PlayerName";
            // 
            // lbPlayerNum
            // 
            this.lbPlayerNum.AutoSize = true;
            this.lbPlayerNum.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerNum.ForeColor = System.Drawing.Color.Black;
            this.lbPlayerNum.Location = new System.Drawing.Point(29, 27);
            this.lbPlayerNum.Name = "lbPlayerNum";
            this.lbPlayerNum.Size = new System.Drawing.Size(52, 17);
            this.lbPlayerNum.TabIndex = 2;
            this.lbPlayerNum.Text = "Player x";
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.Color.White;
            this.btSubmit.FlatAppearance.BorderSize = 0;
            this.btSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(474, 85);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 1;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbWord
            // 
            this.tbWord.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWord.Location = new System.Drawing.Point(33, 85);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(422, 23);
            this.tbWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(386, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(384, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input Status :";
            // 
            // lbInputStatusValue
            // 
            this.lbInputStatusValue.AutoSize = true;
            this.lbInputStatusValue.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInputStatusValue.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lbInputStatusValue.Location = new System.Drawing.Point(512, 217);
            this.lbInputStatusValue.Name = "lbInputStatusValue";
            this.lbInputStatusValue.Size = new System.Drawing.Size(90, 17);
            this.lbInputStatusValue.TabIndex = 5;
            this.lbInputStatusValue.Text = "Correct/Wrong";
            this.lbInputStatusValue.Visible = false;
            // 
            // pnlLine2
            // 
            this.pnlLine2.BackColor = System.Drawing.Color.White;
            this.pnlLine2.Location = new System.Drawing.Point(388, 245);
            this.pnlLine2.Name = "pnlLine2";
            this.pnlLine2.Size = new System.Drawing.Size(368, 1);
            this.pnlLine2.TabIndex = 5;
            // 
            // pnlLineAlphabet_Top
            // 
            this.pnlLineAlphabet_Top.BackColor = System.Drawing.Color.White;
            this.pnlLineAlphabet_Top.Location = new System.Drawing.Point(387, 304);
            this.pnlLineAlphabet_Top.Name = "pnlLineAlphabet_Top";
            this.pnlLineAlphabet_Top.Size = new System.Drawing.Size(562, 1);
            this.pnlLineAlphabet_Top.TabIndex = 6;
            // 
            // pnlLineAlphabet_Left
            // 
            this.pnlLineAlphabet_Left.BackColor = System.Drawing.Color.White;
            this.pnlLineAlphabet_Left.Location = new System.Drawing.Point(387, 304);
            this.pnlLineAlphabet_Left.Name = "pnlLineAlphabet_Left";
            this.pnlLineAlphabet_Left.Size = new System.Drawing.Size(1, 71);
            this.pnlLineAlphabet_Left.TabIndex = 7;
            // 
            // pnlLineAlphabet_Bottom
            // 
            this.pnlLineAlphabet_Bottom.BackColor = System.Drawing.Color.White;
            this.pnlLineAlphabet_Bottom.Location = new System.Drawing.Point(387, 375);
            this.pnlLineAlphabet_Bottom.Name = "pnlLineAlphabet_Bottom";
            this.pnlLineAlphabet_Bottom.Size = new System.Drawing.Size(562, 1);
            this.pnlLineAlphabet_Bottom.TabIndex = 8;
            // 
            // pnlLineAlphabet_Right
            // 
            this.pnlLineAlphabet_Right.BackColor = System.Drawing.Color.White;
            this.pnlLineAlphabet_Right.Location = new System.Drawing.Point(948, 304);
            this.pnlLineAlphabet_Right.Name = "pnlLineAlphabet_Right";
            this.pnlLineAlphabet_Right.Size = new System.Drawing.Size(1, 71);
            this.pnlLineAlphabet_Right.TabIndex = 9;
            // 
            // pnlAlphabet
            // 
            this.pnlAlphabet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlAlphabet.Controls.Add(this.lb_Z);
            this.pnlAlphabet.Controls.Add(this.lb_Y);
            this.pnlAlphabet.Controls.Add(this.lb_X);
            this.pnlAlphabet.Controls.Add(this.lb_W);
            this.pnlAlphabet.Controls.Add(this.lb_V);
            this.pnlAlphabet.Controls.Add(this.lb_U);
            this.pnlAlphabet.Controls.Add(this.lb_T);
            this.pnlAlphabet.Controls.Add(this.lb_S);
            this.pnlAlphabet.Controls.Add(this.lb_R);
            this.pnlAlphabet.Controls.Add(this.lb_Q);
            this.pnlAlphabet.Controls.Add(this.lb_P);
            this.pnlAlphabet.Controls.Add(this.lb_O);
            this.pnlAlphabet.Controls.Add(this.lb_N);
            this.pnlAlphabet.Controls.Add(this.lb_M);
            this.pnlAlphabet.Controls.Add(this.lb_L);
            this.pnlAlphabet.Controls.Add(this.lb_K);
            this.pnlAlphabet.Controls.Add(this.lb_J);
            this.pnlAlphabet.Controls.Add(this.lb_i);
            this.pnlAlphabet.Controls.Add(this.lb_H);
            this.pnlAlphabet.Controls.Add(this.lb_G);
            this.pnlAlphabet.Controls.Add(this.lb_F);
            this.pnlAlphabet.Controls.Add(this.lb_E);
            this.pnlAlphabet.Controls.Add(this.lb_D);
            this.pnlAlphabet.Controls.Add(this.lb_C);
            this.pnlAlphabet.Controls.Add(this.lb_B);
            this.pnlAlphabet.Controls.Add(this.lb_A);
            this.pnlAlphabet.Location = new System.Drawing.Point(386, 304);
            this.pnlAlphabet.Name = "pnlAlphabet";
            this.pnlAlphabet.Size = new System.Drawing.Size(563, 72);
            this.pnlAlphabet.TabIndex = 10;
            // 
            // lb_Z
            // 
            this.lb_Z.AutoSize = true;
            this.lb_Z.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Z.Location = new System.Drawing.Point(502, 31);
            this.lb_Z.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_Z.Name = "lb_Z";
            this.lb_Z.Size = new System.Drawing.Size(12, 13);
            this.lb_Z.TabIndex = 25;
            this.lb_Z.Text = "z";
            // 
            // lb_Y
            // 
            this.lb_Y.AutoSize = true;
            this.lb_Y.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Y.Location = new System.Drawing.Point(484, 31);
            this.lb_Y.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_Y.Name = "lb_Y";
            this.lb_Y.Size = new System.Drawing.Size(12, 13);
            this.lb_Y.TabIndex = 24;
            this.lb_Y.Text = "y";
            // 
            // lb_X
            // 
            this.lb_X.AutoSize = true;
            this.lb_X.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_X.Location = new System.Drawing.Point(466, 31);
            this.lb_X.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_X.Name = "lb_X";
            this.lb_X.Size = new System.Drawing.Size(12, 13);
            this.lb_X.TabIndex = 23;
            this.lb_X.Text = "x";
            // 
            // lb_W
            // 
            this.lb_W.AutoSize = true;
            this.lb_W.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_W.Location = new System.Drawing.Point(445, 31);
            this.lb_W.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_W.Name = "lb_W";
            this.lb_W.Size = new System.Drawing.Size(15, 13);
            this.lb_W.TabIndex = 22;
            this.lb_W.Text = "w";
            // 
            // lb_V
            // 
            this.lb_V.AutoSize = true;
            this.lb_V.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_V.Location = new System.Drawing.Point(426, 31);
            this.lb_V.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_V.Name = "lb_V";
            this.lb_V.Size = new System.Drawing.Size(13, 13);
            this.lb_V.TabIndex = 21;
            this.lb_V.Text = "v";
            // 
            // lb_U
            // 
            this.lb_U.AutoSize = true;
            this.lb_U.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_U.Location = new System.Drawing.Point(407, 31);
            this.lb_U.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_U.Name = "lb_U";
            this.lb_U.Size = new System.Drawing.Size(13, 13);
            this.lb_U.TabIndex = 20;
            this.lb_U.Text = "u";
            // 
            // lb_T
            // 
            this.lb_T.AutoSize = true;
            this.lb_T.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_T.Location = new System.Drawing.Point(391, 31);
            this.lb_T.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_T.Name = "lb_T";
            this.lb_T.Size = new System.Drawing.Size(10, 13);
            this.lb_T.TabIndex = 19;
            this.lb_T.Text = "t";
            // 
            // lb_S
            // 
            this.lb_S.AutoSize = true;
            this.lb_S.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_S.Location = new System.Drawing.Point(373, 31);
            this.lb_S.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_S.Name = "lb_S";
            this.lb_S.Size = new System.Drawing.Size(12, 13);
            this.lb_S.TabIndex = 18;
            this.lb_S.Text = "s";
            // 
            // lb_R
            // 
            this.lb_R.AutoSize = true;
            this.lb_R.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_R.Location = new System.Drawing.Point(357, 31);
            this.lb_R.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_R.Name = "lb_R";
            this.lb_R.Size = new System.Drawing.Size(10, 13);
            this.lb_R.TabIndex = 17;
            this.lb_R.Text = "r";
            // 
            // lb_Q
            // 
            this.lb_Q.AutoSize = true;
            this.lb_Q.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_Q.Location = new System.Drawing.Point(338, 31);
            this.lb_Q.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_Q.Name = "lb_Q";
            this.lb_Q.Size = new System.Drawing.Size(13, 13);
            this.lb_Q.TabIndex = 16;
            this.lb_Q.Text = "q";
            // 
            // lb_P
            // 
            this.lb_P.AutoSize = true;
            this.lb_P.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_P.Location = new System.Drawing.Point(319, 31);
            this.lb_P.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_P.Name = "lb_P";
            this.lb_P.Size = new System.Drawing.Size(13, 13);
            this.lb_P.TabIndex = 15;
            this.lb_P.Text = "p";
            // 
            // lb_O
            // 
            this.lb_O.AutoSize = true;
            this.lb_O.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_O.Location = new System.Drawing.Point(300, 31);
            this.lb_O.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_O.Name = "lb_O";
            this.lb_O.Size = new System.Drawing.Size(13, 13);
            this.lb_O.TabIndex = 14;
            this.lb_O.Text = "o";
            // 
            // lb_N
            // 
            this.lb_N.AutoSize = true;
            this.lb_N.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_N.Location = new System.Drawing.Point(281, 31);
            this.lb_N.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_N.Name = "lb_N";
            this.lb_N.Size = new System.Drawing.Size(13, 13);
            this.lb_N.TabIndex = 13;
            this.lb_N.Text = "n";
            // 
            // lb_M
            // 
            this.lb_M.AutoSize = true;
            this.lb_M.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_M.Location = new System.Drawing.Point(260, 31);
            this.lb_M.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_M.Name = "lb_M";
            this.lb_M.Size = new System.Drawing.Size(15, 13);
            this.lb_M.TabIndex = 12;
            this.lb_M.Text = "m";
            // 
            // lb_L
            // 
            this.lb_L.AutoSize = true;
            this.lb_L.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_L.Location = new System.Drawing.Point(241, 31);
            this.lb_L.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_L.Name = "lb_L";
            this.lb_L.Size = new System.Drawing.Size(13, 13);
            this.lb_L.TabIndex = 11;
            this.lb_L.Text = "L";
            // 
            // lb_K
            // 
            this.lb_K.AutoSize = true;
            this.lb_K.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_K.Location = new System.Drawing.Point(222, 31);
            this.lb_K.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_K.Name = "lb_K";
            this.lb_K.Size = new System.Drawing.Size(13, 13);
            this.lb_K.TabIndex = 10;
            this.lb_K.Text = "k";
            // 
            // lb_J
            // 
            this.lb_J.AutoSize = true;
            this.lb_J.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_J.Location = new System.Drawing.Point(207, 31);
            this.lb_J.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_J.Name = "lb_J";
            this.lb_J.Size = new System.Drawing.Size(9, 13);
            this.lb_J.TabIndex = 9;
            this.lb_J.Text = "j";
            // 
            // lb_i
            // 
            this.lb_i.AutoSize = true;
            this.lb_i.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_i.Location = new System.Drawing.Point(192, 31);
            this.lb_i.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_i.Name = "lb_i";
            this.lb_i.Size = new System.Drawing.Size(9, 13);
            this.lb_i.TabIndex = 8;
            this.lb_i.Text = "i";
            // 
            // lb_H
            // 
            this.lb_H.AutoSize = true;
            this.lb_H.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_H.Location = new System.Drawing.Point(173, 31);
            this.lb_H.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_H.Name = "lb_H";
            this.lb_H.Size = new System.Drawing.Size(13, 13);
            this.lb_H.TabIndex = 7;
            this.lb_H.Text = "h";
            // 
            // lb_G
            // 
            this.lb_G.AutoSize = true;
            this.lb_G.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_G.Location = new System.Drawing.Point(154, 31);
            this.lb_G.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_G.Name = "lb_G";
            this.lb_G.Size = new System.Drawing.Size(13, 13);
            this.lb_G.TabIndex = 6;
            this.lb_G.Text = "g";
            // 
            // lb_F
            // 
            this.lb_F.AutoSize = true;
            this.lb_F.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_F.Location = new System.Drawing.Point(138, 31);
            this.lb_F.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_F.Name = "lb_F";
            this.lb_F.Size = new System.Drawing.Size(10, 13);
            this.lb_F.TabIndex = 5;
            this.lb_F.Text = "f";
            // 
            // lb_E
            // 
            this.lb_E.AutoSize = true;
            this.lb_E.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_E.Location = new System.Drawing.Point(119, 31);
            this.lb_E.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_E.Name = "lb_E";
            this.lb_E.Size = new System.Drawing.Size(13, 13);
            this.lb_E.TabIndex = 4;
            this.lb_E.Text = "e";
            // 
            // lb_D
            // 
            this.lb_D.AutoSize = true;
            this.lb_D.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_D.Location = new System.Drawing.Point(100, 31);
            this.lb_D.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_D.Name = "lb_D";
            this.lb_D.Size = new System.Drawing.Size(13, 13);
            this.lb_D.TabIndex = 3;
            this.lb_D.Text = "d";
            // 
            // lb_C
            // 
            this.lb_C.AutoSize = true;
            this.lb_C.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_C.Location = new System.Drawing.Point(81, 31);
            this.lb_C.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_C.Name = "lb_C";
            this.lb_C.Size = new System.Drawing.Size(13, 13);
            this.lb_C.TabIndex = 2;
            this.lb_C.Text = "c";
            // 
            // lb_B
            // 
            this.lb_B.AutoSize = true;
            this.lb_B.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_B.Location = new System.Drawing.Point(62, 31);
            this.lb_B.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(13, 13);
            this.lb_B.TabIndex = 1;
            this.lb_B.Text = "b";
            // 
            // lb_A
            // 
            this.lb_A.AutoSize = true;
            this.lb_A.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_A.Location = new System.Drawing.Point(43, 31);
            this.lb_A.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(13, 13);
            this.lb_A.TabIndex = 0;
            this.lb_A.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(384, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Alphabet Status";
            // 
            // pnlScoreTable
            // 
            this.pnlScoreTable.AutoScroll = true;
            this.pnlScoreTable.Location = new System.Drawing.Point(388, 430);
            this.pnlScoreTable.Name = "pnlScoreTable";
            this.pnlScoreTable.Size = new System.Drawing.Size(563, 147);
            this.pnlScoreTable.TabIndex = 12;
            // 
            // btEnd
            // 
            this.btEnd.BackColor = System.Drawing.Color.White;
            this.btEnd.FlatAppearance.BorderSize = 0;
            this.btEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnd.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnd.Location = new System.Drawing.Point(876, 593);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(75, 23);
            this.btEnd.TabIndex = 5;
            this.btEnd.Text = "End";
            this.btEnd.UseVisualStyleBackColor = false;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // btRetry
            // 
            this.btRetry.BackColor = System.Drawing.Color.White;
            this.btRetry.FlatAppearance.BorderSize = 0;
            this.btRetry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btRetry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRetry.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetry.Location = new System.Drawing.Point(789, 593);
            this.btRetry.Name = "btRetry";
            this.btRetry.Size = new System.Drawing.Size(75, 23);
            this.btRetry.TabIndex = 13;
            this.btRetry.Text = "Restart";
            this.btRetry.UseVisualStyleBackColor = false;
            this.btRetry.Click += new System.EventHandler(this.btRetry_Click);
            // 
            // GameExhibit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.btRetry);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.pnlScoreTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlLineAlphabet_Right);
            this.Controls.Add(this.pnlLineAlphabet_Bottom);
            this.Controls.Add(this.pnlLineAlphabet_Left);
            this.Controls.Add(this.pnlLineAlphabet_Top);
            this.Controls.Add(this.pnlLine2);
            this.Controls.Add(this.lbInputStatusValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAlphabet);
            this.Location = new System.Drawing.Point(0, 54);
            this.MaximumSize = new System.Drawing.Size(1366, 714);
            this.MinimumSize = new System.Drawing.Size(1366, 714);
            this.Name = "GameExhibit";
            this.Size = new System.Drawing.Size(1366, 714);
            this.Load += new System.EventHandler(this.GameExhibit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameExhibit_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlAlphabet.ResumeLayout(false);
            this.pnlAlphabet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlLine1;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLine2;
        private System.Windows.Forms.Panel pnlLineAlphabet_Top;
        private System.Windows.Forms.Panel pnlLineAlphabet_Left;
        private System.Windows.Forms.Panel pnlLineAlphabet_Bottom;
        private System.Windows.Forms.Panel pnlLineAlphabet_Right;
        private System.Windows.Forms.Panel pnlAlphabet;
        private System.Windows.Forms.Label lb_Z;
        private System.Windows.Forms.Label lb_Y;
        private System.Windows.Forms.Label lb_X;
        private System.Windows.Forms.Label lb_W;
        private System.Windows.Forms.Label lb_V;
        private System.Windows.Forms.Label lb_U;
        private System.Windows.Forms.Label lb_T;
        private System.Windows.Forms.Label lb_S;
        private System.Windows.Forms.Label lb_R;
        private System.Windows.Forms.Label lb_Q;
        private System.Windows.Forms.Label lb_P;
        private System.Windows.Forms.Label lb_O;
        private System.Windows.Forms.Label lb_N;
        private System.Windows.Forms.Label lb_M;
        private System.Windows.Forms.Label lb_L;
        private System.Windows.Forms.Label lb_K;
        private System.Windows.Forms.Label lb_J;
        private System.Windows.Forms.Label lb_i;
        private System.Windows.Forms.Label lb_H;
        private System.Windows.Forms.Label lb_G;
        private System.Windows.Forms.Label lb_F;
        private System.Windows.Forms.Label lb_E;
        private System.Windows.Forms.Label lb_D;
        private System.Windows.Forms.Label lb_C;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.Button btRetry;
        public System.Windows.Forms.Label lbPlayerName;
        public System.Windows.Forms.Label lbPlayerNum;
        public System.Windows.Forms.Label lbInputStatusValue;
        public System.Windows.Forms.FlowLayoutPanel pnlScoreTable;
    }
}
