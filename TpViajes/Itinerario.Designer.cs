namespace TPagenciadeviajes
{
    partial class Itinerario
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
            Numitirnerario = new TextBox();
            label1 = new Label();
            Seleccionservicio = new GroupBox();
            button3 = new Button();
            button1 = new Button();
            listadoservicios = new GroupBox();
            label4 = new Label();
            label2 = new Label();
            button5 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            Preciohotel = new ColumnHeader();
            cuidad = new ColumnHeader();
            Pasajeroshotel = new ColumnHeader();
            listView2 = new ListView();
            Precio = new ColumnHeader();
            Pasajero = new ColumnHeader();
            Destino = new ColumnHeader();
            Presupuestar = new Button();
            Guardarreserva = new Button();
            Cancerlarreserva = new Button();
            button2 = new Button();
            Seleccionservicio.SuspendLayout();
            listadoservicios.SuspendLayout();
            SuspendLayout();
            // 
            // Numitirnerario
            // 
            Numitirnerario.Location = new Point(61, 69);
            Numitirnerario.Margin = new Padding(3, 4, 3, 4);
            Numitirnerario.Name = "Numitirnerario";
            Numitirnerario.Size = new Size(114, 27);
            Numitirnerario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 45);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Numero itinerario ";
            // 
            // Seleccionservicio
            // 
            Seleccionservicio.Controls.Add(button3);
            Seleccionservicio.Controls.Add(button1);
            Seleccionservicio.Location = new Point(56, 177);
            Seleccionservicio.Margin = new Padding(3, 4, 3, 4);
            Seleccionservicio.Name = "Seleccionservicio";
            Seleccionservicio.Padding = new Padding(3, 4, 3, 4);
            Seleccionservicio.Size = new Size(328, 155);
            Seleccionservicio.TabIndex = 3;
            Seleccionservicio.TabStop = false;
            Seleccionservicio.Text = "Seleccionar servicio";
            // 
            // button3
            // 
            button3.Location = new Point(183, 71);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(117, 56);
            button3.TabIndex = 1;
            button3.Text = "Hoteleria";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(38, 71);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(117, 56);
            button1.TabIndex = 0;
            button1.Text = "Vuelos ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listadoservicios
            // 
            listadoservicios.Controls.Add(label4);
            listadoservicios.Controls.Add(label2);
            listadoservicios.Controls.Add(button5);
            listadoservicios.Controls.Add(button4);
            listadoservicios.Controls.Add(listView1);
            listadoservicios.Controls.Add(listView2);
            listadoservicios.Controls.Add(Presupuestar);
            listadoservicios.Location = new Point(394, 45);
            listadoservicios.Margin = new Padding(3, 4, 3, 4);
            listadoservicios.Name = "listadoservicios";
            listadoservicios.Padding = new Padding(3, 4, 3, 4);
            listadoservicios.Size = new Size(506, 368);
            listadoservicios.TabIndex = 5;
            listadoservicios.TabStop = false;
            listadoservicios.Text = "Servicios Seleccionados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 55);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 12;
            label4.Text = "Hotel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 10;
            label2.Text = "Vuelos";
            // 
            // button5
            // 
            button5.Location = new Point(347, 216);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(104, 31);
            button5.TabIndex = 9;
            button5.Text = "Eliminar ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(59, 216);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(104, 31);
            button4.TabIndex = 8;
            button4.Text = "Eliminar";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Preciohotel, cuidad, Pasajeroshotel });
            listView1.Location = new Point(274, 79);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(225, 128);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Preciohotel
            // 
            Preciohotel.Text = "Precio";
            // 
            // cuidad
            // 
            cuidad.Text = "Hotal-Cuidad";
            cuidad.Width = 75;
            // 
            // Pasajeroshotel
            // 
            Pasajeroshotel.Text = "Pasajero";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Precio, Pasajero, Destino });
            listView2.Location = new Point(32, 79);
            listView2.Margin = new Padding(3, 4, 3, 4);
            listView2.Name = "listView2";
            listView2.Size = new Size(201, 128);
            listView2.TabIndex = 7;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            // 
            // Pasajero
            // 
            Pasajero.Text = "Pasajero";
            // 
            // Destino
            // 
            Destino.Text = "Destino";
            // 
            // Presupuestar
            // 
            Presupuestar.Location = new Point(182, 276);
            Presupuestar.Margin = new Padding(3, 4, 3, 4);
            Presupuestar.Name = "Presupuestar";
            Presupuestar.Size = new Size(127, 56);
            Presupuestar.TabIndex = 5;
            Presupuestar.Text = "Presupuestar";
            Presupuestar.UseVisualStyleBackColor = true;
            // 
            // Guardarreserva
            // 
            Guardarreserva.Location = new Point(413, 489);
            Guardarreserva.Margin = new Padding(3, 4, 3, 4);
            Guardarreserva.Name = "Guardarreserva";
            Guardarreserva.Size = new Size(145, 55);
            Guardarreserva.TabIndex = 6;
            Guardarreserva.Text = "Guardar Itinerario";
            Guardarreserva.UseVisualStyleBackColor = true;
            // 
            // Cancerlarreserva
            // 
            Cancerlarreserva.Location = new Point(623, 489);
            Cancerlarreserva.Margin = new Padding(3, 4, 3, 4);
            Cancerlarreserva.Name = "Cancerlarreserva";
            Cancerlarreserva.Size = new Size(145, 55);
            Cancerlarreserva.TabIndex = 7;
            Cancerlarreserva.Text = "Cancelar";
            Cancerlarreserva.UseVisualStyleBackColor = true;
            Cancerlarreserva.Click += Cancerlarreserva_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 69);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 9;
            button2.Text = "Buscar/Nuevo";
            button2.UseVisualStyleBackColor = true;
            // 
            // Itinerario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(Cancerlarreserva);
            Controls.Add(Guardarreserva);
            Controls.Add(listadoservicios);
            Controls.Add(Seleccionservicio);
            Controls.Add(label1);
            Controls.Add(Numitirnerario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Itinerario";
            Text = "Itinerario";
            Load += Itinerario_Load;
            Seleccionservicio.ResumeLayout(false);
            listadoservicios.ResumeLayout(false);
            listadoservicios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Numitirnerario;
        private Label label1;
        private GroupBox Seleccionservicio;
        private GroupBox listadoservicios;
        private Button Presupuestar;
        private Button Guardarreserva;
        private Button Cancerlarreserva;
        private Button button2;
        private Button button3;
        private Button button1;
        private ListView listView2;
        private ListView listView1;
        private Button button5;
        private Button button4;
        private Label label4;
        private Label label2;
        private ColumnHeader Precio;
        private ColumnHeader Pasajero;
        private ColumnHeader Destino;
        private ColumnHeader Preciohotel;
        private ColumnHeader cuidad;
        private ColumnHeader Pasajeroshotel;
    }
}