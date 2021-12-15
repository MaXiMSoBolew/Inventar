
namespace Inventar
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
            this.inv1 = new Inventar.Inv();
            this.cell1 = new Inventar.Cell();
            this.cell2 = new Inventar.Cell();
            ((System.ComponentModel.ISupportInitialize)(this.cell1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell2)).BeginInit();
            this.SuspendLayout();
            // 
            // inv1
            // 
            this.inv1.Count = 4;
            this.inv1.Location = new System.Drawing.Point(12, 12);
            this.inv1.Name = "inv1";
            this.inv1.Size = new System.Drawing.Size(404, 404);
            this.inv1.TabIndex = 0;
            // 
            // cell1
            // 
            this.cell1.AllowDrop = true;
            this.cell1.cnt = 0;
            this.cell1.Image = ((System.Drawing.Image)(resources.GetObject("cell1.Image")));
            this.cell1.Location = new System.Drawing.Point(529, 12);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(100, 100);
            this.cell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell1.TabIndex = 1;
            this.cell1.TabStop = false;
            this.cell1.Click += new System.EventHandler(this.cell1_Click);
            // 
            // cell2
            // 
            this.cell2.AllowDrop = true;
            this.cell2.cnt = 0;
            this.cell2.Image = ((System.Drawing.Image)(resources.GetObject("cell2.Image")));
            this.cell2.Location = new System.Drawing.Point(529, 148);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(100, 100);
            this.cell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cell2.TabIndex = 2;
            this.cell2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cell2);
            this.Controls.Add(this.cell1);
            this.Controls.Add(this.inv1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cell1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Inv inv1;
        private Cell cell1;
        private Cell cell2;
    }
}

