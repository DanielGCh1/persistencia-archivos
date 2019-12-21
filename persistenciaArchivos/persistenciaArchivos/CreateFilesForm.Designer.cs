namespace persistenciaArchivos
{
    partial class CreateFilesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFilesForm));
            this.ChequesDataGridView = new System.Windows.Forms.DataGridView();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.CrearArchivoButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UpsertPanel = new System.Windows.Forms.Panel();
            this.ComboBoxMoneda = new System.Windows.Forms.ComboBox();
            this.LabelMoneda = new System.Windows.Forms.Label();
            this.ComboBoxInstitucionFinanciera = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.LabelEmisor = new System.Windows.Forms.Label();
            this.TextBoxEmisor = new System.Windows.Forms.TextBox();
            this.LabelReceptor = new System.Windows.Forms.Label();
            this.TextBoxReceptor = new System.Windows.Forms.TextBox();
            this.MontoLabel = new System.Windows.Forms.Label();
            this.MontoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLlabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.NumeroChequeLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NumeroChequeTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.ListaChequesLabel = new System.Windows.Forms.Label();
            this.InformacionRutaLabel = new System.Windows.Forms.Label();
            this.BorrarRenglonButton = new System.Windows.Forms.Button();
            this.InformationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receptor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstitucionFinanciera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChequeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.DateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.UpsertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ChequesDataGridView
            // 
            this.ChequesDataGridView.AllowUserToAddRows = false;
            this.ChequesDataGridView.AllowUserToDeleteRows = false;
            this.ChequesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChequesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.Emisor,
            this.Receptor,
            this.InstitucionFinanciera,
            this.NumeroChequeColumn,
            this.MontoColumn,
            this.Moneda,
            this.DescripcionColumn});
            this.ChequesDataGridView.Location = new System.Drawing.Point(257, 81);
            this.ChequesDataGridView.Name = "ChequesDataGridView";
            this.ChequesDataGridView.ReadOnly = true;
            this.ChequesDataGridView.Size = new System.Drawing.Size(854, 334);
            this.ChequesDataGridView.TabIndex = 2;
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(279, 430);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 11;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // CrearArchivoButton
            // 
            this.CrearArchivoButton.Location = new System.Drawing.Point(657, 430);
            this.CrearArchivoButton.Name = "CrearArchivoButton";
            this.CrearArchivoButton.Size = new System.Drawing.Size(93, 23);
            this.CrearArchivoButton.TabIndex = 11;
            this.CrearArchivoButton.Text = "Crear Archivo";
            this.CrearArchivoButton.UseVisualStyleBackColor = true;
            this.CrearArchivoButton.Click += new System.EventHandler(this.CrearArchivoButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // UpsertPanel
            // 
            this.UpsertPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UpsertPanel.BackColor = System.Drawing.Color.DarkBlue;
            this.UpsertPanel.Controls.Add(this.DateTimePickerFecha);
            this.UpsertPanel.Controls.Add(this.LabelFecha);
            this.UpsertPanel.Controls.Add(this.ComboBoxMoneda);
            this.UpsertPanel.Controls.Add(this.LabelMoneda);
            this.UpsertPanel.Controls.Add(this.ComboBoxInstitucionFinanciera);
            this.UpsertPanel.Controls.Add(this.Label1);
            this.UpsertPanel.Controls.Add(this.LabelEmisor);
            this.UpsertPanel.Controls.Add(this.TextBoxEmisor);
            this.UpsertPanel.Controls.Add(this.LabelReceptor);
            this.UpsertPanel.Controls.Add(this.TextBoxReceptor);
            this.UpsertPanel.Controls.Add(this.MontoLabel);
            this.UpsertPanel.Controls.Add(this.MontoTextBox);
            this.UpsertPanel.Controls.Add(this.DescripcionLlabel);
            this.UpsertPanel.Controls.Add(this.DescripcionTextBox);
            this.UpsertPanel.Controls.Add(this.NumeroChequeLabel);
            this.UpsertPanel.Controls.Add(this.NombreLabel);
            this.UpsertPanel.Controls.Add(this.NumeroChequeTextBox);
            this.UpsertPanel.Controls.Add(this.NombreTextBox);
            this.UpsertPanel.Controls.Add(this.AgregarButton);
            this.UpsertPanel.Controls.Add(this.LimpiarButton);
            this.UpsertPanel.Location = new System.Drawing.Point(0, 0);
            this.UpsertPanel.Name = "UpsertPanel";
            this.UpsertPanel.Size = new System.Drawing.Size(251, 513);
            this.UpsertPanel.TabIndex = 12;
            // 
            // ComboBoxMoneda
            // 
            this.ComboBoxMoneda.FormattingEnabled = true;
            this.ComboBoxMoneda.Location = new System.Drawing.Point(21, 265);
            this.ComboBoxMoneda.Name = "ComboBoxMoneda";
            this.ComboBoxMoneda.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxMoneda.TabIndex = 6;
            // 
            // LabelMoneda
            // 
            this.LabelMoneda.AutoSize = true;
            this.LabelMoneda.ForeColor = System.Drawing.Color.White;
            this.LabelMoneda.Location = new System.Drawing.Point(18, 248);
            this.LabelMoneda.Name = "LabelMoneda";
            this.LabelMoneda.Size = new System.Drawing.Size(46, 13);
            this.LabelMoneda.TabIndex = 27;
            this.LabelMoneda.Text = "Moneda";
            // 
            // ComboBoxInstitucionFinanciera
            // 
            this.ComboBoxInstitucionFinanciera.FormattingEnabled = true;
            this.ComboBoxInstitucionFinanciera.Items.AddRange(new object[] {
            "Banco Nacional",
            "Banco CR",
            "Banco Popular",
            "BAC Credomatic"});
            this.ComboBoxInstitucionFinanciera.Location = new System.Drawing.Point(21, 224);
            this.ComboBoxInstitucionFinanciera.Name = "ComboBoxInstitucionFinanciera";
            this.ComboBoxInstitucionFinanciera.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxInstitucionFinanciera.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(18, 207);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(107, 13);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Institución Financiera";
            // 
            // LabelEmisor
            // 
            this.LabelEmisor.AutoSize = true;
            this.LabelEmisor.ForeColor = System.Drawing.Color.White;
            this.LabelEmisor.Location = new System.Drawing.Point(18, 129);
            this.LabelEmisor.Name = "LabelEmisor";
            this.LabelEmisor.Size = new System.Drawing.Size(38, 13);
            this.LabelEmisor.TabIndex = 24;
            this.LabelEmisor.Text = "Emisor";
            // 
            // TextBoxEmisor
            // 
            this.TextBoxEmisor.Location = new System.Drawing.Point(21, 145);
            this.TextBoxEmisor.Name = "TextBoxEmisor";
            this.TextBoxEmisor.Size = new System.Drawing.Size(205, 20);
            this.TextBoxEmisor.TabIndex = 3;
            // 
            // LabelReceptor
            // 
            this.LabelReceptor.AutoSize = true;
            this.LabelReceptor.ForeColor = System.Drawing.Color.White;
            this.LabelReceptor.Location = new System.Drawing.Point(18, 168);
            this.LabelReceptor.Name = "LabelReceptor";
            this.LabelReceptor.Size = new System.Drawing.Size(51, 13);
            this.LabelReceptor.TabIndex = 22;
            this.LabelReceptor.Text = "Receptor";
            // 
            // TextBoxReceptor
            // 
            this.TextBoxReceptor.Location = new System.Drawing.Point(21, 184);
            this.TextBoxReceptor.Name = "TextBoxReceptor";
            this.TextBoxReceptor.Size = new System.Drawing.Size(205, 20);
            this.TextBoxReceptor.TabIndex = 4;
            // 
            // MontoLabel
            // 
            this.MontoLabel.AutoSize = true;
            this.MontoLabel.ForeColor = System.Drawing.Color.White;
            this.MontoLabel.Location = new System.Drawing.Point(18, 90);
            this.MontoLabel.Name = "MontoLabel";
            this.MontoLabel.Size = new System.Drawing.Size(110, 13);
            this.MontoLabel.TabIndex = 20;
            this.MontoLabel.Text = "Monto (Solo números)";
            // 
            // MontoTextBox
            // 
            this.MontoTextBox.Location = new System.Drawing.Point(21, 106);
            this.MontoTextBox.Name = "MontoTextBox";
            this.MontoTextBox.Size = new System.Drawing.Size(205, 20);
            this.MontoTextBox.TabIndex = 2;
            // 
            // DescripcionLlabel
            // 
            this.DescripcionLlabel.AutoSize = true;
            this.DescripcionLlabel.ForeColor = System.Drawing.Color.White;
            this.DescripcionLlabel.Location = new System.Drawing.Point(18, 355);
            this.DescripcionLlabel.Name = "DescripcionLlabel";
            this.DescripcionLlabel.Size = new System.Drawing.Size(212, 13);
            this.DescripcionLlabel.TabIndex = 18;
            this.DescripcionLlabel.Text = "Descripción( min 10 caractéres, encriptada)";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(21, 371);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(205, 97);
            this.DescripcionTextBox.TabIndex = 7;
            // 
            // NumeroChequeLabel
            // 
            this.NumeroChequeLabel.AutoSize = true;
            this.NumeroChequeLabel.ForeColor = System.Drawing.Color.White;
            this.NumeroChequeLabel.Location = new System.Drawing.Point(18, 51);
            this.NumeroChequeLabel.Name = "NumeroChequeLabel";
            this.NumeroChequeLabel.Size = new System.Drawing.Size(185, 13);
            this.NumeroChequeLabel.TabIndex = 16;
            this.NumeroChequeLabel.Text = "Número de cheque (min 5 caractéres)";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.ForeColor = System.Drawing.Color.White;
            this.NombreLabel.Location = new System.Drawing.Point(18, 12);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(131, 13);
            this.NombreLabel.TabIndex = 15;
            this.NombreLabel.Text = "Nombre (min 3 caractéres)";
            // 
            // NumeroChequeTextBox
            // 
            this.NumeroChequeTextBox.Location = new System.Drawing.Point(21, 67);
            this.NumeroChequeTextBox.Name = "NumeroChequeTextBox";
            this.NumeroChequeTextBox.Size = new System.Drawing.Size(205, 20);
            this.NumeroChequeTextBox.TabIndex = 1;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(21, 28);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(205, 20);
            this.NombreTextBox.TabIndex = 0;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(151, 474);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 8;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Location = new System.Drawing.Point(21, 474);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(75, 23);
            this.LimpiarButton.TabIndex = 11;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // ListaChequesLabel
            // 
            this.ListaChequesLabel.AutoSize = true;
            this.ListaChequesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListaChequesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaChequesLabel.ForeColor = System.Drawing.Color.Black;
            this.ListaChequesLabel.Location = new System.Drawing.Point(448, 12);
            this.ListaChequesLabel.Name = "ListaChequesLabel";
            this.ListaChequesLabel.Size = new System.Drawing.Size(169, 24);
            this.ListaChequesLabel.TabIndex = 15;
            this.ListaChequesLabel.Text = "Lista de cheques";
            // 
            // InformacionRutaLabel
            // 
            this.InformacionRutaLabel.Location = new System.Drawing.Point(279, 37);
            this.InformacionRutaLabel.Name = "InformacionRutaLabel";
            this.InformacionRutaLabel.Size = new System.Drawing.Size(471, 41);
            this.InformacionRutaLabel.TabIndex = 16;
            this.InformacionRutaLabel.Text = "@InformacionRutaArchivos";
            // 
            // BorrarRenglonButton
            // 
            this.BorrarRenglonButton.Location = new System.Drawing.Point(390, 430);
            this.BorrarRenglonButton.Name = "BorrarRenglonButton";
            this.BorrarRenglonButton.Size = new System.Drawing.Size(95, 23);
            this.BorrarRenglonButton.TabIndex = 11;
            this.BorrarRenglonButton.Text = "Borrar renglón";
            this.BorrarRenglonButton.UseVisualStyleBackColor = true;
            this.BorrarRenglonButton.Click += new System.EventHandler(this.BorrarRenglonButton_Click);
            // 
            // InformationProvider
            // 
            this.InformationProvider.ContainerControl = this;
            this.InformationProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InformationProvider.Icon")));
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(532, 430);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(85, 23);
            this.buttonAgregar.TabIndex = 17;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // Emisor
            // 
            this.Emisor.HeaderText = "Emisor";
            this.Emisor.Name = "Emisor";
            this.Emisor.ReadOnly = true;
            // 
            // Receptor
            // 
            this.Receptor.HeaderText = "Receptor";
            this.Receptor.Name = "Receptor";
            this.Receptor.ReadOnly = true;
            // 
            // InstitucionFinanciera
            // 
            this.InstitucionFinanciera.HeaderText = "Institucion Financiera";
            this.InstitucionFinanciera.Name = "InstitucionFinanciera";
            this.InstitucionFinanciera.ReadOnly = true;
            // 
            // NumeroChequeColumn
            // 
            this.NumeroChequeColumn.HeaderText = "Número Cheque";
            this.NumeroChequeColumn.Name = "NumeroChequeColumn";
            this.NumeroChequeColumn.ReadOnly = true;
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto en Colones";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripción";
            this.DescripcionColumn.Name = "DescripcionColumn";
            this.DescripcionColumn.ReadOnly = true;
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.ForeColor = System.Drawing.Color.White;
            this.LabelFecha.Location = new System.Drawing.Point(18, 289);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(83, 13);
            this.LabelFecha.TabIndex = 28;
            this.LabelFecha.Text = "Ingrese la fecha";
            // 
            // DateTimePickerFecha
            // 
            this.DateTimePickerFecha.Location = new System.Drawing.Point(21, 317);
            this.DateTimePickerFecha.Name = "DateTimePickerFecha";
            this.DateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerFecha.TabIndex = 29;
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 509);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.InformacionRutaLabel);
            this.Controls.Add(this.BorrarRenglonButton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.UpsertPanel);
            this.Controls.Add(this.CrearArchivoButton);
            this.Controls.Add(this.ChequesDataGridView);
            this.Controls.Add(this.ListaChequesLabel);
            this.Name = "CreateFilesForm";
            this.Text = "Información de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateFilesForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChequesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.UpsertPanel.ResumeLayout(false);
            this.UpsertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InformationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ChequesDataGridView;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button CrearArchivoButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel UpsertPanel;
        private System.Windows.Forms.Label MontoLabel;
        private System.Windows.Forms.TextBox MontoTextBox;
        private System.Windows.Forms.Label DescripcionLlabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label NumeroChequeLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NumeroChequeTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label InformacionRutaLabel;
        private System.Windows.Forms.Label ListaChequesLabel;
        private System.Windows.Forms.Button BorrarRenglonButton;
        private System.Windows.Forms.ErrorProvider InformationProvider;
        private System.Windows.Forms.Label LabelEmisor;
        private System.Windows.Forms.TextBox TextBoxEmisor;
        private System.Windows.Forms.Label LabelReceptor;
        private System.Windows.Forms.TextBox TextBoxReceptor;
        private System.Windows.Forms.ComboBox ComboBoxInstitucionFinanciera;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox ComboBoxMoneda;
        private System.Windows.Forms.Label LabelMoneda;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receptor;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstitucionFinanciera;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChequeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.DateTimePicker DateTimePickerFecha;
    }
}

