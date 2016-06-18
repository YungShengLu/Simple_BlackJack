namespace Black_Jack {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hibntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_usr = new System.Windows.Forms.Label();
            this.label_com = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_usr5 = new System.Windows.Forms.PictureBox();
            this.pb_usr4 = new System.Windows.Forms.PictureBox();
            this.pb_usr3 = new System.Windows.Forms.PictureBox();
            this.pb_usr2 = new System.Windows.Forms.PictureBox();
            this.pb_usr1 = new System.Windows.Forms.PictureBox();
            this.label_usrPoints = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_com5 = new System.Windows.Forms.PictureBox();
            this.pb_com4 = new System.Windows.Forms.PictureBox();
            this.pb_com3 = new System.Windows.Forms.PictureBox();
            this.pb_com2 = new System.Windows.Forms.PictureBox();
            this.pb_com1 = new System.Windows.Forms.PictureBox();
            this.label_comPoints = new System.Windows.Forms.Label();
            this.pictureBox_src = new System.Windows.Forms.PictureBox();
            this.button_get = new System.Windows.Forms.Button();
            this.button_pass = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.button_new = new System.Windows.Forms.Button();
            this.pictureBox_init = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_src)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_init)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.hibntToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.optionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeyDisplayString = "F2";
            this.newGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // hibntToolStripMenuItem
            // 
            this.hibntToolStripMenuItem.Name = "hibntToolStripMenuItem";
            this.hibntToolStripMenuItem.ShortcutKeyDisplayString = "H";
            this.hibntToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hibntToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.hibntToolStripMenuItem.Text = "Hint";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeftAutoMirrorImage = true;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(834, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Time:";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel4.Text = "00:00:00    ";
            // 
            // label_usr
            // 
            this.label_usr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_usr.AutoSize = true;
            this.label_usr.BackColor = System.Drawing.Color.Transparent;
            this.label_usr.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_usr.ForeColor = System.Drawing.Color.White;
            this.label_usr.Location = new System.Drawing.Point(72, 24);
            this.label_usr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(74, 26);
            this.label_usr.TabIndex = 2;
            this.label_usr.Text = "Player";
            // 
            // label_com
            // 
            this.label_com.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_com.AutoSize = true;
            this.label_com.BackColor = System.Drawing.Color.Transparent;
            this.label_com.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_com.ForeColor = System.Drawing.Color.White;
            this.label_com.Location = new System.Drawing.Point(686, 55);
            this.label_com.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_com.Name = "label_com";
            this.label_com.Size = new System.Drawing.Size(115, 26);
            this.label_com.TabIndex = 3;
            this.label_com.Text = "Computer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pb_usr5);
            this.panel1.Controls.Add(this.pb_usr4);
            this.panel1.Controls.Add(this.pb_usr3);
            this.panel1.Controls.Add(this.pb_usr2);
            this.panel1.Controls.Add(this.pb_usr1);
            this.panel1.Controls.Add(this.label_usrPoints);
            this.panel1.Controls.Add(this.label_usr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 211);
            this.panel1.TabIndex = 4;
            // 
            // pb_usr5
            // 
            this.pb_usr5.Location = new System.Drawing.Point(670, 24);
            this.pb_usr5.Name = "pb_usr5";
            this.pb_usr5.Size = new System.Drawing.Size(112, 164);
            this.pb_usr5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usr5.TabIndex = 8;
            this.pb_usr5.TabStop = false;
            // 
            // pb_usr4
            // 
            this.pb_usr4.Location = new System.Drawing.Point(552, 24);
            this.pb_usr4.Name = "pb_usr4";
            this.pb_usr4.Size = new System.Drawing.Size(112, 164);
            this.pb_usr4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usr4.TabIndex = 7;
            this.pb_usr4.TabStop = false;
            // 
            // pb_usr3
            // 
            this.pb_usr3.Location = new System.Drawing.Point(434, 24);
            this.pb_usr3.Name = "pb_usr3";
            this.pb_usr3.Size = new System.Drawing.Size(112, 164);
            this.pb_usr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usr3.TabIndex = 6;
            this.pb_usr3.TabStop = false;
            // 
            // pb_usr2
            // 
            this.pb_usr2.Location = new System.Drawing.Point(316, 24);
            this.pb_usr2.Name = "pb_usr2";
            this.pb_usr2.Size = new System.Drawing.Size(112, 164);
            this.pb_usr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usr2.TabIndex = 5;
            this.pb_usr2.TabStop = false;
            // 
            // pb_usr1
            // 
            this.pb_usr1.Location = new System.Drawing.Point(198, 24);
            this.pb_usr1.Name = "pb_usr1";
            this.pb_usr1.Size = new System.Drawing.Size(112, 164);
            this.pb_usr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_usr1.TabIndex = 4;
            this.pb_usr1.TabStop = false;
            // 
            // label_usrPoints
            // 
            this.label_usrPoints.AutoSize = true;
            this.label_usrPoints.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_usrPoints.ForeColor = System.Drawing.Color.Yellow;
            this.label_usrPoints.Location = new System.Drawing.Point(69, 50);
            this.label_usrPoints.Name = "label_usrPoints";
            this.label_usrPoints.Size = new System.Drawing.Size(42, 47);
            this.label_usrPoints.TabIndex = 3;
            this.label_usrPoints.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox_init);
            this.panel3.Controls.Add(this.pb_com5);
            this.panel3.Controls.Add(this.pb_com4);
            this.panel3.Controls.Add(this.pb_com3);
            this.panel3.Controls.Add(this.pb_com2);
            this.panel3.Controls.Add(this.pb_com1);
            this.panel3.Controls.Add(this.label_comPoints);
            this.panel3.Controls.Add(this.label_com);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 211);
            this.panel3.TabIndex = 6;
            // 
            // pb_com5
            // 
            this.pb_com5.Location = new System.Drawing.Point(77, 24);
            this.pb_com5.Name = "pb_com5";
            this.pb_com5.Size = new System.Drawing.Size(112, 164);
            this.pb_com5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_com5.TabIndex = 13;
            this.pb_com5.TabStop = false;
            // 
            // pb_com4
            // 
            this.pb_com4.Location = new System.Drawing.Point(198, 24);
            this.pb_com4.Name = "pb_com4";
            this.pb_com4.Size = new System.Drawing.Size(112, 164);
            this.pb_com4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_com4.TabIndex = 12;
            this.pb_com4.TabStop = false;
            // 
            // pb_com3
            // 
            this.pb_com3.Location = new System.Drawing.Point(316, 24);
            this.pb_com3.Name = "pb_com3";
            this.pb_com3.Size = new System.Drawing.Size(112, 164);
            this.pb_com3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_com3.TabIndex = 11;
            this.pb_com3.TabStop = false;
            // 
            // pb_com2
            // 
            this.pb_com2.Location = new System.Drawing.Point(434, 24);
            this.pb_com2.Name = "pb_com2";
            this.pb_com2.Size = new System.Drawing.Size(112, 164);
            this.pb_com2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_com2.TabIndex = 10;
            this.pb_com2.TabStop = false;
            // 
            // pb_com1
            // 
            this.pb_com1.Location = new System.Drawing.Point(552, 24);
            this.pb_com1.Name = "pb_com1";
            this.pb_com1.Size = new System.Drawing.Size(112, 164);
            this.pb_com1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_com1.TabIndex = 9;
            this.pb_com1.TabStop = false;
            // 
            // label_comPoints
            // 
            this.label_comPoints.AutoSize = true;
            this.label_comPoints.Font = new System.Drawing.Font("Microsoft JhengHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_comPoints.ForeColor = System.Drawing.Color.Yellow;
            this.label_comPoints.Location = new System.Drawing.Point(759, 81);
            this.label_comPoints.Name = "label_comPoints";
            this.label_comPoints.Size = new System.Drawing.Size(42, 47);
            this.label_comPoints.TabIndex = 4;
            this.label_comPoints.Text = "0";
            // 
            // pictureBox_src
            // 
            this.pictureBox_src.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_src.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_src.Image = global::Black_Jack.Resource.Pattern_1;
            this.pictureBox_src.Location = new System.Drawing.Point(800, 235);
            this.pictureBox_src.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox_src.Name = "pictureBox_src";
            this.pictureBox_src.Size = new System.Drawing.Size(112, 164);
            this.pictureBox_src.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_src.TabIndex = 7;
            this.pictureBox_src.TabStop = false;
            // 
            // button_get
            // 
            this.button_get.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_get.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_get.Location = new System.Drawing.Point(198, 286);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(147, 53);
            this.button_get.TabIndex = 8;
            this.button_get.Text = "Get";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // button_pass
            // 
            this.button_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pass.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_pass.Location = new System.Drawing.Point(517, 286);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(147, 53);
            this.button_pass.TabIndex = 9;
            this.button_pass.Text = "Pass";
            this.button_pass.UseVisualStyleBackColor = true;
            this.button_pass.Click += new System.EventHandler(this.button_pass_Click);
            // 
            // button_start
            // 
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_start.Location = new System.Drawing.Point(359, 286);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(147, 53);
            this.button_start.TabIndex = 10;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Microsoft JhengHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_status.Location = new System.Drawing.Point(371, 239);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(125, 45);
            this.label_status.TabIndex = 11;
            this.label_status.Text = "Status";
            // 
            // button_new
            // 
            this.button_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_new.Location = new System.Drawing.Point(359, 286);
            this.button_new.Name = "button_new";
            this.button_new.Size = new System.Drawing.Size(147, 53);
            this.button_new.TabIndex = 12;
            this.button_new.Text = "New Game";
            this.button_new.UseVisualStyleBackColor = true;
            this.button_new.Click += new System.EventHandler(this.button_new_Click);
            // 
            // pictureBox_init
            // 
            this.pictureBox_init.Image = global::Black_Jack.Resource.Pattern_1;
            this.pictureBox_init.Location = new System.Drawing.Point(553, 24);
            this.pictureBox_init.Name = "pictureBox_init";
            this.pictureBox_init.Size = new System.Drawing.Size(112, 164);
            this.pictureBox_init.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_init.TabIndex = 14;
            this.pictureBox_init.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Black_Jack.Resource.bg_1;
            this.ClientSize = new System.Drawing.Size(912, 632);
            this.Controls.Add(this.button_new);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_pass);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.pictureBox_src);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_usr1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_com1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_src)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_init)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hibntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.Label label_com;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_src;
        private System.Windows.Forms.Label label_usrPoints;
        private System.Windows.Forms.Label label_comPoints;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.PictureBox pb_usr5;
        private System.Windows.Forms.PictureBox pb_usr4;
        private System.Windows.Forms.PictureBox pb_usr3;
        private System.Windows.Forms.PictureBox pb_usr2;
        private System.Windows.Forms.PictureBox pb_usr1;
        private System.Windows.Forms.PictureBox pb_com5;
        private System.Windows.Forms.PictureBox pb_com4;
        private System.Windows.Forms.PictureBox pb_com3;
        private System.Windows.Forms.PictureBox pb_com2;
        private System.Windows.Forms.PictureBox pb_com1;
        private System.Windows.Forms.Button button_pass;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_new;
        private System.Windows.Forms.PictureBox pictureBox_init;
    }
}

