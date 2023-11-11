namespace TPCAI
{
    partial class FormListadoVuelos
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
            this.dataGridViewListadoVuelos = new System.Windows.Forms.DataGridView();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnAñadirAPresupuesto = new System.Windows.Forms.Button();
            this.btnVerPresupuesto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ColumnOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHoraArribo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdTarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoVuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListadoVuelos
            // 
            this.dataGridViewListadoVuelos.AllowUserToAddRows = false;
            this.dataGridViewListadoVuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListadoVuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadoVuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOrigen,
            this.ColumnDestino,
            this.ColumnFechaHoraSalida,
            this.ColumnFechaHoraArribo,
            this.ColumnAerolinea,
            this.ColumnPrecio,
            this.ColumnClase,
            this.ColumnTipoPasajero,
            this.ColumnIdTarifa});
            this.dataGridViewListadoVuelos.Location = new System.Drawing.Point(477, 61);
            this.dataGridViewListadoVuelos.Name = "dataGridViewListadoVuelos";
            this.dataGridViewListadoVuelos.Size = new System.Drawing.Size(957, 477);
            this.dataGridViewListadoVuelos.TabIndex = 3;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Location = new System.Drawing.Point(1283, 553);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(153, 31);
            this.btnVolverMenu.TabIndex = 5;
            this.btnVolverMenu.Text = "Volver a Menú";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            this.btnVolverMenu.Click += new System.EventHandler(this.btnVolverMenu_Click);
            // 
            // btnAñadirAPresupuesto
            // 
            this.btnAñadirAPresupuesto.Location = new System.Drawing.Point(986, 553);
            this.btnAñadirAPresupuesto.Name = "btnAñadirAPresupuesto";
            this.btnAñadirAPresupuesto.Size = new System.Drawing.Size(122, 31);
            this.btnAñadirAPresupuesto.TabIndex = 4;
            this.btnAñadirAPresupuesto.Text = "Añadir a Presupuesto";
            this.btnAñadirAPresupuesto.UseVisualStyleBackColor = true;
            this.btnAñadirAPresupuesto.Click += new System.EventHandler(this.btnAñadirAPresupuesto_Click);
            // 
            // btnVerPresupuesto
            // 
            this.btnVerPresupuesto.Location = new System.Drawing.Point(1137, 553);
            this.btnVerPresupuesto.Name = "btnVerPresupuesto";
            this.btnVerPresupuesto.Size = new System.Drawing.Size(122, 31);
            this.btnVerPresupuesto.TabIndex = 7;
            this.btnVerPresupuesto.Text = "Ver Presupuesto";
            this.btnVerPresupuesto.UseVisualStyleBackColor = true;
            this.btnVerPresupuesto.Click += new System.EventHandler(this.btnVerPresupuesto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el producto que desee agregar al presupuesto";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Rosario, Argentina",
            "New York, Estados Unidos",
            "Moscú, Rusia",
            "LAX"});
            this.comboBox3.Location = new System.Drawing.Point(249, 125);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(196, 21);
            this.comboBox3.TabIndex = 56;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "CABA, Argentina",
            "Córdoba, Argentina",
            "Mendoza, Argentina",
            "Madrid, España",
            "MIA"});
            this.comboBox2.Location = new System.Drawing.Point(251, 83);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(196, 21);
            this.comboBox2.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "* Origen";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(95, 448);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(122, 31);
            this.BtnBuscar.TabIndex = 52;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(249, 215);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Economy",
            "Premium",
            "Business",
            "First"});
            this.comboBox1.Location = new System.Drawing.Point(251, 390);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(249, 347);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(196, 20);
            this.textBox6.TabIndex = 48;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(249, 308);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 47;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(198, 20);
            this.textBox4.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Cantidad de Infantes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Clase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cantidad de Menores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 265);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cantidad de Adultos *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Fecha de Vuelta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "* Fecha de Ida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "* Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(93, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Presupuesto Activo: 4545";
            // 
            // ColumnOrigen
            // 
            this.ColumnOrigen.HeaderText = "Origen";
            this.ColumnOrigen.Name = "ColumnOrigen";
            // 
            // ColumnDestino
            // 
            this.ColumnDestino.HeaderText = "Destino";
            this.ColumnDestino.Name = "ColumnDestino";
            // 
            // ColumnFechaHoraSalida
            // 
            this.ColumnFechaHoraSalida.HeaderText = "Fecha Hora Salida";
            this.ColumnFechaHoraSalida.Name = "ColumnFechaHoraSalida";
            // 
            // ColumnFechaHoraArribo
            // 
            this.ColumnFechaHoraArribo.HeaderText = "Fecha Hora Arribo";
            this.ColumnFechaHoraArribo.Name = "ColumnFechaHoraArribo";
            // 
            // ColumnAerolinea
            // 
            this.ColumnAerolinea.HeaderText = "Aerolinea";
            this.ColumnAerolinea.Name = "ColumnAerolinea";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnClase
            // 
            this.ColumnClase.HeaderText = "Clase de Vuelo";
            this.ColumnClase.Name = "ColumnClase";
            // 
            // ColumnTipoPasajero
            // 
            this.ColumnTipoPasajero.HeaderText = "Tipo Pasajero";
            this.ColumnTipoPasajero.Name = "ColumnTipoPasajero";
            // 
            // IdTarifa
            // 
            this.ColumnIdTarifa.HeaderText = "Id Tarifa";
            this.ColumnIdTarifa.Name = "ColumnIdTarifa";
            // 
            // FormListadoVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 625);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.dataGridViewListadoVuelos);
            this.Controls.Add(this.btnVolverMenu);
            this.Controls.Add(this.btnAñadirAPresupuesto);
            this.Name = "FormListadoVuelos";
            this.Text = "Listado Vuelos";
            this.Load += new System.EventHandler(this.FormListadoVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadoVuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListadoVuelos;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnAñadirAPresupuesto;
        private System.Windows.Forms.Button btnVerPresupuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaHoraArribo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoPasajero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdTarifa;
    }
}