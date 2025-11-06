namespace Ejercicio2_DesktopApp
{
    partial class Form1
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            groupBox1 = new GroupBox();
            btnImportar = new Button();
            groupBox2 = new GroupBox();
            cBoxCamiones = new ComboBox();
            btnRetirar = new Button();
            btnAgregar = new Button();
            btnEnviar = new Button();
            btnIniciar = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(27, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(201, 31);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 94);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(372, 31);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(120, 94);
            listBox3.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImportar);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(689, 160);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deposito";
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(537, 31);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(126, 94);
            btnImportar.TabIndex = 4;
            btnImportar.Text = "Importar Paquetes pedidos";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cBoxCamiones);
            groupBox2.Controls.Add(btnRetirar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(btnIniciar);
            groupBox2.Location = new Point(12, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(689, 246);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Preparar pedido:";
            // 
            // cBoxCamiones
            // 
            cBoxCamiones.FormattingEnabled = true;
            cBoxCamiones.Location = new Point(44, 49);
            cBoxCamiones.Name = "cBoxCamiones";
            cBoxCamiones.Size = new Size(121, 23);
            cBoxCamiones.TabIndex = 4;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(588, 92);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(75, 23);
            btnRetirar.TabIndex = 3;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(588, 48);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(143, 189);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(44, 189);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private GroupBox groupBox1;
        public Button btnImportar;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog1;
        private Button btnRetirar;
        private Button btnAgregar;
        private Button btnEnviar;
        private Button btnIniciar;
        public ComboBox cBoxCamiones;
    }
}
