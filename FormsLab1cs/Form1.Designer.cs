
namespace FormsLab1cs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxOfX = new System.Windows.Forms.TextBox();
            this.BoxOfY = new System.Windows.Forms.TextBox();
            this.BoxOfZ = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Execute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // BoxOfX
            // 
            resources.ApplyResources(this.BoxOfX, "BoxOfX");
            this.BoxOfX.Name = "BoxOfX";
            this.BoxOfX.TextChanged += new System.EventHandler(this.BoxOfX_TextChanged);
            this.BoxOfX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressX);
            // 
            // BoxOfY
            // 
            resources.ApplyResources(this.BoxOfY, "BoxOfY");
            this.BoxOfY.Name = "BoxOfY";
            this.BoxOfY.TextChanged += new System.EventHandler(this.BoxOfY_TextChanged);
            this.BoxOfY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressY);
            // 
            // BoxOfZ
            // 
            resources.ApplyResources(this.BoxOfZ, "BoxOfZ");
            this.BoxOfZ.Name = "BoxOfZ";
            this.BoxOfZ.TextChanged += new System.EventHandler(this.BoxOfZ_TextChanged);
            this.BoxOfZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PressZ);
            // 
            // ResultBox
            // 
            resources.ApplyResources(this.ResultBox, "ResultBox");
            this.ResultBox.BackColor = System.Drawing.SystemColors.Control;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Execute
            // 
            resources.ApplyResources(this.Execute, "Execute");
            this.Execute.Name = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.BoxOfZ);
            this.Controls.Add(this.BoxOfY);
            this.Controls.Add(this.BoxOfX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxOfX;
        private System.Windows.Forms.TextBox BoxOfY;
        private System.Windows.Forms.TextBox BoxOfZ;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Execute;
    }
}

