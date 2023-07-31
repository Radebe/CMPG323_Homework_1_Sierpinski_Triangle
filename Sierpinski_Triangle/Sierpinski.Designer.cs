namespace Sierpinski_Triangle
{
    partial class Sierpinski
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Location = new System.Drawing.Point(12, 3);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(824, 452);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // Sierpinski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 467);
            this.Controls.Add(this.pnlDraw);
            this.Name = "Sierpinski";
            this.Text = "Sierpinski Triangle";
            this.Load += new System.EventHandler(this.Sierpinski_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
    }
}

