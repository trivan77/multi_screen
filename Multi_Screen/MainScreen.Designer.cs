namespace Multi_Screen
{
     partial class MainScreen
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
               this.btnWatch_1 = new System.Windows.Forms.Button();
               this.btnWatch_2 = new System.Windows.Forms.Button();
               this.pbWebCam = new System.Windows.Forms.PictureBox();
               this.pbVideo = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
               this.SuspendLayout();
               // 
               // btnWatch_1
               // 
               this.btnWatch_1.Location = new System.Drawing.Point(163, 366);
               this.btnWatch_1.Name = "btnWatch_1";
               this.btnWatch_1.Size = new System.Drawing.Size(75, 23);
               this.btnWatch_1.TabIndex = 0;
               this.btnWatch_1.Text = "Xem";
               this.btnWatch_1.UseVisualStyleBackColor = true;
               // 
               // btnWatch_2
               // 
               this.btnWatch_2.Location = new System.Drawing.Point(568, 366);
               this.btnWatch_2.Name = "btnWatch_2";
               this.btnWatch_2.Size = new System.Drawing.Size(75, 23);
               this.btnWatch_2.TabIndex = 1;
               this.btnWatch_2.Text = "Xem";
               this.btnWatch_2.UseVisualStyleBackColor = true;
               this.btnWatch_2.Click += new System.EventHandler(this.btnWatch_2_Click);
               // 
               // pbWebCam
               // 
               this.pbWebCam.Location = new System.Drawing.Point(12, 12);
               this.pbWebCam.Name = "pbWebCam";
               this.pbWebCam.Size = new System.Drawing.Size(387, 328);
               this.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pbWebCam.TabIndex = 2;
               this.pbWebCam.TabStop = false;
               // 
               // pbVideo
               // 
               this.pbVideo.Location = new System.Drawing.Point(415, 12);
               this.pbVideo.Name = "pbVideo";
               this.pbVideo.Size = new System.Drawing.Size(373, 328);
               this.pbVideo.TabIndex = 3;
               this.pbVideo.TabStop = false;
               // 
               // MainScreen
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.pbVideo);
               this.Controls.Add(this.pbWebCam);
               this.Controls.Add(this.btnWatch_2);
               this.Controls.Add(this.btnWatch_1);
               this.Name = "MainScreen";
               this.Text = "MainScreen";
               this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
               this.Load += new System.EventHandler(this.MainScreen_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Button btnWatch_1;
          private System.Windows.Forms.Button btnWatch_2;
          private System.Windows.Forms.PictureBox pbWebCam;
          private System.Windows.Forms.PictureBox pbVideo;
     }
}