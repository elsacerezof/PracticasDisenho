namespace Pr_06_Observer
{

    /// <summary>
    ///    Clase gráfica con apariencia escasamente profesional cuyo único 
    ///    objetivo es permitir la edición de los nombres de los elementos
    ///    del sistema de archivos Sparrow.
    ///    
    ///    Se compone de una matriz de datos con una única columna que 
    ///    muestra los nombres, alfabéticamente ordenados, de los diferentes
    ///    elementos que conforman un determinado sistema de archivos.
    ///     
    ///     Esta clase parcial contiene concretamente el código 
    ///     necesario para generar la apariencia gráfica del 
    ///     formulario. Este código es automáticamente generado por 
    ///     Visual Studio y no debería modificarse a mano, salvo 
    ///     que se posean los conocimientos necesarios para ello.
    /// </summary>
    partial class FileNameEditor
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
            this.gv_ElementsView = new System.Windows.Forms.DataGridView();
            this.ElementoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ElementsView)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_ElementsView
            // 
            this.gv_ElementsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ElementsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ElementoColumn});
            this.gv_ElementsView.Location = new System.Drawing.Point(12, 12);
            this.gv_ElementsView.Name = "gv_ElementsView";
            this.gv_ElementsView.Size = new System.Drawing.Size(272, 360);
            this.gv_ElementsView.TabIndex = 0;
            this.gv_ElementsView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.onCellBeginEdit);
            this.gv_ElementsView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.onCellEndEdit);
            // 
            // ElementoColumn
            // 
            this.ElementoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ElementoColumn.HeaderText = "Elemento";
            this.ElementoColumn.Name = "ElementoColumn";
            // 
            // FileNameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 386);
            this.Controls.Add(this.gv_ElementsView);
            this.Name = "FileNameEditor";
            this.Text = "FileNameEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onClose);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ElementsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_ElementsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElementoColumn;
    }
}