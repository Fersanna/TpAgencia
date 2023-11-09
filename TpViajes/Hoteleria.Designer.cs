namespace TPagenciadeviajes
{
    partial class Hoteleria
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            listView1 = new ListView();
            nombrehotel = new ColumnHeader();
            ciudadhotel = new ColumnHeader();
            button1 = new Button();
            hotelcontinuar = new Button();
            button3 = new Button();
            Buscarhotel = new Button();
            groupBox3 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            Hasta = new Label();
            label7 = new Label();
            groupBox4 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            comboBox3 = new ComboBox();
            Precio = new ColumnHeader();
            fechadesde = new ColumnHeader();
            fechahast = new ColumnHeader();
            Pasajero = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(Buscarhotel);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 476);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aplicar filtros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 110);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(121, 71);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 74);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Tarifa diaria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Capacidad maxima";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(422, 288);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { nombrehotel, ciudadhotel, Precio, fechadesde, fechahast, Pasajero, columnHeader1 });
            listView1.Location = new Point(277, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(518, 97);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // nombrehotel
            // 
            nombrehotel.Text = "Cod Hotel";
            nombrehotel.Width = 80;
            // 
            // ciudadhotel
            // 
            ciudadhotel.Text = "Cod Cuidad";
            ciudadhotel.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(356, 185);
            button1.Name = "button1";
            button1.Size = new Size(126, 35);
            button1.TabIndex = 7;
            button1.Text = "Agregar itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // hotelcontinuar
            // 
            hotelcontinuar.Location = new Point(569, 434);
            hotelcontinuar.Name = "hotelcontinuar";
            hotelcontinuar.Size = new Size(96, 45);
            hotelcontinuar.TabIndex = 8;
            hotelcontinuar.Text = "Continuar";
            hotelcontinuar.UseVisualStyleBackColor = true;
            hotelcontinuar.Click += hotelcontinuar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(692, 434);
            button3.Name = "button3";
            button3.Size = new Size(96, 45);
            button3.TabIndex = 9;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Buscarhotel
            // 
            Buscarhotel.Location = new Point(167, 422);
            Buscarhotel.Name = "Buscarhotel";
            Buscarhotel.Size = new Size(75, 23);
            Buscarhotel.TabIndex = 10;
            Buscarhotel.Text = "Aplicar";
            Buscarhotel.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(dateTimePicker3);
            groupBox3.Controls.Add(Hasta);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(12, 326);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(259, 106);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fecha";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(78, 68);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(78, 32);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(106, 23);
            dateTimePicker3.TabIndex = 4;
            // 
            // Hasta
            // 
            Hasta.AutoSize = true;
            Hasta.Location = new Point(11, 68);
            Hasta.Name = "Hasta";
            Hasta.Size = new Size(37, 15);
            Hasta.TabIndex = 3;
            Hasta.Text = "Hasta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 32);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 1;
            label7.Text = "Desde";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(radioButton3);
            groupBox4.Controls.Add(radioButton2);
            groupBox4.Controls.Add(radioButton1);
            groupBox4.Location = new Point(0, 192);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(259, 103);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Pasajeros";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 14;
            radioButton3.TabStop = true;
            radioButton3.Text = "Adulto";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 48);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(60, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Menor";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 75);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 19);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Infante";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 110);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 12;
            label5.Text = "Ciudad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(121, 110);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 13;
            // 
            // Precio
            // 
            Precio.DisplayIndex = 6;
            Precio.Text = "Precio";
            Precio.Width = 80;
            // 
            // fechadesde
            // 
            fechadesde.DisplayIndex = 2;
            fechadesde.Text = "Fecha desde";
            fechadesde.Width = 80;
            // 
            // fechahast
            // 
            fechahast.DisplayIndex = 3;
            fechahast.Text = "Fecha hasta";
            fechahast.Width = 80;
            // 
            // Pasajero
            // 
            Pasajero.DisplayIndex = 4;
            Pasajero.Text = "Pasajero";
            Pasajero.Width = 75;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 5;
            columnHeader1.Text = "Cap. Max";
            columnHeader1.Width = 70;
            // 
            // Hoteleria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(button3);
            Controls.Add(hotelcontinuar);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Hoteleria";
            Text = "Hoteleria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label4;
        private ListView listView1;
        private ColumnHeader nombrehotel;
        private ColumnHeader ciudadhotel;
        private Button button1;
        private Button hotelcontinuar;
        private Button button3;
        private Button Buscarhotel;
        private GroupBox groupBox3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label Hasta;
        private Label label7;
        private GroupBox groupBox4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ComboBox comboBox3;
        private Label label5;
        private ColumnHeader Precio;
        private ColumnHeader fechadesde;
        private ColumnHeader fechahast;
        private ColumnHeader Pasajero;
        private ColumnHeader columnHeader1;
    }
}