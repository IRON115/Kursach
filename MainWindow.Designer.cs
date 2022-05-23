namespace CityDefense
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.renderBox = new System.Windows.Forms.PictureBox();
            this.bPause = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.Enabled = true;
            this.Frame.Interval = 40;
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // renderBox
            // 
            this.renderBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.renderBox.Location = new System.Drawing.Point(1, 28);
            this.renderBox.Margin = new System.Windows.Forms.Padding(2);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(722, 381);
            this.renderBox.TabIndex = 0;
            this.renderBox.TabStop = false;
            this.renderBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.renderBox_MouseDown);
            // 
            // bPause
            // 
            this.bPause.BackColor = System.Drawing.Color.Lime;
            this.bPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPause.Location = new System.Drawing.Point(123, 2);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(117, 23);
            this.bPause.TabIndex = 1;
            this.bPause.Text = "PAUSE";
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.Lime;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStart.Location = new System.Drawing.Point(1, 1);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(116, 24);
            this.bStart.TabIndex = 2;
            this.bStart.Text = "START";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 403);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bPause);
            this.Controls.Add(this.renderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "City Defense";
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Frame;
        private System.Windows.Forms.PictureBox renderBox;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bStart;
    }
}

