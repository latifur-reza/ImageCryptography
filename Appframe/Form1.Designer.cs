namespace Appframe
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonClickFileOpen = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openTxtFile = new System.Windows.Forms.Button();
            this.textFileLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarrierFile = new System.Windows.Forms.TextBox();
            this.carrierFileBtn = new System.Windows.Forms.Button();
            this.textBoxSaveFileTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDecodedMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(208, 197);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(369, 217);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonClickFileOpen
            // 
            this.buttonClickFileOpen.Location = new System.Drawing.Point(39, 70);
            this.buttonClickFileOpen.Name = "buttonClickFileOpen";
            this.buttonClickFileOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonClickFileOpen.TabIndex = 1;
            this.buttonClickFileOpen.Text = "Carrier File";
            this.buttonClickFileOpen.UseVisualStyleBackColor = true;
            this.buttonClickFileOpen.Click += new System.EventHandler(this.buttonClickFileOpen_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(152, 153);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 2;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(571, 168);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 3;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(141, 72);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(197, 20);
            this.textBoxFilePath.TabIndex = 4;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(141, 127);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(197, 20);
            this.textBoxMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Message";
            // 
            // openTxtFile
            // 
            this.openTxtFile.Location = new System.Drawing.Point(39, 99);
            this.openTxtFile.Name = "openTxtFile";
            this.openTxtFile.Size = new System.Drawing.Size(75, 23);
            this.openTxtFile.TabIndex = 7;
            this.openTxtFile.Text = "Content File";
            this.openTxtFile.UseVisualStyleBackColor = true;
            this.openTxtFile.Click += new System.EventHandler(this.openTxtFile_Click);
            // 
            // textFileLocation
            // 
            this.textFileLocation.Location = new System.Drawing.Point(141, 101);
            this.textFileLocation.Name = "textFileLocation";
            this.textFileLocation.Size = new System.Drawing.Size(197, 20);
            this.textFileLocation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Encryption";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(567, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Decryption";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Image Preview";
            // 
            // textBoxCarrierFile
            // 
            this.textBoxCarrierFile.Location = new System.Drawing.Point(561, 71);
            this.textBoxCarrierFile.Name = "textBoxCarrierFile";
            this.textBoxCarrierFile.Size = new System.Drawing.Size(197, 20);
            this.textBoxCarrierFile.TabIndex = 13;
            // 
            // carrierFileBtn
            // 
            this.carrierFileBtn.Location = new System.Drawing.Point(459, 69);
            this.carrierFileBtn.Name = "carrierFileBtn";
            this.carrierFileBtn.Size = new System.Drawing.Size(75, 23);
            this.carrierFileBtn.TabIndex = 12;
            this.carrierFileBtn.Text = "Carrier File";
            this.carrierFileBtn.UseVisualStyleBackColor = true;
            this.carrierFileBtn.Click += new System.EventHandler(this.carrierFileBtn_Click);
            // 
            // textBoxSaveFileTo
            // 
            this.textBoxSaveFileTo.Location = new System.Drawing.Point(561, 101);
            this.textBoxSaveFileTo.Name = "textBoxSaveFileTo";
            this.textBoxSaveFileTo.Size = new System.Drawing.Size(197, 20);
            this.textBoxSaveFileTo.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Message";
            // 
            // textBoxDecodedMessage
            // 
            this.textBoxDecodedMessage.Location = new System.Drawing.Point(561, 131);
            this.textBoxDecodedMessage.Name = "textBoxDecodedMessage";
            this.textBoxDecodedMessage.Size = new System.Drawing.Size(197, 20);
            this.textBoxDecodedMessage.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Save File To";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDecodedMessage);
            this.Controls.Add(this.textBoxSaveFileTo);
            this.Controls.Add(this.textBoxCarrierFile);
            this.Controls.Add(this.carrierFileBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFileLocation);
            this.Controls.Add(this.openTxtFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.buttonClickFileOpen);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonClickFileOpen;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openTxtFile;
        private System.Windows.Forms.TextBox textFileLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarrierFile;
        private System.Windows.Forms.Button carrierFileBtn;
        private System.Windows.Forms.TextBox textBoxSaveFileTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDecodedMessage;
        private System.Windows.Forms.Label label6;
    }
}

