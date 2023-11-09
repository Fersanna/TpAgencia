namespace TPagenciadeviajes
{
    partial class Reserva
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
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            menureserva = new Button();
            PersonasListView = new ListView();
            nombreHd = new ColumnHeader();
            apellidohd = new ColumnHeader();
            Dnidh = new ColumnHeader();
            edadhd = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            codhotel = new ColumnHeader();
            groupBox2 = new GroupBox();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(45, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese numero de prereserva";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, -18);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresar numero de prereserva";
            // 
            // button2
            // 
            button2.Location = new Point(204, 85);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 2;
            button2.Text = "Cancelar ";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(78, 85);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 0;
            button1.Text = "Reservar";
            button1.UseVisualStyleBackColor = true;
            // 
            // menureserva
            // 
            menureserva.Location = new Point(613, 415);
            menureserva.Name = "menureserva";
            menureserva.Size = new Size(75, 23);
            menureserva.TabIndex = 4;
            menureserva.Text = "Menu";
            menureserva.UseVisualStyleBackColor = true;
            menureserva.Click += menureserva_Click;
            // 
            // PersonasListView
            // 
            PersonasListView.Columns.AddRange(new ColumnHeader[] { nombreHd, apellidohd, Dnidh, edadhd, columnHeader1, columnHeader2, codhotel });
            PersonasListView.FullRowSelect = true;
            PersonasListView.Location = new Point(24, 42);
            PersonasListView.MultiSelect = false;
            PersonasListView.Name = "PersonasListView";
            PersonasListView.Size = new Size(441, 105);
            PersonasListView.TabIndex = 5;
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
            // groupBox2
            // 
            groupBox2.Controls.Add(PersonasListView);
            groupBox2.Location = new Point(45, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 183);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de la reserva";
            // 
            // button3
            // 
            button3.Location = new Point(694, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(menureserva);
            Controls.Add(groupBox1);
            Name = "Reserva";
            Text = "Reserva";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button menureserva;
        private ListView PersonasListView;
        private ColumnHeader nombreHd;
        private ColumnHeader apellidohd;
        private ColumnHeader Dnidh;
        private ColumnHeader edadhd;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader codhotel;
        private GroupBox groupBox2;
        private Button button3;
    }
}