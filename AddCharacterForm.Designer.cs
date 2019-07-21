namespace DragonQuest
{
    partial class AddCharacterForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.MaxHPLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MaxMPLabel = new System.Windows.Forms.Label();
            this.AttackLabel = new System.Windows.Forms.Label();
            this.DefenceLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.MaxHPUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxMPUpDown = new System.Windows.Forms.NumericUpDown();
            this.AttackUpDown = new System.Windows.Forms.NumericUpDown();
            this.DefenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.SpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddCharacterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxHPUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMPUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(34, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(37, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "名前";
            // 
            // MaxHPLabel
            // 
            this.MaxHPLabel.AutoSize = true;
            this.MaxHPLabel.Location = new System.Drawing.Point(34, 86);
            this.MaxHPLabel.Name = "MaxHPLabel";
            this.MaxHPLabel.Size = new System.Drawing.Size(56, 15);
            this.MaxHPLabel.TabIndex = 1;
            this.MaxHPLabel.Text = "最大HP";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(102, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 22);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // MaxMPLabel
            // 
            this.MaxMPLabel.AutoSize = true;
            this.MaxMPLabel.Location = new System.Drawing.Point(34, 139);
            this.MaxMPLabel.Name = "MaxMPLabel";
            this.MaxMPLabel.Size = new System.Drawing.Size(57, 15);
            this.MaxMPLabel.TabIndex = 3;
            this.MaxMPLabel.Text = "最大MP";
            // 
            // AttackLabel
            // 
            this.AttackLabel.AutoSize = true;
            this.AttackLabel.Location = new System.Drawing.Point(34, 195);
            this.AttackLabel.Name = "AttackLabel";
            this.AttackLabel.Size = new System.Drawing.Size(52, 15);
            this.AttackLabel.TabIndex = 4;
            this.AttackLabel.Text = "攻撃力";
            // 
            // DefenceLabel
            // 
            this.DefenceLabel.AutoSize = true;
            this.DefenceLabel.Location = new System.Drawing.Point(34, 248);
            this.DefenceLabel.Name = "DefenceLabel";
            this.DefenceLabel.Size = new System.Drawing.Size(52, 15);
            this.DefenceLabel.TabIndex = 5;
            this.DefenceLabel.Text = "防御力";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(34, 307);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(47, 15);
            this.SpeedLabel.TabIndex = 6;
            this.SpeedLabel.Text = "素早さ";
            // 
            // MaxHPUpDown
            // 
            this.MaxHPUpDown.Location = new System.Drawing.Point(102, 84);
            this.MaxHPUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MaxHPUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MaxHPUpDown.Name = "MaxHPUpDown";
            this.MaxHPUpDown.Size = new System.Drawing.Size(120, 22);
            this.MaxHPUpDown.TabIndex = 7;
            this.MaxHPUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.MaxHPUpDown.ValueChanged += new System.EventHandler(this.MaxHPUpDown_ValueChanged);
            // 
            // MaxMPUpDown
            // 
            this.MaxMPUpDown.Location = new System.Drawing.Point(102, 137);
            this.MaxMPUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.MaxMPUpDown.Name = "MaxMPUpDown";
            this.MaxMPUpDown.Size = new System.Drawing.Size(120, 22);
            this.MaxMPUpDown.TabIndex = 8;
            this.MaxMPUpDown.ValueChanged += new System.EventHandler(this.MaxMPUpDown_ValueChanged);
            // 
            // AttackUpDown
            // 
            this.AttackUpDown.Location = new System.Drawing.Point(102, 193);
            this.AttackUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.AttackUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AttackUpDown.Name = "AttackUpDown";
            this.AttackUpDown.Size = new System.Drawing.Size(120, 22);
            this.AttackUpDown.TabIndex = 9;
            this.AttackUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AttackUpDown.ValueChanged += new System.EventHandler(this.AttackUpDown_ValueChanged);
            // 
            // DefenceUpDown
            // 
            this.DefenceUpDown.Location = new System.Drawing.Point(102, 246);
            this.DefenceUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.DefenceUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefenceUpDown.Name = "DefenceUpDown";
            this.DefenceUpDown.Size = new System.Drawing.Size(120, 22);
            this.DefenceUpDown.TabIndex = 10;
            this.DefenceUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DefenceUpDown.ValueChanged += new System.EventHandler(this.DefenceUpDown_ValueChanged);
            // 
            // SpeedUpDown
            // 
            this.SpeedUpDown.Location = new System.Drawing.Point(102, 305);
            this.SpeedUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SpeedUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedUpDown.Name = "SpeedUpDown";
            this.SpeedUpDown.Size = new System.Drawing.Size(120, 22);
            this.SpeedUpDown.TabIndex = 11;
            this.SpeedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedUpDown.ValueChanged += new System.EventHandler(this.SpeedUpDown_ValueChanged);
            // 
            // AddCharacterButton
            // 
            this.AddCharacterButton.Location = new System.Drawing.Point(37, 362);
            this.AddCharacterButton.Name = "AddCharacterButton";
            this.AddCharacterButton.Size = new System.Drawing.Size(185, 47);
            this.AddCharacterButton.TabIndex = 12;
            this.AddCharacterButton.Text = "キャラ作成";
            this.AddCharacterButton.UseVisualStyleBackColor = true;
            this.AddCharacterButton.Click += new System.EventHandler(this.AddCharacterButton_Click);
            // 
            // AddCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.AddCharacterButton);
            this.Controls.Add(this.SpeedUpDown);
            this.Controls.Add(this.DefenceUpDown);
            this.Controls.Add(this.AttackUpDown);
            this.Controls.Add(this.MaxMPUpDown);
            this.Controls.Add(this.MaxHPUpDown);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.DefenceLabel);
            this.Controls.Add(this.AttackLabel);
            this.Controls.Add(this.MaxMPLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.MaxHPLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddCharacterForm";
            this.Text = "AddCharacter";
            this.Load += new System.EventHandler(this.AddCharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaxHPUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxMPUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MaxHPLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label MaxMPLabel;
        private System.Windows.Forms.Label AttackLabel;
        private System.Windows.Forms.Label DefenceLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.NumericUpDown MaxHPUpDown;
        private System.Windows.Forms.NumericUpDown MaxMPUpDown;
        private System.Windows.Forms.NumericUpDown AttackUpDown;
        private System.Windows.Forms.NumericUpDown DefenceUpDown;
        private System.Windows.Forms.NumericUpDown SpeedUpDown;
        private System.Windows.Forms.Button AddCharacterButton;
    }
}