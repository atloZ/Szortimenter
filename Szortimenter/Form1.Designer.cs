
namespace Szortimenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.locationText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ujLocatioButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.offRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton.Depth = 0;
            this.startButton.Icon = null;
            this.startButton.Location = new System.Drawing.Point(339, 169);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.startButton.Name = "startButton";
            this.startButton.Primary = false;
            this.startButton.Size = new System.Drawing.Size(124, 36);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Rendezés";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // locationText
            // 
            this.locationText.Depth = 0;
            this.locationText.Hint = "";
            this.locationText.Location = new System.Drawing.Point(12, 122);
            this.locationText.MaxLength = 32767;
            this.locationText.MouseState = MaterialSkin.MouseState.HOVER;
            this.locationText.Name = "locationText";
            this.locationText.PasswordChar = '\0';
            this.locationText.SelectedText = "";
            this.locationText.SelectionLength = 0;
            this.locationText.SelectionStart = 0;
            this.locationText.Size = new System.Drawing.Size(451, 32);
            this.locationText.TabIndex = 2;
            this.locationText.TabStop = false;
            this.locationText.Text = "LocationHelye";
            this.locationText.UseSystemPasswordChar = false;
            // 
            // ujLocatioButton
            // 
            this.ujLocatioButton.AutoSize = true;
            this.ujLocatioButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ujLocatioButton.Depth = 0;
            this.ujLocatioButton.Icon = null;
            this.ujLocatioButton.Location = new System.Drawing.Point(339, 107);
            this.ujLocatioButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ujLocatioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ujLocatioButton.Name = "ujLocatioButton";
            this.ujLocatioButton.Primary = false;
            this.ujLocatioButton.Size = new System.Drawing.Size(113, 36);
            this.ujLocatioButton.TabIndex = 1;
            this.ujLocatioButton.Text = "talozás";
            this.ujLocatioButton.UseVisualStyleBackColor = true;
            this.ujLocatioButton.Click += new System.EventHandler(this.ujLocatioButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // offRadioButton
            // 
            this.offRadioButton.AutoSize = true;
            this.offRadioButton.Checked = true;
            this.offRadioButton.Depth = 0;
            this.offRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.offRadioButton.Location = new System.Drawing.Point(12, 175);
            this.offRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.offRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.offRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.offRadioButton.Name = "offRadioButton";
            this.offRadioButton.Ripple = true;
            this.offRadioButton.Size = new System.Drawing.Size(305, 30);
            this.offRadioButton.TabIndex = 4;
            this.offRadioButton.TabStop = true;
            this.offRadioButton.Text = "Futás után álljon le a program";
            this.offRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 254);
            this.Controls.Add(this.offRadioButton);
            this.Controls.Add(this.ujLocatioButton);
            this.Controls.Add(this.locationText);
            this.Controls.Add(this.startButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Szortimenter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton startButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField locationText;
        private MaterialSkin.Controls.MaterialFlatButton ujLocatioButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialRadioButton offRadioButton;
    }
}

