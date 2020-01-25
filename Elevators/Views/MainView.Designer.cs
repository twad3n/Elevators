namespace Elevators.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.field = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.speedDecButton = new System.Windows.Forms.Button();
            this.speedNormalButton = new System.Windows.Forms.Button();
            this.speedIncButton = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.addManButton = new System.Windows.Forms.Button();
            this.alarmButton = new System.Windows.Forms.Button();
            this.labelAppName = new System.Windows.Forms.Label();
            this.elevator = new System.Windows.Forms.PictureBox();
            this.openSettingsButton = new System.Windows.Forms.Button();
            this.floorIconBase = new System.Windows.Forms.Button();
            this.clickMe = new System.Windows.Forms.Button();
            this.pictureMan = new System.Windows.Forms.PictureBox();
            this.dontClickMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMan)).BeginInit();
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.Transparent;
            this.field.Enabled = false;
            this.field.Location = new System.Drawing.Point(119, 94);
            this.field.Margin = new System.Windows.Forms.Padding(2);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(680, 610);
            this.field.TabIndex = 0;
            this.field.UseVisualStyleBackColor = false;
            this.field.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(831, 94);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 54);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start/Unpause";
            this.startButton.UseVisualStyleBackColor = false;
            // 
            // speedDecButton
            // 
            this.speedDecButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedDecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedDecButton.Location = new System.Drawing.Point(826, 327);
            this.speedDecButton.Margin = new System.Windows.Forms.Padding(2);
            this.speedDecButton.Name = "speedDecButton";
            this.speedDecButton.Size = new System.Drawing.Size(52, 54);
            this.speedDecButton.TabIndex = 12;
            this.speedDecButton.Text = "x0.5";
            this.speedDecButton.UseVisualStyleBackColor = false;
            // 
            // speedNormalButton
            // 
            this.speedNormalButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedNormalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedNormalButton.Location = new System.Drawing.Point(883, 327);
            this.speedNormalButton.Margin = new System.Windows.Forms.Padding(2);
            this.speedNormalButton.Name = "speedNormalButton";
            this.speedNormalButton.Size = new System.Drawing.Size(52, 54);
            this.speedNormalButton.TabIndex = 13;
            this.speedNormalButton.Text = "x1.0";
            this.speedNormalButton.UseVisualStyleBackColor = false;
            // 
            // speedIncButton
            // 
            this.speedIncButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.speedIncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedIncButton.Location = new System.Drawing.Point(940, 327);
            this.speedIncButton.Margin = new System.Windows.Forms.Padding(2);
            this.speedIncButton.Name = "speedIncButton";
            this.speedIncButton.Size = new System.Drawing.Size(50, 54);
            this.speedIncButton.TabIndex = 14;
            this.speedIncButton.Text = "x2.0";
            this.speedIncButton.UseVisualStyleBackColor = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSpeed.Location = new System.Drawing.Point(861, 290);
            this.labelSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(93, 35);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "Speed";
            // 
            // pauseButton
            // 
            this.pauseButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pauseButton.Location = new System.Drawing.Point(831, 152);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(150, 54);
            this.pauseButton.TabIndex = 16;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = false;
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.Location = new System.Drawing.Point(831, 210);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(150, 54);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Finish";
            this.stopButton.UseVisualStyleBackColor = false;
            // 
            // addManButton
            // 
            this.addManButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addManButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addManButton.Location = new System.Drawing.Point(826, 413);
            this.addManButton.Margin = new System.Windows.Forms.Padding(2);
            this.addManButton.Name = "addManButton";
            this.addManButton.Size = new System.Drawing.Size(164, 54);
            this.addManButton.TabIndex = 18;
            this.addManButton.Text = "Add a man";
            this.addManButton.UseVisualStyleBackColor = false;
            this.addManButton.Click += new System.EventHandler(this.addManButton_Click);
            // 
            // alarmButton
            // 
            this.alarmButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.alarmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarmButton.Location = new System.Drawing.Point(826, 471);
            this.alarmButton.Margin = new System.Windows.Forms.Padding(2);
            this.alarmButton.Name = "alarmButton";
            this.alarmButton.Size = new System.Drawing.Size(164, 68);
            this.alarmButton.TabIndex = 19;
            this.alarmButton.Text = "Sound the Alarm";
            this.alarmButton.UseVisualStyleBackColor = false;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAppName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAppName.Location = new System.Drawing.Point(346, 9);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(298, 81);
            this.labelAppName.TabIndex = 20;
            this.labelAppName.Text = "Elevators";
            // 
            // elevator
            // 
            this.elevator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(165, 587);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(72, 112);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.elevator.TabIndex = 21;
            this.elevator.TabStop = false;
            this.elevator.Visible = false;
            // 
            // openSettingsButton
            // 
            this.openSettingsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.openSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openSettingsButton.Location = new System.Drawing.Point(826, 603);
            this.openSettingsButton.Name = "openSettingsButton";
            this.openSettingsButton.Size = new System.Drawing.Size(164, 83);
            this.openSettingsButton.TabIndex = 22;
            this.openSettingsButton.Text = "Settings";
            this.openSettingsButton.UseVisualStyleBackColor = false;
            this.openSettingsButton.Click += new System.EventHandler(this.openSettingsButton_Click);
            // 
            // floorIconBase
            // 
            this.floorIconBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.floorIconBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.floorIconBase.Location = new System.Drawing.Point(803, 255);
            this.floorIconBase.Margin = new System.Windows.Forms.Padding(2);
            this.floorIconBase.Name = "floorIconBase";
            this.floorIconBase.Size = new System.Drawing.Size(49, 112);
            this.floorIconBase.TabIndex = 23;
            this.floorIconBase.Text = "1";
            this.floorIconBase.UseVisualStyleBackColor = false;
            this.floorIconBase.Visible = false;
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(742, 36);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(75, 23);
            this.clickMe.TabIndex = 27;
            this.clickMe.Text = "UP";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // pictureMan
            // 
            this.pictureMan.Image = ((System.Drawing.Image)(resources.GetObject("pictureMan.Image")));
            this.pictureMan.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureMan.InitialImage")));
            this.pictureMan.Location = new System.Drawing.Point(37, 36);
            this.pictureMan.Name = "pictureMan";
            this.pictureMan.Size = new System.Drawing.Size(100, 50);
            this.pictureMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMan.TabIndex = 28;
            this.pictureMan.TabStop = false;
            this.pictureMan.Visible = false;
            // 
            // dontClickMe
            // 
            this.dontClickMe.Location = new System.Drawing.Point(831, 36);
            this.dontClickMe.Name = "dontClickMe";
            this.dontClickMe.Size = new System.Drawing.Size(75, 23);
            this.dontClickMe.TabIndex = 29;
            this.dontClickMe.Text = "DOWN";
            this.dontClickMe.UseVisualStyleBackColor = true;
            this.dontClickMe.Click += new System.EventHandler(this.dontClickMe_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dontClickMe);
            this.Controls.Add(this.pictureMan);
            this.Controls.Add(this.clickMe);
            this.Controls.Add(this.floorIconBase);
            this.Controls.Add(this.openSettingsButton);
            this.Controls.Add(this.elevator);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.alarmButton);
            this.Controls.Add(this.addManButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.speedIncButton);
            this.Controls.Add(this.speedNormalButton);
            this.Controls.Add(this.speedDecButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.Text = "Elevators";
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button speedDecButton;
        private System.Windows.Forms.Button speedNormalButton;
        private System.Windows.Forms.Button speedIncButton;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button addManButton;
        private System.Windows.Forms.Button alarmButton;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.Button openSettingsButton;
        private System.Windows.Forms.Button floorIconBase;
        private System.Windows.Forms.Button clickMe;
        private System.Windows.Forms.PictureBox pictureMan;
        private System.Windows.Forms.Button dontClickMe;
    }
}