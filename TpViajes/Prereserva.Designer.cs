namespace TPagenciadeviajes
{
    partial class Prereserva
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
            PersonasListView = new ListView();
            nombreHd = new ColumnHeader();
            apellidohd = new ColumnHeader();
            Dnidh = new ColumnHeader();
            edadhd = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nombre = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            Nombrepersona = new TextBox();
            editarlistabtn = new Button();
            eliminarbtn = new Button();
            groupBox3 = new GroupBox();
            button3 = new Button();
            Cancelarprereserva = new Button();
            label5 = new Label();
            columnHeader2 = new ColumnHeader();
            codhotel = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // PersonasListView
            // 
            PersonasListView.Columns.AddRange(new ColumnHeader[] { nombreHd, apellidohd, Dnidh, edadhd, columnHeader1, columnHeader2, codhotel });
            PersonasListView.FullRowSelect = true;
            PersonasListView.Location = new Point(25, 22);
            PersonasListView.MultiSelect = false;
            PersonasListView.Name = "PersonasListView";
            PersonasListView.Size = new Size(436, 81);
            PersonasListView.TabIndex = 0;
            PersonasListView.UseCompatibleStateImageBehavior = false;
            PersonasListView.View = View.Details;
            // 
            // nombreHd
            // 
            nombreHd.Text = "Nombre";
            // 
            // apellidohd
            // 
            apellidohd.Text = "Apellido";
            // 
            // Dnidh
            // 
            Dnidh.Text = "Dni";
            // 
            // edadhd
            // 
            edadhd.Text = "Edad";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Servicios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese numero de itinerario :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 93);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(147, 64);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 3;
            button1.Text = "Cargar itinerario";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(Nombre);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(Nombrepersona);
            groupBox2.Location = new Point(12, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(425, 143);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pasajeros";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hotel-Cuidad-Pasajero-Precio", "Vuelo-Pasajero-Precio-Destino " });
            comboBox1.Location = new Point(291, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(95, 112);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 5;
            button2.Text = "Agregar pasajero";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 61);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha nacimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 18);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 10;
            label3.Text = "Dni";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Apellido";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(6, 19);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 8;
            Nombre.Text = "Nombre";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(147, 79);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(147, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // Nombrepersona
            // 
            Nombrepersona.Location = new Point(6, 36);
            Nombrepersona.Name = "Nombrepersona";
            Nombrepersona.Size = new Size(100, 23);
            Nombrepersona.TabIndex = 4;
            // 
            // editarlistabtn
            // 
            editarlistabtn.Location = new Point(147, 118);
            editarlistabtn.Name = "editarlistabtn";
            editarlistabtn.Size = new Size(78, 23);
            editarlistabtn.TabIndex = 4;
            editarlistabtn.Text = "Editar";
            editarlistabtn.UseVisualStyleBackColor = true;
            // 
            // eliminarbtn
            // 
            eliminarbtn.Location = new Point(261, 118);
            eliminarbtn.Name = "eliminarbtn";
            eliminarbtn.Size = new Size(78, 23);
            eliminarbtn.TabIndex = 12;
            eliminarbtn.Text = "Eliminar";
            eliminarbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(eliminarbtn);
            groupBox3.Controls.Add(PersonasListView);
            groupBox3.Controls.Add(editarlistabtn);
            groupBox3.Location = new Point(12, 291);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(487, 147);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Listado pasajeros";
            // 
            // button3
            // 
            button3.Location = new Point(505, 415);
            button3.Name = "button3";
            button3.Size = new Size(123, 23);
            button3.TabIndex = 7;
            button3.Text = "Prereservar Producto";
            button3.UseVisualStyleBackColor = true;
            // 
            // Cancelarprereserva
            // 
            Cancelarprereserva.Location = new Point(645, 415);
            Cancelarprereserva.Name = "Cancelarprereserva";
            Cancelarprereserva.Size = new Size(123, 23);
            Cancelarprereserva.TabIndex = 8;
            Cancelarprereserva.Text = "Cancelar";
            Cancelarprereserva.UseVisualStyleBackColor = true;
            Cancelarprereserva.Click += Cancelarprereserva_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(291, 39);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 13;
            label5.Text = "Servicio";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cod vuelo";
            columnHeader2.Width = 70;
            // 
            // codhotel
            // 
            codhotel.Text = "Cod Hotel";
            codhotel.Width = 70;
            // 
            // Prereserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Cancelarprereserva);
            Controls.Add(button3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Prereserva";
            Text = "Prereserva";
            Load += Prereserva_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView PersonasListView;
        private ColumnHeader nombreHd;
        private ColumnHeader apellidohd;
        private ColumnHeader Dnidh;
        private ColumnHeader edadhd;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Nombre;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox Nombrepersona;
        private Button editarlistabtn;
        private Button eliminarbtn;
        private GroupBox groupBox3;
        private Button button3;
        private Button Cancelarprereserva;
        private ComboBox comboBox1;
        private ColumnHeader columnHeader1;
        private Label label5;
        private ColumnHeader columnHeader2;
        private ColumnHeader codhotel;
    }
}