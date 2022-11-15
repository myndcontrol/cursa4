namespace cursa4
{
    partial class servis
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьУстройствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDevicePanel = new System.Windows.Forms.Panel();
            this.producerLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.serialIDLabel = new System.Windows.Forms.Label();
            this.problemLabel = new System.Windows.Forms.Label();
            this.producerBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.serialIDBox = new System.Windows.Forms.TextBox();
            this.problemBox = new System.Windows.Forms.TextBox();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.deviceAdded = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.addDevicePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУстройствоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьУстройствоToolStripMenuItem
            // 
            this.добавитьУстройствоToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.добавитьУстройствоToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.добавитьУстройствоToolStripMenuItem.Name = "добавитьУстройствоToolStripMenuItem";
            this.добавитьУстройствоToolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            this.добавитьУстройствоToolStripMenuItem.Text = "Добавить устройство";
            this.добавитьУстройствоToolStripMenuItem.Click += new System.EventHandler(this.addDevice);
            // 
            // addDevicePanel
            // 
            this.addDevicePanel.Controls.Add(this.addDeviceButton);
            this.addDevicePanel.Controls.Add(this.problemBox);
            this.addDevicePanel.Controls.Add(this.serialIDBox);
            this.addDevicePanel.Controls.Add(this.modelBox);
            this.addDevicePanel.Controls.Add(this.producerBox);
            this.addDevicePanel.Controls.Add(this.problemLabel);
            this.addDevicePanel.Controls.Add(this.deviceAdded);
            this.addDevicePanel.Controls.Add(this.serialIDLabel);
            this.addDevicePanel.Controls.Add(this.modelLabel);
            this.addDevicePanel.Controls.Add(this.producerLabel);
            this.addDevicePanel.Location = new System.Drawing.Point(-8, 28);
            this.addDevicePanel.Name = "addDevicePanel";
            this.addDevicePanel.Size = new System.Drawing.Size(815, 430);
            this.addDevicePanel.TabIndex = 1;
            this.addDevicePanel.Visible = false;
            // 
            // producerLabel
            // 
            this.producerLabel.AutoSize = true;
            this.producerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.producerLabel.Location = new System.Drawing.Point(20, 14);
            this.producerLabel.Name = "producerLabel";
            this.producerLabel.Size = new System.Drawing.Size(225, 20);
            this.producerLabel.TabIndex = 0;
            this.producerLabel.Text = "Производитель устройства:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modelLabel.Location = new System.Drawing.Point(20, 72);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(74, 20);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "Модель:";
            // 
            // serialIDLabel
            // 
            this.serialIDLabel.AutoSize = true;
            this.serialIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.serialIDLabel.Location = new System.Drawing.Point(21, 138);
            this.serialIDLabel.Name = "serialIDLabel";
            this.serialIDLabel.Size = new System.Drawing.Size(230, 20);
            this.serialIDLabel.TabIndex = 0;
            this.serialIDLabel.Text = "Серийный номер устройства:";
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.problemLabel.Location = new System.Drawing.Point(22, 200);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(91, 20);
            this.problemLabel.TabIndex = 0;
            this.problemLabel.Text = "Проблема:";
            // 
            // producerBox
            // 
            this.producerBox.Location = new System.Drawing.Point(24, 44);
            this.producerBox.Name = "producerBox";
            this.producerBox.Size = new System.Drawing.Size(221, 20);
            this.producerBox.TabIndex = 1;
            this.producerBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.producerBox_MouseClick);
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(24, 106);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(221, 20);
            this.modelBox.TabIndex = 1;
            this.modelBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelBox_MouseClick);
            // 
            // serialIDBox
            // 
            this.serialIDBox.Location = new System.Drawing.Point(25, 174);
            this.serialIDBox.Name = "serialIDBox";
            this.serialIDBox.Size = new System.Drawing.Size(221, 20);
            this.serialIDBox.TabIndex = 1;
            this.serialIDBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.serialIDBox_MouseClick);
            // 
            // problemBox
            // 
            this.problemBox.Location = new System.Drawing.Point(26, 232);
            this.problemBox.Multiline = true;
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(221, 68);
            this.problemBox.TabIndex = 1;
            this.problemBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.problemBox_MouseClick);
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addDeviceButton.Location = new System.Drawing.Point(26, 318);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(221, 51);
            this.addDeviceButton.TabIndex = 2;
            this.addDeviceButton.Text = "Добавить устройство в базу данных";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // deviceAdded
            // 
            this.deviceAdded.AutoSize = true;
            this.deviceAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deviceAdded.Location = new System.Drawing.Point(22, 380);
            this.deviceAdded.Name = "deviceAdded";
            this.deviceAdded.Size = new System.Drawing.Size(258, 20);
            this.deviceAdded.TabIndex = 0;
            this.deviceAdded.Text = "Устройство успешно добавлено.";
            this.deviceAdded.Visible = false;
            // 
            // servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addDevicePanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "servis";
            this.Text = "Servis Center App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.addDevicePanel.ResumeLayout(false);
            this.addDevicePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьУстройствоToolStripMenuItem;
        private System.Windows.Forms.Panel addDevicePanel;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.TextBox problemBox;
        private System.Windows.Forms.TextBox serialIDBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox producerBox;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.Label serialIDLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label producerLabel;
        private System.Windows.Forms.Label deviceAdded;
    }
}

