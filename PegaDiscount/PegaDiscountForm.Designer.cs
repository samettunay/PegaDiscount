namespace PageDiscount
{
    partial class PegaDiscountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PegaDiscountForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departurePortTextBox = new System.Windows.Forms.TextBox();
            this.arrivalPortLabel = new System.Windows.Forms.Label();
            this.arrivalPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adultCountTextBox = new System.Windows.Forms.TextBox();
            this.adultCountLabel = new System.Windows.Forms.Label();
            this.departurePortLabel = new System.Windows.Forms.Label();
            this.loopTimeTextbox = new System.Windows.Forms.TextBox();
            this.departureDateLabel = new System.Windows.Forms.Label();
            this.departureDateTextBox = new System.Windows.Forms.TextBox();
            this.selectedPriceLabel = new System.Windows.Forms.Label();
            this.selectedPriceTextBox = new System.Windows.Forms.TextBox();
            this.loopTimeLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // departurePortTextBox
            // 
            this.departurePortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.departurePortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departurePortTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.departurePortTextBox.Location = new System.Drawing.Point(219, 225);
            this.departurePortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.departurePortTextBox.Multiline = true;
            this.departurePortTextBox.Name = "departurePortTextBox";
            this.departurePortTextBox.ReadOnly = true;
            this.departurePortTextBox.Size = new System.Drawing.Size(114, 20);
            this.departurePortTextBox.TabIndex = 6;
            // 
            // arrivalPortLabel
            // 
            this.arrivalPortLabel.AutoSize = true;
            this.arrivalPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrivalPortLabel.Location = new System.Drawing.Point(57, 261);
            this.arrivalPortLabel.Name = "arrivalPortLabel";
            this.arrivalPortLabel.Size = new System.Drawing.Size(85, 20);
            this.arrivalPortLabel.TabIndex = 2;
            this.arrivalPortLabel.Text = "Arrival Port";
            // 
            // arrivalPortTextBox
            // 
            this.arrivalPortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.arrivalPortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalPortTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.arrivalPortTextBox.Location = new System.Drawing.Point(219, 261);
            this.arrivalPortTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrivalPortTextBox.Multiline = true;
            this.arrivalPortTextBox.Name = "arrivalPortTextBox";
            this.arrivalPortTextBox.ReadOnly = true;
            this.arrivalPortTextBox.Size = new System.Drawing.Size(114, 20);
            this.arrivalPortTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Settings";
            // 
            // adultCountTextBox
            // 
            this.adultCountTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.adultCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adultCountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.adultCountTextBox.Location = new System.Drawing.Point(219, 111);
            this.adultCountTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adultCountTextBox.Multiline = true;
            this.adultCountTextBox.Name = "adultCountTextBox";
            this.adultCountTextBox.ReadOnly = true;
            this.adultCountTextBox.Size = new System.Drawing.Size(114, 20);
            this.adultCountTextBox.TabIndex = 3;
            // 
            // adultCountLabel
            // 
            this.adultCountLabel.AutoSize = true;
            this.adultCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adultCountLabel.Location = new System.Drawing.Point(57, 111);
            this.adultCountLabel.Name = "adultCountLabel";
            this.adultCountLabel.Size = new System.Drawing.Size(93, 20);
            this.adultCountLabel.TabIndex = 6;
            this.adultCountLabel.Text = "Adult Count";
            // 
            // departurePortLabel
            // 
            this.departurePortLabel.AutoSize = true;
            this.departurePortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departurePortLabel.Location = new System.Drawing.Point(57, 225);
            this.departurePortLabel.Name = "departurePortLabel";
            this.departurePortLabel.Size = new System.Drawing.Size(114, 20);
            this.departurePortLabel.TabIndex = 8;
            this.departurePortLabel.Text = "Departure Port";
            // 
            // loopTimeTextbox
            // 
            this.loopTimeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.loopTimeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loopTimeTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.loopTimeTextbox.Location = new System.Drawing.Point(219, 300);
            this.loopTimeTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loopTimeTextbox.Multiline = true;
            this.loopTimeTextbox.Name = "loopTimeTextbox";
            this.loopTimeTextbox.ReadOnly = true;
            this.loopTimeTextbox.Size = new System.Drawing.Size(114, 20);
            this.loopTimeTextbox.TabIndex = 8;
            // 
            // departureDateLabel
            // 
            this.departureDateLabel.AutoSize = true;
            this.departureDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departureDateLabel.Location = new System.Drawing.Point(57, 149);
            this.departureDateLabel.Name = "departureDateLabel";
            this.departureDateLabel.Size = new System.Drawing.Size(120, 20);
            this.departureDateLabel.TabIndex = 10;
            this.departureDateLabel.Text = "Departure Date";
            // 
            // departureDateTextBox
            // 
            this.departureDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.departureDateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.departureDateTextBox.Location = new System.Drawing.Point(219, 149);
            this.departureDateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.departureDateTextBox.Multiline = true;
            this.departureDateTextBox.Name = "departureDateTextBox";
            this.departureDateTextBox.ReadOnly = true;
            this.departureDateTextBox.Size = new System.Drawing.Size(114, 20);
            this.departureDateTextBox.TabIndex = 4;
            // 
            // selectedPriceLabel
            // 
            this.selectedPriceLabel.AutoSize = true;
            this.selectedPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectedPriceLabel.Location = new System.Drawing.Point(57, 188);
            this.selectedPriceLabel.Name = "selectedPriceLabel";
            this.selectedPriceLabel.Size = new System.Drawing.Size(111, 20);
            this.selectedPriceLabel.TabIndex = 12;
            this.selectedPriceLabel.Text = "Selected Price";
            // 
            // selectedPriceTextBox
            // 
            this.selectedPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(69)))), ((int)(((byte)(71)))));
            this.selectedPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.selectedPriceTextBox.Location = new System.Drawing.Point(219, 188);
            this.selectedPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectedPriceTextBox.Multiline = true;
            this.selectedPriceTextBox.Name = "selectedPriceTextBox";
            this.selectedPriceTextBox.ReadOnly = true;
            this.selectedPriceTextBox.Size = new System.Drawing.Size(114, 20);
            this.selectedPriceTextBox.TabIndex = 5;
            // 
            // loopTimeLabel
            // 
            this.loopTimeLabel.AutoSize = true;
            this.loopTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loopTimeLabel.Location = new System.Drawing.Point(57, 300);
            this.loopTimeLabel.Name = "loopTimeLabel";
            this.loopTimeLabel.Size = new System.Drawing.Size(145, 20);
            this.loopTimeLabel.TabIndex = 13;
            this.loopTimeLabel.Text = "Loop Time (Minute)";
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(71)))));
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.runButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.runButton.ForeColor = System.Drawing.Color.White;
            this.runButton.Location = new System.Drawing.Point(219, 353);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(114, 29);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(71)))));
            this.stopButton.Enabled = false;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(63, 353);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(114, 29);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // PegaDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(427, 436);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.loopTimeLabel);
            this.Controls.Add(this.selectedPriceLabel);
            this.Controls.Add(this.selectedPriceTextBox);
            this.Controls.Add(this.departureDateLabel);
            this.Controls.Add(this.departureDateTextBox);
            this.Controls.Add(this.departurePortLabel);
            this.Controls.Add(this.loopTimeTextbox);
            this.Controls.Add(this.adultCountLabel);
            this.Controls.Add(this.adultCountTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrivalPortTextBox);
            this.Controls.Add(this.arrivalPortLabel);
            this.Controls.Add(this.departurePortTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(223)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PegaDiscountForm";
            this.Text = "PegaDiscount";
            this.Load += new System.EventHandler(this.PegaDiscountForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox departurePortTextBox;
        private System.Windows.Forms.Label arrivalPortLabel;
        private System.Windows.Forms.TextBox arrivalPortTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adultCountTextBox;
        private System.Windows.Forms.Label adultCountLabel;
        private System.Windows.Forms.Label departurePortLabel;
        private System.Windows.Forms.TextBox loopTimeTextbox;
        private System.Windows.Forms.Label departureDateLabel;
        private System.Windows.Forms.TextBox departureDateTextBox;
        private System.Windows.Forms.Label selectedPriceLabel;
        private System.Windows.Forms.TextBox selectedPriceTextBox;
        private System.Windows.Forms.Label loopTimeLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

