namespace Multi_Screen
{
     partial class BigScreen
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
               this.pbWebCam = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
               this.SuspendLayout();
               // 
               // pbWebCam
               // 
               this.pbWebCam.Dock = System.Windows.Forms.DockStyle.Fill;
               this.pbWebCam.Location = new System.Drawing.Point(0, 0);
               this.pbWebCam.Name = "pbWebCam";
               this.pbWebCam.Size = new System.Drawing.Size(800, 450);
               this.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pbWebCam.TabIndex = 0;
               this.pbWebCam.TabStop = false;
               // 
               // BigScreen
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(800, 450);
               this.Controls.Add(this.pbWebCam);
               this.Name = "BigScreen";
               this.Text = "BigScreen";
               this.Load += new System.EventHandler(this.BigScreen_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.PictureBox pbWebCam;
     }
}