namespace UWeekBoxGame
{
    partial class Box
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.btnBox = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnBox
            // 
            this.btnBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
            this.btnBox.BorderRadius = 10;
            this.btnBox.BorderThickness = 5;
            this.btnBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBox.CustomizableEdges = customizableEdges1;
            this.btnBox.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBox.DisabledState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(89)))), ((int)(((byte)(146)))));
            this.btnBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBox.ForeColor = System.Drawing.Color.White;
            this.btnBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.btnBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.btnBox.Image = ((System.Drawing.Image)(resources.GetObject("btnBox.Image")));
            this.btnBox.ImageSize = new System.Drawing.Size(50, 45);
            this.btnBox.Location = new System.Drawing.Point(3, 3);
            this.btnBox.Name = "btnBox";
            this.btnBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnBox.Size = new System.Drawing.Size(114, 84);
            this.btnBox.TabIndex = 0;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBox);
            this.MaximumSize = new System.Drawing.Size(120, 90);
            this.MinimumSize = new System.Drawing.Size(110, 80);
            this.Name = "Box";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(120, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBox;
    }
}
