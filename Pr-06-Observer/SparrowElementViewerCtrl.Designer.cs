using System.Windows.Forms;

namespace Pr_06_Observer
{
    partial class SparrowElementViewerCtrl
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbl_Layout = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Size = new System.Windows.Forms.Label();
            this.lb_NameText = new System.Windows.Forms.Label();
            this.lb_SizeText = new System.Windows.Forms.Label();
            this.tbl_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_Layout
            // 
            this.tbl_Layout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbl_Layout.ColumnCount = 2;
            this.tbl_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.54867F));
            this.tbl_Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.45132F));
            this.tbl_Layout.Controls.Add(this.lb_Name, 0, 0);
            this.tbl_Layout.Controls.Add(this.lb_Size, 0, 1);
            this.tbl_Layout.Controls.Add(this.lb_NameText, 1, 0);
            this.tbl_Layout.Controls.Add(this.lb_SizeText, 1, 1);
            this.tbl_Layout.Location = new System.Drawing.Point(0, 0);
            this.tbl_Layout.Name = "tbl_Layout";
            this.tbl_Layout.RowCount = 2;
            this.tbl_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Layout.Size = new System.Drawing.Size(299, 45);
            this.tbl_Layout.TabIndex = 0;
            // 
            // lb_Name
            // 
            this.lb_Name.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(4, 5);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(44, 13);
            this.lb_Name.TabIndex = 0;
            this.lb_Name.Text = "Nombre";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Size
            // 
            this.lb_Size.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_Size.AutoSize = true;
            this.lb_Size.Location = new System.Drawing.Point(4, 27);
            this.lb_Size.Name = "lb_Size";
            this.lb_Size.Size = new System.Drawing.Size(46, 13);
            this.lb_Size.TabIndex = 1;
            this.lb_Size.Text = "Tamaño";
            // 
            // lb_NameText
            // 
            this.lb_NameText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_NameText.AutoSize = true;
            this.lb_NameText.Location = new System.Drawing.Point(83, 5);
            this.lb_NameText.Name = "lb_NameText";
            this.lb_NameText.Size = new System.Drawing.Size(10, 13);
            this.lb_NameText.TabIndex = 2;
            this.lb_NameText.Text = "-";
            // 
            // lb_SizeText
            // 
            this.lb_SizeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb_SizeText.AutoSize = true;
            this.lb_SizeText.Location = new System.Drawing.Point(83, 27);
            this.lb_SizeText.Name = "lb_SizeText";
            this.lb_SizeText.Size = new System.Drawing.Size(10, 13);
            this.lb_SizeText.TabIndex = 3;
            this.lb_SizeText.Text = "-";
            // 
            // SparrowElementViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl_Layout);
            this.Name = "SparrowElementViewer";
            this.Size = new System.Drawing.Size(302, 45);
            this.Resize += new System.EventHandler(this.SparrowElementViewer_Resize);
            this.tbl_Layout.ResumeLayout(false);
            this.tbl_Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbl_Layout;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Size;
        private System.Windows.Forms.Label lb_NameText;
        private System.Windows.Forms.Label lb_SizeText;
    }
}
