
namespace pr2._1_Коршикова
{
    partial class ZnachFunc
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
            this.btnPusk = new System.Windows.Forms.Button();
            this.btnOchistit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtVivod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPusk
            // 
            this.btnPusk.Location = new System.Drawing.Point(25, 401);
            this.btnPusk.Name = "btnPusk";
            this.btnPusk.Size = new System.Drawing.Size(113, 23);
            this.btnPusk.TabIndex = 0;
            this.btnPusk.Text = "Пуск";
            this.btnPusk.UseVisualStyleBackColor = true;
            this.btnPusk.Click += new System.EventHandler(this.btnPusk_Click);
            // 
            // btnOchistit
            // 
            this.btnOchistit.Location = new System.Drawing.Point(180, 401);
            this.btnOchistit.Name = "btnOchistit";
            this.btnOchistit.Size = new System.Drawing.Size(109, 23);
            this.btnOchistit.TabIndex = 1;
            this.btnOchistit.Text = "Очистить";
            this.btnOchistit.UseVisualStyleBackColor = true;
            this.btnOchistit.Click += new System.EventHandler(this.btnOchistit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Z =";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(72, 32);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 5;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(72, 73);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 6;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(72, 114);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 20);
            this.txtZ.TabIndex = 7;
            // 
            // txtVivod
            // 
            this.txtVivod.Location = new System.Drawing.Point(25, 156);
            this.txtVivod.Multiline = true;
            this.txtVivod.Name = "txtVivod";
            this.txtVivod.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtVivod.Size = new System.Drawing.Size(264, 218);
            this.txtVivod.TabIndex = 8;
            // 
            // ZnachFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.txtVivod);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOchistit);
            this.Controls.Add(this.btnPusk);
            this.Name = "ZnachFunc";
            this.Text = "Значение функции";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPusk;
        private System.Windows.Forms.Button btnOchistit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtVivod;
    }
}

