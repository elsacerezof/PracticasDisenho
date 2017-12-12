using System.Windows.Forms;
using System;

namespace Pr_06_Observer
{
    /// <summary>
    ///     Esta clase proporciona una interfaz gráfica para navegar
    ///     por el sistema de archivos Sparrow. Su diseño es simple:
    ///     A la izquierda se presenta en forma de árbol el sistema 
    ///     de archivos y a la derecha se muestra información del 
    ///     nodo que esté actualmente seleccionado.
    ///     
    ///     Esta clase parcial contiene concretamente el código 
    ///     necesario para generar la apariencia gráfica del 
    ///     formulario. Este código es automáticamente generado por 
    ///     Visual Studio y no debería modificarse a mano, salvo 
    ///     que se posean los conocimientos necesarios para ello.
    /// </summary>
    partial class FileExplorerView
    {
        /// <summary>
        ///     Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///     Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        ///     Método necesario para admitir el Diseñador. No se puede modificar
        ///     el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileSystemTreeViewer = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spv_ElementViewer = new SparrowElementViewerCtrl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            
            // FileSystemTreeViewer
            // 
            this.FileSystemTreeViewer.Location = new System.Drawing.Point(11, 13);
            this.FileSystemTreeViewer.Name = "FileSystemTreeViewer";
            this.FileSystemTreeViewer.Size = new System.Drawing.Size(457, 439);
            this.FileSystemTreeViewer.TabIndex = 0;
            this.FileSystemTreeViewer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.onElementSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spv_ElementViewer);
            this.groupBox1.Location = new System.Drawing.Point(484, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elemento";
            // 
            // spv_ElementViewer
            // 
            this.spv_ElementViewer.BackColor = System.Drawing.SystemColors.Window;
            this.spv_ElementViewer.Location = new System.Drawing.Point(10, 19);
            this.spv_ElementViewer.Name = "spv_ElementViewer";
            this.spv_ElementViewer.Size = new System.Drawing.Size(299, 51);
            this.spv_ElementViewer.SparrowElement = null;
            this.spv_ElementViewer.TabIndex = 0;
            // 
            // FileExplorerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileSystemTreeViewer);
            this.Name = "FileExplorerView";
            this.Text = "Sparrow File Explorer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView FileSystemTreeViewer;
        private GroupBox groupBox1;
        private SparrowElementViewerCtrl spv_ElementViewer;
    }
}

