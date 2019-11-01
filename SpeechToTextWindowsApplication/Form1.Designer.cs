namespace SpeechToTextWindowsApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartSpeaking = new System.Windows.Forms.Button();
            this.lblSpeech = new System.Windows.Forms.Label();
            // 
            // btnStartSpeaking
            // 
            this.btnStartSpeaking.Location = new System.Drawing.Point(405, 328);
            this.btnStartSpeaking.Name = "btnStartSpeaking";
            this.btnStartSpeaking.Size = new System.Drawing.Size(293, 96);
            this.btnStartSpeaking.TabIndex = 0;
            this.btnStartSpeaking.Text = "Start Speaking";
            this.btnStartSpeaking.UseVisualStyleBackColor = true;
            this.btnStartSpeaking.Click += new System.EventHandler(this.btnStartSpeaking_Click);
            // 
            // lblSpeech
            // 
            this.lblSpeech.AutoSize = true;
            this.lblSpeech.Location = new System.Drawing.Point(60, 24);
            this.lblSpeech.Name = "lblSpeech";
            this.lblSpeech.Size = new System.Drawing.Size(161, 15);
            this.lblSpeech.TabIndex = 1;
            this.lblSpeech.Text = "Output will be displayed here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSpeech);
            this.Controls.Add(this.btnStartSpeaking);
            this.Name = "Form1";
            this.Text = "Form1";

        }

        #endregion

        private System.Windows.Forms.Button btnStartSpeaking;
        private System.Windows.Forms.Label lblSpeech;
    }
}

