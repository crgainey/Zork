
namespace Zork.Builder.UserControls
{
    partial class NeighborUserControl
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
            this.neighborComboBox = new System.Windows.Forms.ComboBox();
            this.neighborTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // neighborComboBox
            // 
            this.neighborComboBox.DisplayMember = "Names";
            this.neighborComboBox.FormattingEnabled = true;
            this.neighborComboBox.Location = new System.Drawing.Point(3, 30);
            this.neighborComboBox.Name = "neighborComboBox";
            this.neighborComboBox.Size = new System.Drawing.Size(153, 21);
            this.neighborComboBox.TabIndex = 3;
            this.neighborComboBox.SelectedIndexChanged += new System.EventHandler(this.neighborComboBox_SelectedIndexChanged);
            // 
            // neighborTextBox
            // 
            this.neighborTextBox.Location = new System.Drawing.Point(4, 4);
            this.neighborTextBox.Name = "neighborTextBox";
            this.neighborTextBox.ReadOnly = true;
            this.neighborTextBox.Size = new System.Drawing.Size(153, 20);
            this.neighborTextBox.TabIndex = 2;
            this.neighborTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NeighborUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborComboBox);
            this.Controls.Add(this.neighborTextBox);
            this.Name = "NeighborUserControl";
            this.Size = new System.Drawing.Size(160, 57);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox neighborComboBox;
        private System.Windows.Forms.TextBox neighborTextBox;
    }
}
