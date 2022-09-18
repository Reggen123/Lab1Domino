
namespace DominoLab1
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
            System.Windows.Forms.Button buttonCreate;
            this.buttonGetNumbers = new System.Windows.Forms.Button();
            this.buttonMakeTurn = new System.Windows.Forms.Button();
            this.labelCreate = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DominoId = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelValues = new System.Windows.Forms.Label();
            buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DominoId)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new System.Drawing.Point(615, 156);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(107, 44);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Создать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCreate_MouseClick);
            // 
            // buttonGetNumbers
            // 
            this.buttonGetNumbers.Location = new System.Drawing.Point(76, 216);
            this.buttonGetNumbers.Name = "buttonGetNumbers";
            this.buttonGetNumbers.Size = new System.Drawing.Size(99, 44);
            this.buttonGetNumbers.TabIndex = 1;
            this.buttonGetNumbers.Text = "Показать значения";
            this.buttonGetNumbers.UseVisualStyleBackColor = true;
            this.buttonGetNumbers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonGetNumbers_MouseClick);
            // 
            // buttonMakeTurn
            // 
            this.buttonMakeTurn.Location = new System.Drawing.Point(76, 289);
            this.buttonMakeTurn.Name = "buttonMakeTurn";
            this.buttonMakeTurn.Size = new System.Drawing.Size(99, 44);
            this.buttonMakeTurn.TabIndex = 2;
            this.buttonMakeTurn.Text = "Сделать Ход";
            this.buttonMakeTurn.UseVisualStyleBackColor = true;
            this.buttonMakeTurn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMakeTurn_MouseClick);
            // 
            // labelCreate
            // 
            this.labelCreate.AutoSize = true;
            this.labelCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCreate.Location = new System.Drawing.Point(584, 81);
            this.labelCreate.Name = "labelCreate";
            this.labelCreate.Size = new System.Drawing.Size(175, 24);
            this.labelCreate.TabIndex = 5;
            this.labelCreate.Text = "Создание Домино";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(38, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(160, 160);
            this.listBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(542, 216);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(678, 216);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 10;
            // 
            // DominoId
            // 
            this.DominoId.Location = new System.Drawing.Point(38, 367);
            this.DominoId.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.DominoId.Name = "DominoId";
            this.DominoId.Size = new System.Drawing.Size(173, 20);
            this.DominoId.TabIndex = 11;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(39, 405);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 25);
            this.labelResult.TabIndex = 13;
            // 
            // labelValues
            // 
            this.labelValues.AutoSize = true;
            this.labelValues.Location = new System.Drawing.Point(227, 231);
            this.labelValues.Name = "labelValues";
            this.labelValues.Size = new System.Drawing.Size(0, 13);
            this.labelValues.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValues);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.DominoId);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.buttonMakeTurn);
            this.Controls.Add(this.buttonGetNumbers);
            this.Controls.Add(buttonCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DominoId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGetNumbers;
        private System.Windows.Forms.Button buttonMakeTurn;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown DominoId;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelValues;
    }
}

