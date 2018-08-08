namespace MinorProject
{
    partial class Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camera));
            this.cameraViewBox = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.add2DbButton = new System.Windows.Forms.Button();
            this.extractedFaceBox = new Emgu.CV.UI.ImageBox();
            this.faceDatabaseDataSet1 = new MinorProject.FaceDatabaseDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedFaceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraViewBox
            // 
            this.cameraViewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraViewBox.Location = new System.Drawing.Point(12, 12);
            this.cameraViewBox.Name = "cameraViewBox";
            this.cameraViewBox.Size = new System.Drawing.Size(500, 375);
            this.cameraViewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraViewBox.TabIndex = 2;
            this.cameraViewBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start Camera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Load Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(530, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(530, 335);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(527, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Roll No.:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(590, 248);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(60, 25);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(527, 248);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(60, 25);
            this.prevButton.TabIndex = 10;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // add2DbButton
            // 
            this.add2DbButton.Location = new System.Drawing.Point(540, 361);
            this.add2DbButton.Name = "add2DbButton";
            this.add2DbButton.Size = new System.Drawing.Size(110, 23);
            this.add2DbButton.TabIndex = 11;
            this.add2DbButton.Text = "Add To Database";
            this.add2DbButton.UseVisualStyleBackColor = true;
            this.add2DbButton.Click += new System.EventHandler(this.add2DbButton_Click);
            // 
            // extractedFaceBox
            // 
            this.extractedFaceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extractedFaceBox.Location = new System.Drawing.Point(519, 104);
            this.extractedFaceBox.Name = "extractedFaceBox";
            this.extractedFaceBox.Size = new System.Drawing.Size(138, 138);
            this.extractedFaceBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.extractedFaceBox.TabIndex = 2;
            this.extractedFaceBox.TabStop = false;
            // 
            // faceDatabaseDataSet1
            // 
            this.faceDatabaseDataSet1.DataSetName = "FaceDatabaseDataSet";
            this.faceDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 397);
            this.Controls.Add(this.extractedFaceBox);
            this.Controls.Add(this.add2DbButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cameraViewBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Camera";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Face Detector";
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extractedFaceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faceDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraViewBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button add2DbButton;
        private Emgu.CV.UI.ImageBox extractedFaceBox;
        private FaceDatabaseDataSet faceDatabaseDataSet1;
    }
}

