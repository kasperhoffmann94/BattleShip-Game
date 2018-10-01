namespace BattleShip_Game
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
            this.components = new System.ComponentModel.Container();
            this.playerScore = new System.Windows.Forms.Label();
            this.enemyScore = new System.Windows.Forms.Label();
            this.enemyMoves = new System.Windows.Forms.Label();
            this.roundsText = new System.Windows.Forms.Label();
            this.helpText = new System.Windows.Forms.Label();
            this.enemyLocationList = new System.Windows.Forms.ComboBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.w1 = new System.Windows.Forms.Button();
            this.w2 = new System.Windows.Forms.Button();
            this.w3 = new System.Windows.Forms.Button();
            this.w4 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x3 = new System.Windows.Forms.Button();
            this.x4 = new System.Windows.Forms.Button();
            this.y1 = new System.Windows.Forms.Button();
            this.y2 = new System.Windows.Forms.Button();
            this.y3 = new System.Windows.Forms.Button();
            this.y4 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.Button();
            this.z2 = new System.Windows.Forms.Button();
            this.z3 = new System.Windows.Forms.Button();
            this.z4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.d4 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.c4 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.d3 = new System.Windows.Forms.Button();
            this.enemyPlayTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyPositionPicker = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.Location = new System.Drawing.Point(370, 110);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(38, 25);
            this.playerScore.TabIndex = 0;
            this.playerScore.Text = "00";
            // 
            // enemyScore
            // 
            this.enemyScore.AutoSize = true;
            this.enemyScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyScore.Location = new System.Drawing.Point(897, 110);
            this.enemyScore.Name = "enemyScore";
            this.enemyScore.Size = new System.Drawing.Size(38, 25);
            this.enemyScore.TabIndex = 1;
            this.enemyScore.Text = "00";
            // 
            // enemyMoves
            // 
            this.enemyMoves.AutoSize = true;
            this.enemyMoves.BackColor = System.Drawing.Color.Transparent;
            this.enemyMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyMoves.ForeColor = System.Drawing.Color.White;
            this.enemyMoves.Location = new System.Drawing.Point(884, 36);
            this.enemyMoves.Name = "enemyMoves";
            this.enemyMoves.Size = new System.Drawing.Size(40, 25);
            this.enemyMoves.TabIndex = 2;
            this.enemyMoves.Text = "A1";
            // 
            // roundsText
            // 
            this.roundsText.AutoSize = true;
            this.roundsText.BackColor = System.Drawing.Color.Transparent;
            this.roundsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsText.ForeColor = System.Drawing.Color.White;
            this.roundsText.Location = new System.Drawing.Point(505, 144);
            this.roundsText.Name = "roundsText";
            this.roundsText.Size = new System.Drawing.Size(71, 20);
            this.roundsText.TabIndex = 3;
            this.roundsText.Text = "Rounds";
            // 
            // helpText
            // 
            this.helpText.AutoSize = true;
            this.helpText.BackColor = System.Drawing.Color.Transparent;
            this.helpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpText.ForeColor = System.Drawing.Color.LightGreen;
            this.helpText.Location = new System.Drawing.Point(95, 534);
            this.helpText.Name = "helpText";
            this.helpText.Size = new System.Drawing.Size(285, 15);
            this.helpText.TabIndex = 4;
            this.helpText.Text = "1) Click on 3 different buttons above to start";
            // 
            // enemyLocationList
            // 
            this.enemyLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enemyLocationList.DropDownWidth = 95;
            this.enemyLocationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyLocationList.FormattingEnabled = true;
            this.enemyLocationList.Location = new System.Drawing.Point(188, 31);
            this.enemyLocationList.Name = "enemyLocationList";
            this.enemyLocationList.Size = new System.Drawing.Size(82, 28);
            this.enemyLocationList.TabIndex = 5;
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(300, 25);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(80, 40);
            this.attackButton.TabIndex = 6;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.attackEnemyPosition);
            // 
            // w1
            // 
            this.w1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.w1.Location = new System.Drawing.Point(108, 230);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(75, 55);
            this.w1.TabIndex = 7;
            this.w1.Text = "W1";
            this.w1.UseVisualStyleBackColor = true;
            this.w1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w2
            // 
            this.w2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.w2.Location = new System.Drawing.Point(195, 230);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(75, 55);
            this.w2.TabIndex = 8;
            this.w2.Text = "W2";
            this.w2.UseVisualStyleBackColor = true;
            this.w2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w3
            // 
            this.w3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.w3.Location = new System.Drawing.Point(290, 230);
            this.w3.Name = "w3";
            this.w3.Size = new System.Drawing.Size(75, 55);
            this.w3.TabIndex = 9;
            this.w3.Text = "W3";
            this.w3.UseVisualStyleBackColor = true;
            this.w3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // w4
            // 
            this.w4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.w4.Location = new System.Drawing.Point(384, 230);
            this.w4.Name = "w4";
            this.w4.Size = new System.Drawing.Size(75, 55);
            this.w4.TabIndex = 10;
            this.w4.Text = "W4";
            this.w4.UseVisualStyleBackColor = true;
            this.w4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x1
            // 
            this.x1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.x1.Location = new System.Drawing.Point(108, 308);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(75, 55);
            this.x1.TabIndex = 11;
            this.x1.Text = "X1";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x2
            // 
            this.x2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.x2.Location = new System.Drawing.Point(195, 308);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(75, 55);
            this.x2.TabIndex = 12;
            this.x2.Text = "X2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x3
            // 
            this.x3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.x3.Location = new System.Drawing.Point(290, 308);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(75, 55);
            this.x3.TabIndex = 13;
            this.x3.Text = "X3";
            this.x3.UseVisualStyleBackColor = true;
            this.x3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // x4
            // 
            this.x4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.x4.Location = new System.Drawing.Point(384, 308);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(75, 55);
            this.x4.TabIndex = 14;
            this.x4.Text = "X4";
            this.x4.UseVisualStyleBackColor = true;
            this.x4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y1
            // 
            this.y1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.y1.Location = new System.Drawing.Point(108, 384);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(75, 55);
            this.y1.TabIndex = 15;
            this.y1.Text = "Y1";
            this.y1.UseVisualStyleBackColor = true;
            this.y1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y2
            // 
            this.y2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.y2.Location = new System.Drawing.Point(195, 384);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(75, 55);
            this.y2.TabIndex = 16;
            this.y2.Text = "Y2";
            this.y2.UseVisualStyleBackColor = true;
            this.y2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y3
            // 
            this.y3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.y3.Location = new System.Drawing.Point(290, 384);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(75, 55);
            this.y3.TabIndex = 17;
            this.y3.Text = "Y3";
            this.y3.UseVisualStyleBackColor = true;
            this.y3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // y4
            // 
            this.y4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.y4.Location = new System.Drawing.Point(384, 384);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(75, 55);
            this.y4.TabIndex = 18;
            this.y4.Text = "Y4";
            this.y4.UseVisualStyleBackColor = true;
            this.y4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z1
            // 
            this.z1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.z1.Location = new System.Drawing.Point(108, 463);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(75, 55);
            this.z1.TabIndex = 19;
            this.z1.Text = "Z1";
            this.z1.UseVisualStyleBackColor = true;
            this.z1.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z2
            // 
            this.z2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.z2.Location = new System.Drawing.Point(195, 463);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(75, 55);
            this.z2.TabIndex = 20;
            this.z2.Text = "Z2";
            this.z2.UseVisualStyleBackColor = true;
            this.z2.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z3
            // 
            this.z3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.z3.Location = new System.Drawing.Point(290, 463);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(75, 55);
            this.z3.TabIndex = 21;
            this.z3.Text = "Z3";
            this.z3.UseVisualStyleBackColor = true;
            this.z3.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // z4
            // 
            this.z4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.z4.Location = new System.Drawing.Point(384, 463);
            this.z4.Name = "z4";
            this.z4.Size = new System.Drawing.Size(75, 55);
            this.z4.TabIndex = 22;
            this.z4.Text = "Z4";
            this.z4.UseVisualStyleBackColor = true;
            this.z4.Click += new System.EventHandler(this.playerPicksPosition);
            // 
            // a1
            // 
            this.a1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.a1.Location = new System.Drawing.Point(603, 230);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 55);
            this.a1.TabIndex = 23;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.b1.Location = new System.Drawing.Point(603, 308);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 55);
            this.b1.TabIndex = 24;
            this.b1.Text = "B1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.c1.Location = new System.Drawing.Point(603, 384);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 55);
            this.c1.TabIndex = 25;
            this.c1.Text = "C1";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.d1.Location = new System.Drawing.Point(603, 463);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(75, 55);
            this.d1.TabIndex = 26;
            this.d1.Text = "D1";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.c2.Location = new System.Drawing.Point(697, 384);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 55);
            this.c2.TabIndex = 27;
            this.c2.Text = "C2";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.b3.Location = new System.Drawing.Point(789, 308);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 55);
            this.b3.TabIndex = 28;
            this.b3.Text = "B3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // a4
            // 
            this.a4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.a4.Location = new System.Drawing.Point(880, 230);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(75, 55);
            this.a4.TabIndex = 29;
            this.a4.Text = "A4";
            this.a4.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.b2.Location = new System.Drawing.Point(697, 308);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 55);
            this.b2.TabIndex = 30;
            this.b2.Text = "B2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.c3.Location = new System.Drawing.Point(789, 384);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 55);
            this.c3.TabIndex = 31;
            this.c3.Text = "C3";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // d4
            // 
            this.d4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.d4.Location = new System.Drawing.Point(880, 463);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 55);
            this.d4.TabIndex = 32;
            this.d4.Text = "D4";
            this.d4.UseVisualStyleBackColor = true;
            // 
            // a2
            // 
            this.a2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.a2.Location = new System.Drawing.Point(697, 230);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 55);
            this.a2.TabIndex = 33;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            // 
            // a3
            // 
            this.a3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.a3.Location = new System.Drawing.Point(789, 230);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 55);
            this.a3.TabIndex = 34;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.b4.Location = new System.Drawing.Point(880, 308);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 55);
            this.b4.TabIndex = 35;
            this.b4.Text = "B4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // c4
            // 
            this.c4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.c4.Location = new System.Drawing.Point(880, 384);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(75, 55);
            this.c4.TabIndex = 36;
            this.c4.Text = "C4";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.d2.Location = new System.Drawing.Point(697, 463);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(75, 55);
            this.d2.TabIndex = 37;
            this.d2.Text = "D2";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d3
            // 
            this.d3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.d3.Location = new System.Drawing.Point(789, 463);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(75, 55);
            this.d3.TabIndex = 38;
            this.d3.Text = "D3";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // enemyPlayTimer
            // 
            this.enemyPlayTimer.Interval = 1000;
            this.enemyPlayTimer.Tick += new System.EventHandler(this.enemyAttackPlayer);
            // 
            // enemyPositionPicker
            // 
            this.enemyPositionPicker.Enabled = true;
            this.enemyPositionPicker.Interval = 500;
            this.enemyPositionPicker.Tick += new System.EventHandler(this.enemyPicksPositions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BattleShip_Game.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1065, 585);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.z4);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.w4);
            this.Controls.Add(this.w3);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.enemyLocationList);
            this.Controls.Add(this.helpText);
            this.Controls.Add(this.roundsText);
            this.Controls.Add(this.enemyMoves);
            this.Controls.Add(this.enemyScore);
            this.Controls.Add(this.playerScore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label enemyScore;
        private System.Windows.Forms.Label enemyMoves;
        private System.Windows.Forms.Label roundsText;
        private System.Windows.Forms.Label helpText;
        private System.Windows.Forms.ComboBox enemyLocationList;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button w1;
        private System.Windows.Forms.Button w2;
        private System.Windows.Forms.Button w3;
        private System.Windows.Forms.Button w4;
        private System.Windows.Forms.Button x1;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x3;
        private System.Windows.Forms.Button x4;
        private System.Windows.Forms.Button y1;
        private System.Windows.Forms.Button y2;
        private System.Windows.Forms.Button y3;
        private System.Windows.Forms.Button y4;
        private System.Windows.Forms.Button z1;
        private System.Windows.Forms.Button z2;
        private System.Windows.Forms.Button z3;
        private System.Windows.Forms.Button z4;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button c4;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button d3;
        private System.Windows.Forms.Timer enemyPlayTimer;
        private System.Windows.Forms.Timer enemyPositionPicker;
    }
}

