namespace TPagenciadeviajes
{
    partial class VuelosForm
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
            VuelosListView = new ListView();
            asiento = new ColumnHeader();
            origenvuelo = new ColumnHeader();
            destinovuelo = new ColumnHeader();
            salidavuelo = new ColumnHeader();
            arribovuelo = new ColumnHeader();
            precio = new ColumnHeader();
            Clase = new ColumnHeader();
            Pasajero = new ColumnHeader();
            Codigo = new ColumnHeader();
            groupBox2 = new GroupBox();
            CancelarBtn = new Button();
            label1 = new Label();
            DestinoVuelosComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            FechaLlegadaPicker = new DateTimePicker();
            FechaSalidaPicker = new DateTimePicker();
            Hasta = new Label();
            label7 = new Label();
            Buscarvuelo = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox5 = new GroupBox();
            ClasescheckedListBox = new CheckedListBox();
            OrigenVuelosComboBox = new ComboBox();
            label2 = new Label();
            groupBox4 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            button5 = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // VuelosListView
            // 
            VuelosListView.Columns.AddRange(new ColumnHeader[] { asiento, origenvuelo, destinovuelo, salidavuelo, arribovuelo, precio, Clase, Pasajero, Codigo });
            VuelosListView.FullRowSelect = true;
            VuelosListView.GridLines = true;
            VuelosListView.Location = new Point(21, 28);
            VuelosListView.Margin = new Padding(3, 4, 3, 4);
            VuelosListView.Name = "VuelosListView";
            VuelosListView.Size = new Size(782, 518);
            VuelosListView.TabIndex = 2;
            VuelosListView.UseCompatibleStateImageBehavior = false;
            VuelosListView.View = View.Details;
            // 
            // asiento
            // 
            asiento.Text = "Asiento Nº";
            asiento.Width = 90;
            // 
            // origenvuelo
            // 
            origenvuelo.Text = "Origen";
            origenvuelo.Width = 65;
            // 
            // destinovuelo
            // 
            destinovuelo.Text = "Destino";
            destinovuelo.Width = 65;
            // 
            // salidavuelo
            // 
            salidavuelo.Text = "Fecha de salida";
            salidavuelo.Width = 65;
            // 
            // arribovuelo
            // 
            arribovuelo.Text = "Fecha de arribo";
            arribovuelo.Width = 130;
            // 
            // precio
            // 
            precio.DisplayIndex = 7;
            precio.Text = "Precio";
            precio.Width = 65;
            // 
            // Clase
            // 
            Clase.DisplayIndex = 5;
            Clase.Text = "Clase ";
            // 
            // Pasajero
            // 
            Pasajero.DisplayIndex = 6;
            Pasajero.Text = "Tipo Pasajero";
            Pasajero.Width = 110;
            // 
            // Codigo
            // 
            Codigo.Text = "Cod vuelo";
            Codigo.Width = 100;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(VuelosListView);
            groupBox2.Location = new Point(307, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(809, 554);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vuelos disponibles";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // CancelarBtn
            // 
            CancelarBtn.Location = new Point(747, 586);
            CancelarBtn.Margin = new Padding(3, 4, 3, 4);
            CancelarBtn.Name = "CancelarBtn";
            CancelarBtn.Size = new Size(369, 47);
            CancelarBtn.TabIndex = 5;
            CancelarBtn.Text = "Cancelar";
            CancelarBtn.UseVisualStyleBackColor = true;
            CancelarBtn.Click += CancelarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 83);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Destino";
            // 
            // DestinoVuelosComboBox
            // 
            DestinoVuelosComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DestinoVuelosComboBox.FormattingEnabled = true;
            DestinoVuelosComboBox.Items.AddRange(new object[] { "Buenos Aires", "Rio de Janeiro", "Paris", "Roma", "Tokio", "Delhi", "São Paulo", "Shanghai", "El Cairo", "Bombay", "Pekín", "Dubai", "Madrid" });
            DestinoVuelosComboBox.Location = new Point(0, 107);
            DestinoVuelosComboBox.Margin = new Padding(3, 4, 3, 4);
            DestinoVuelosComboBox.Name = "DestinoVuelosComboBox";
            DestinoVuelosComboBox.Size = new Size(269, 28);
            DestinoVuelosComboBox.TabIndex = 9;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(FechaLlegadaPicker);
            groupBox3.Controls.Add(FechaSalidaPicker);
            groupBox3.Controls.Add(Hasta);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(0, 437);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(269, 141);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha";
            // 
            // FechaLlegadaPicker
            // 
            FechaLlegadaPicker.Location = new Point(89, 91);
            FechaLlegadaPicker.Margin = new Padding(3, 4, 3, 4);
            FechaLlegadaPicker.Name = "FechaLlegadaPicker";
            FechaLlegadaPicker.Size = new Size(121, 27);
            FechaLlegadaPicker.TabIndex = 5;
            // 
            // FechaSalidaPicker
            // 
            FechaSalidaPicker.Location = new Point(89, 43);
            FechaSalidaPicker.Margin = new Padding(3, 4, 3, 4);
            FechaSalidaPicker.Name = "FechaSalidaPicker";
            FechaSalidaPicker.Size = new Size(121, 27);
            FechaSalidaPicker.TabIndex = 4;
            // 
            // Hasta
            // 
            Hasta.AutoSize = true;
            Hasta.Location = new Point(13, 91);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(47, 20);
            Hasta.TabIndex = 3;
            Hasta.Text = "Hasta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 43);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 1;
            label7.Text = "Desde";
            // 
            // Buscarvuelo
            // 
            Buscarvuelo.Location = new Point(0, 586);
            Buscarvuelo.Margin = new Padding(3, 4, 3, 4);
            Buscarvuelo.Name = "Buscarvuelo";
            Buscarvuelo.Size = new Size(269, 31);
            Buscarvuelo.TabIndex = 10;
            Buscarvuelo.Text = "Buscar";
            Buscarvuelo.UseVisualStyleBackColor = true;
            Buscarvuelo.Click += Buscarvuelo_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 100);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 24);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Infante";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 64);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(73, 24);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Menor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(7, 29);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 24);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Adulto";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(OrigenVuelosComboBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(Buscarvuelo);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(DestinoVuelosComboBox);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(289, 625);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aplicar filtros";
            groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ClasescheckedListBox);
            groupBox5.Location = new Point(6, 149);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(263, 150);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Clase";
            // 
            // ClasescheckedListBox
            // 
            ClasescheckedListBox.CheckOnClick = true;
            ClasescheckedListBox.FormattingEnabled = true;
            ClasescheckedListBox.Items.AddRange(new object[] { "Economy", "Turist", "Business", "First" });
            ClasescheckedListBox.Location = new Point(7, 26);
            ClasescheckedListBox.Name = "ClasescheckedListBox";
            ClasescheckedListBox.Size = new Size(238, 114);
            ClasescheckedListBox.TabIndex = 21;
            ClasescheckedListBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // OrigenVuelosComboBox
            // 
            OrigenVuelosComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OrigenVuelosComboBox.FormattingEnabled = true;
            OrigenVuelosComboBox.Items.AddRange(new object[] { "Buenos Aires", "Rio de Janeiro", "Paris", "Roma", "Tokio", "Delhi", "São Paulo", "Shanghai", "El Cairo", "Bombay", "Pekín", "Dubai", "Madrid" });
            OrigenVuelosComboBox.Location = new Point(0, 52);
            OrigenVuelosComboBox.Margin = new Padding(3, 4, 3, 4);
            OrigenVuelosComboBox.Name = "OrigenVuelosComboBox";
            OrigenVuelosComboBox.Size = new Size(269, 28);
            OrigenVuelosComboBox.TabIndex = 20;
            OrigenVuelosComboBox.DropDown += VuelosOrigen_SelectedIndexChanged;
            OrigenVuelosComboBox.SelectedIndexChanged += VuelosOrigen_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Origen";
            label2.Click += label2_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numericUpDown3);
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Location = new Point(0, 306);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(269, 137);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pasajeros";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(89, 100);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 17;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(89, 62);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(89, 29);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 15;
            // 
            // button5
            // 
            button5.Location = new Point(328, 586);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(403, 47);
            button5.TabIndex = 11;
            button5.Text = "Agregar itinerario";
            button5.UseVisualStyleBackColor = true;
            // 
            // VuelosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 657);
            Controls.Add(button5);
            Controls.Add(CancelarBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VuelosForm";
            Text = "Vuelos";
            Load += Vuelos_Load;
            
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListView VuelosListView;
        private GroupBox groupBox2;
        private Button CancelarBtn;
        private ColumnHeader asiento;
        private ColumnHeader origenvuelo;
        private ColumnHeader destinovuelo;
        private ColumnHeader salidavuelo;
        private ColumnHeader arribovuelo;
        private ColumnHeader Clase;
        private ColumnHeader precio;
        private ColumnHeader Pasajero;
        private Label label1;
        private ComboBox DestinoVuelosComboBox;
        private GroupBox groupBox3;
        private DateTimePicker FechaLlegadaPicker;
        private DateTimePicker FechaSalidaPicker;
        private Label Hasta;
        private Label label7;
        private Button Buscarvuelo;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Button button5;
        private ColumnHeader Codigo;
        private ComboBox OrigenVuelosComboBox;
        private Label label2;
        private CheckedListBox ClasescheckedListBox;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox5;
    }
}