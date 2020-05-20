namespace practica_Clase1
{
    partial class frmNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNomina));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalbas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNht = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExtras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubsidio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeguridad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSalBruto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotaldeven = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRetefuente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDeducciones = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalNeto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtVlrExtras = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(477, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 68);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(2, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 4);
            this.panel1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Location = new System.Drawing.Point(0, 38);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(590, 4);
            this.panel5.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nómina de Empleados";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(158, 121);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(68, 22);
            this.txtCedula.TabIndex = 17;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cédula";
            // 
            // txtSalbas
            // 
            this.txtSalbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalbas.Location = new System.Drawing.Point(158, 195);
            this.txtSalbas.Name = "txtSalbas";
            this.txtSalbas.Size = new System.Drawing.Size(68, 22);
            this.txtSalbas.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Salario Básico Hora";
            // 
            // txtNht
            // 
            this.txtNht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNht.Location = new System.Drawing.Point(439, 122);
            this.txtNht.Name = "txtNht";
            this.txtNht.Size = new System.Drawing.Size(89, 22);
            this.txtNht.TabIndex = 18;
            this.txtNht.TextChanged += new System.EventHandler(this.txtNht_TextChanged);
            this.txtNht.Leave += new System.EventHandler(this.txtNht_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Número de horas trabajadas";
            // 
            // txtExtras
            // 
            this.txtExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtras.Location = new System.Drawing.Point(158, 230);
            this.txtExtras.Name = "txtExtras";
            this.txtExtras.Size = new System.Drawing.Size(68, 22);
            this.txtExtras.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Horas Extras";
            // 
            // txtSubsidio
            // 
            this.txtSubsidio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubsidio.Location = new System.Drawing.Point(440, 307);
            this.txtSubsidio.Name = "txtSubsidio";
            this.txtSubsidio.Size = new System.Drawing.Size(88, 22);
            this.txtSubsidio.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(273, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Subsidio Transporte";
            // 
            // txtSeguridad
            // 
            this.txtSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguridad.Location = new System.Drawing.Point(178, 304);
            this.txtSeguridad.Name = "txtSeguridad";
            this.txtSeguridad.Size = new System.Drawing.Size(48, 22);
            this.txtSeguridad.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Seguridad Social 4%";
            // 
            // txtSalBruto
            // 
            this.txtSalBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalBruto.Location = new System.Drawing.Point(158, 268);
            this.txtSalBruto.Name = "txtSalBruto";
            this.txtSalBruto.Size = new System.Drawing.Size(68, 22);
            this.txtSalBruto.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Salario Bruto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(-5, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 4);
            this.panel2.TabIndex = 30;
            // 
            // txtTotaldeven
            // 
            this.txtTotaldeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotaldeven.Location = new System.Drawing.Point(158, 354);
            this.txtTotaldeven.Name = "txtTotaldeven";
            this.txtTotaldeven.Size = new System.Drawing.Size(68, 22);
            this.txtTotaldeven.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total devengado";
            // 
            // txtRetefuente
            // 
            this.txtRetefuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetefuente.Location = new System.Drawing.Point(440, 271);
            this.txtRetefuente.Name = "txtRetefuente";
            this.txtRetefuente.Size = new System.Drawing.Size(88, 22);
            this.txtRetefuente.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Retencion Fuente 10%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(381, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Horario";
            // 
            // cmbHorario
            // 
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Items.AddRange(new object[] {
            "Diurno",
            "Nocturno"});
            this.cmbHorario.Location = new System.Drawing.Point(440, 193);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(88, 21);
            this.cmbHorario.TabIndex = 36;
            this.cmbHorario.SelectedIndexChanged += new System.EventHandler(this.cmbHorario_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(477, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(50, 38);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(2, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 4);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Location = new System.Drawing.Point(2, 430);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(590, 4);
            this.panel4.TabIndex = 39;
            // 
            // txtDeducciones
            // 
            this.txtDeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeducciones.Location = new System.Drawing.Point(440, 354);
            this.txtDeducciones.Name = "txtDeducciones";
            this.txtDeducciones.Size = new System.Drawing.Size(88, 22);
            this.txtDeducciones.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(297, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total Deducciones";
            // 
            // txtSalNeto
            // 
            this.txtSalNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalNeto.Location = new System.Drawing.Point(158, 393);
            this.txtSalNeto.Name = "txtSalNeto";
            this.txtSalNeto.Size = new System.Drawing.Size(68, 22);
            this.txtSalNeto.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 396);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 20);
            this.label13.TabIndex = 42;
            this.label13.Text = "Salario Neto";
            // 
            // txtVlrExtras
            // 
            this.txtVlrExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVlrExtras.Location = new System.Drawing.Point(440, 227);
            this.txtVlrExtras.Name = "txtVlrExtras";
            this.txtVlrExtras.Size = new System.Drawing.Size(88, 22);
            this.txtVlrExtras.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(343, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "Valor Extras";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(158, 159);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(370, 22);
            this.txtNombre.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(425, 450);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(46, 38);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.SystemColors.Control;
            this.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtFecha.Location = new System.Drawing.Point(29, 84);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(95, 14);
            this.txtFecha.TabIndex = 49;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.Control;
            this.txtHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtHora.Location = new System.Drawing.Point(440, 84);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(95, 14);
            this.txtHora.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-2, 104);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(590, 4);
            this.panel6.TabIndex = 51;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Location = new System.Drawing.Point(0, 38);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(590, 4);
            this.panel7.TabIndex = 14;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 505);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtVlrExtras);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSalNeto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDeducciones);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbHorario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTotaldeven);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRetefuente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtSubsidio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSeguridad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSalBruto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalbas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "frmNomina";
            this.Text = "frmNomina";
            this.Load += new System.EventHandler(this.frmNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalbas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubsidio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeguridad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSalBruto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotaldeven;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRetefuente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDeducciones;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSalNeto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtVlrExtras;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}