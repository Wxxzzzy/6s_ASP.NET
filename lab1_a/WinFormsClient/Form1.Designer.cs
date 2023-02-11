namespace WinFormsClient
{
    partial class Form1
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
            this.firstParameterField = new System.Windows.Forms.TextBox();
            this.secondParameterField = new System.Windows.Forms.TextBox();
            this.resultField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstParameterField
            // 
            this.firstParameterField.Location = new System.Drawing.Point(182, 151);
            this.firstParameterField.Name = "firstParameterField";
            this.firstParameterField.Size = new System.Drawing.Size(156, 22);
            this.firstParameterField.TabIndex = 0;
            this.firstParameterField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // secondParameterField
            // 
            this.secondParameterField.Location = new System.Drawing.Point(441, 151);
            this.secondParameterField.Name = "secondParameterField";
            this.secondParameterField.Size = new System.Drawing.Size(156, 22);
            this.secondParameterField.TabIndex = 1;
            this.secondParameterField.TextChanged += new System.EventHandler(this.secondParameterField_TextChanged);
            // 
            // resultField
            // 
            this.resultField.Location = new System.Drawing.Point(310, 248);
            this.resultField.Name = "resultField";
            this.resultField.Size = new System.Drawing.Size(156, 22);
            this.resultField.TabIndex = 2;
            this.resultField.TextChanged += new System.EventHandler(this.resultField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ParamA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ParamB:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "A + B =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultField);
            this.Controls.Add(this.secondParameterField);
            this.Controls.Add(this.firstParameterField);
            this.Name = "Form1";
            this.Text = "Fignya";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstParameterField;
        private System.Windows.Forms.TextBox secondParameterField;
        private System.Windows.Forms.TextBox resultField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

