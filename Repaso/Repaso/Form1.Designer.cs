namespace Repaso
{
    partial class PersonasForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListaPersonasGroupBox = new GroupBox();
            EliminarBtn = new Button();
            ModificarBtn = new Button();
            NuevoBtn = new Button();
            PersonaslistView = new ListView();
            NombreHeader1 = new ColumnHeader();
            ApellidoHeader2 = new ColumnHeader();
            DocumentoHeader3 = new ColumnHeader();
            TelefonoHeader4 = new ColumnHeader();
            EditgroupBox = new GroupBox();
            ApellidoTextBox = new TextBox();
            TelefonoTextBox = new TextBox();
            label4 = new Label();
            DocumentoTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            NombreTextBox = new TextBox();
            NombreLabel = new Label();
            CancelarBtn = new Button();
            AceptarBtn = new Button();
            ListaPersonasGroupBox.SuspendLayout();
            EditgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ListaPersonasGroupBox
            // 
            ListaPersonasGroupBox.Controls.Add(EliminarBtn);
            ListaPersonasGroupBox.Controls.Add(ModificarBtn);
            ListaPersonasGroupBox.Controls.Add(NuevoBtn);
            ListaPersonasGroupBox.Controls.Add(PersonaslistView);
            ListaPersonasGroupBox.Location = new Point(16, 12);
            ListaPersonasGroupBox.Name = "ListaPersonasGroupBox";
            ListaPersonasGroupBox.Size = new Size(772, 264);
            ListaPersonasGroupBox.TabIndex = 15;
            ListaPersonasGroupBox.TabStop = false;
            ListaPersonasGroupBox.BackColorChanged += EliminarBtn_Click;
            // 
            // EliminarBtn
            // 
            EliminarBtn.Location = new Point(466, 15);
            EliminarBtn.Name = "EliminarBtn";
            EliminarBtn.Size = new Size(94, 29);
            EliminarBtn.TabIndex = 8;
            EliminarBtn.Text = "Eliminar";
            EliminarBtn.UseVisualStyleBackColor = true;
            EliminarBtn.Enter += EliminarBtn_Click;
            // 
            // ModificarBtn
            // 
            ModificarBtn.Location = new Point(566, 15);
            ModificarBtn.Name = "ModificarBtn";
            ModificarBtn.Size = new Size(94, 29);
            ModificarBtn.TabIndex = 7;
            ModificarBtn.Text = "Modificar";
            ModificarBtn.UseVisualStyleBackColor = true;
            ModificarBtn.Click += ModificarBtn_Click;
            // 
            // NuevoBtn
            // 
            NuevoBtn.Location = new Point(666, 15);
            NuevoBtn.Name = "NuevoBtn";
            NuevoBtn.Size = new Size(94, 29);
            NuevoBtn.TabIndex = 6;
            NuevoBtn.Text = "Nuevo";
            NuevoBtn.UseVisualStyleBackColor = true;
            // 
            // PersonaslistView
            // 
            PersonaslistView.Columns.AddRange(new ColumnHeader[] { NombreHeader1, ApellidoHeader2, DocumentoHeader3, TelefonoHeader4 });
            PersonaslistView.FullRowSelect = true;
            PersonaslistView.Location = new Point(12, 50);
            PersonaslistView.Name = "PersonaslistView";
            PersonaslistView.Size = new Size(748, 208);
            PersonaslistView.TabIndex = 5;
            PersonaslistView.UseCompatibleStateImageBehavior = false;
            PersonaslistView.View = View.Details;
            // 
            // NombreHeader1
            // 
            NombreHeader1.Text = "Nombre";
            NombreHeader1.Width = 120;
            // 
            // ApellidoHeader2
            // 
            ApellidoHeader2.Text = "Apellido";
            ApellidoHeader2.Width = 120;
            // 
            // DocumentoHeader3
            // 
            DocumentoHeader3.Text = "Documento";
            DocumentoHeader3.Width = 120;
            // 
            // TelefonoHeader4
            // 
            TelefonoHeader4.Text = "Telefono";
            TelefonoHeader4.Width = 120;
            // 
            // EditgroupBox
            // 
            EditgroupBox.Controls.Add(ApellidoTextBox);
            EditgroupBox.Controls.Add(TelefonoTextBox);
            EditgroupBox.Controls.Add(label4);
            EditgroupBox.Controls.Add(DocumentoTextBox);
            EditgroupBox.Controls.Add(label3);
            EditgroupBox.Controls.Add(label2);
            EditgroupBox.Controls.Add(NombreTextBox);
            EditgroupBox.Controls.Add(NombreLabel);
            EditgroupBox.Controls.Add(CancelarBtn);
            EditgroupBox.Controls.Add(AceptarBtn);
            EditgroupBox.Location = new Point(28, 293);
            EditgroupBox.Name = "EditgroupBox";
            EditgroupBox.Size = new Size(760, 206);
            EditgroupBox.TabIndex = 16;
            EditgroupBox.TabStop = false;
            // 
            // ApellidoTextBox
            // 
            ApellidoTextBox.Location = new Point(259, 80);
            ApellidoTextBox.Name = "ApellidoTextBox";
            ApellidoTextBox.Size = new Size(206, 27);
            ApellidoTextBox.TabIndex = 24;
            ApellidoTextBox.TextChanged += ApellidoTextBox_TextChanged;
            // 
            // TelefonoTextBox
            // 
            TelefonoTextBox.Location = new Point(259, 134);
            TelefonoTextBox.Name = "TelefonoTextBox";
            TelefonoTextBox.Size = new Size(206, 27);
            TelefonoTextBox.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 111);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 22;
            label4.Text = "Telefono";
            // 
            // DocumentoTextBox
            // 
            DocumentoTextBox.Location = new Point(6, 134);
            DocumentoTextBox.Name = "DocumentoTextBox";
            DocumentoTextBox.Size = new Size(190, 27);
            DocumentoTextBox.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 20;
            label3.Text = "Documento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(259, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 19;
            label2.Text = "Apellido";
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(6, 80);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(190, 27);
            NombreTextBox.TabIndex = 18;
            // 
            // NombreLabel
            // 
            NombreLabel.AutoSize = true;
            NombreLabel.Location = new Point(6, 57);
            NombreLabel.Name = "NombreLabel";
            NombreLabel.Size = new Size(64, 20);
            NombreLabel.TabIndex = 17;
            NombreLabel.Text = "Nombre";
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(653, 100);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(94, 29);
            CancelarBtn.TabIndex = 16;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // AceptarBtn
            // 
            AceptarBtn.Location = new Point(553, 100);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(94, 29);
            AceptarBtn.TabIndex = 15;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // PersonasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(EditgroupBox);
            Controls.Add(ListaPersonasGroupBox);
            Name = "PersonasForm";
            Text = "Personas";
            Load += PersonasForm_Load;
            ListaPersonasGroupBox.ResumeLayout(false);
            EditgroupBox.ResumeLayout(false);
            EditgroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox ListaPersonasGroupBox;
        private Button EliminarBtn;
        private Button ModificarBtn;
        private Button NuevoBtn;
        private ListView PersonaslistView;
        private ColumnHeader NombreHeader1;
        private ColumnHeader ApellidoHeader2;
        private ColumnHeader DocumentoHeader3;
        private ColumnHeader TelefonoHeader4;
        private GroupBox EditgroupBox;
        private TextBox ApellidoTextBox;
        private TextBox TelefonoTextBox;
        private Label label4;
        private TextBox DocumentoTextBox;
        private Label label3;
        private Label label2;
        private TextBox NombreTextBox;
        private Label NombreLabel;
        private Button CancelarBtn;
        private Button AceptarBtn;
    }
}