
namespace EjercicioFiguras
{
    partial class fFiguras
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bCerrar = new System.Windows.Forms.Button();
            this.gbFigura = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbTriangulo = new System.Windows.Forms.RadioButton();
            this.rbRectangulo = new System.Windows.Forms.RadioButton();
            this.rbCuadrado = new System.Windows.Forms.RadioButton();
            this.rbCirculo = new System.Windows.Forms.RadioButton();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lbFiguras = new System.Windows.Forms.ListBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.gbFiguras = new System.Windows.Forms.GroupBox();
            this.lLadoDos = new System.Windows.Forms.Label();
            this.lLadoUno = new System.Windows.Forms.Label();
            this.tLadoDos = new System.Windows.Forms.TextBox();
            this.tLadoUno = new System.Windows.Forms.TextBox();
            this.lAltura = new System.Windows.Forms.Label();
            this.tAltura = new System.Windows.Forms.TextBox();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.lFigura = new System.Windows.Forms.Label();
            this.pFiguras = new System.Windows.Forms.Panel();
            this.lCantFigura = new System.Windows.Forms.Label();
            this.gbFigura.SuspendLayout();
            this.gbFiguras.SuspendLayout();
            this.pFiguras.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Location = new System.Drawing.Point(304, 304);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // gbFigura
            // 
            this.gbFigura.Controls.Add(this.panel1);
            this.gbFigura.Controls.Add(this.rbTriangulo);
            this.gbFigura.Controls.Add(this.rbRectangulo);
            this.gbFigura.Controls.Add(this.rbCuadrado);
            this.gbFigura.Controls.Add(this.rbCirculo);
            this.gbFigura.Location = new System.Drawing.Point(8, 11);
            this.gbFigura.Name = "gbFigura";
            this.gbFigura.Size = new System.Drawing.Size(92, 124);
            this.gbFigura.TabIndex = 1;
            this.gbFigura.TabStop = false;
            this.gbFigura.Text = "Figura";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(110, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 138);
            this.panel1.TabIndex = 9;
            // 
            // rbTriangulo
            // 
            this.rbTriangulo.AutoSize = true;
            this.rbTriangulo.Location = new System.Drawing.Point(7, 102);
            this.rbTriangulo.Name = "rbTriangulo";
            this.rbTriangulo.Size = new System.Drawing.Size(69, 17);
            this.rbTriangulo.TabIndex = 3;
            this.rbTriangulo.Text = "Triangulo";
            this.rbTriangulo.UseVisualStyleBackColor = true;
            this.rbTriangulo.CheckedChanged += new System.EventHandler(this.rbTriangulo_CheckedChanged);
            // 
            // rbRectangulo
            // 
            this.rbRectangulo.AutoSize = true;
            this.rbRectangulo.Location = new System.Drawing.Point(7, 78);
            this.rbRectangulo.Name = "rbRectangulo";
            this.rbRectangulo.Size = new System.Drawing.Size(80, 17);
            this.rbRectangulo.TabIndex = 2;
            this.rbRectangulo.Text = "Rectangulo";
            this.rbRectangulo.UseVisualStyleBackColor = true;
            this.rbRectangulo.CheckedChanged += new System.EventHandler(this.rbRectangulo_CheckedChanged);
            // 
            // rbCuadrado
            // 
            this.rbCuadrado.AutoSize = true;
            this.rbCuadrado.Location = new System.Drawing.Point(7, 54);
            this.rbCuadrado.Name = "rbCuadrado";
            this.rbCuadrado.Size = new System.Drawing.Size(71, 17);
            this.rbCuadrado.TabIndex = 1;
            this.rbCuadrado.Text = "Cuadrado";
            this.rbCuadrado.UseVisualStyleBackColor = true;
            this.rbCuadrado.CheckedChanged += new System.EventHandler(this.rbCuadrado_CheckedChanged);
            // 
            // rbCirculo
            // 
            this.rbCirculo.AutoSize = true;
            this.rbCirculo.Checked = true;
            this.rbCirculo.Location = new System.Drawing.Point(7, 30);
            this.rbCirculo.Name = "rbCirculo";
            this.rbCirculo.Size = new System.Drawing.Size(57, 17);
            this.rbCirculo.TabIndex = 0;
            this.rbCirculo.TabStop = true;
            this.rbCirculo.Text = "Circulo";
            this.rbCirculo.UseVisualStyleBackColor = true;
            this.rbCirculo.CheckedChanged += new System.EventHandler(this.rbCirculo_CheckedChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(282, 107);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 3;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lbFiguras
            // 
            this.lbFiguras.FormattingEnabled = true;
            this.lbFiguras.Location = new System.Drawing.Point(12, 158);
            this.lbFiguras.Name = "lbFiguras";
            this.lbFiguras.Size = new System.Drawing.Size(286, 121);
            this.lbFiguras.TabIndex = 4;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(19, 314);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(101, 13);
            this.lCantidad.TabIndex = 5;
            this.lCantidad.Text = "Cantidad de figuras:";
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(304, 158);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(89, 34);
            this.bArea.TabIndex = 6;
            this.bArea.Text = "Área";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(303, 198);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(89, 33);
            this.bPerimetro.TabIndex = 7;
            this.bPerimetro.Text = "Perimetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // gbFiguras
            // 
            this.gbFiguras.Controls.Add(this.lLadoDos);
            this.gbFiguras.Controls.Add(this.lLadoUno);
            this.gbFiguras.Controls.Add(this.tLadoDos);
            this.gbFiguras.Controls.Add(this.tLadoUno);
            this.gbFiguras.Controls.Add(this.lAltura);
            this.gbFiguras.Controls.Add(this.tAltura);
            this.gbFiguras.Controls.Add(this.tRadio);
            this.gbFiguras.Controls.Add(this.lFigura);
            this.gbFiguras.Location = new System.Drawing.Point(118, 11);
            this.gbFiguras.Name = "gbFiguras";
            this.gbFiguras.Size = new System.Drawing.Size(245, 86);
            this.gbFiguras.TabIndex = 8;
            this.gbFiguras.TabStop = false;
            this.gbFiguras.Text = "Circulo";
            // 
            // lLadoDos
            // 
            this.lLadoDos.AutoSize = true;
            this.lLadoDos.Location = new System.Drawing.Point(141, 50);
            this.lLadoDos.Name = "lLadoDos";
            this.lLadoDos.Size = new System.Drawing.Size(34, 13);
            this.lLadoDos.TabIndex = 8;
            this.lLadoDos.Text = "Lado:";
            this.lLadoDos.Visible = false;
            // 
            // lLadoUno
            // 
            this.lLadoUno.AutoSize = true;
            this.lLadoUno.Location = new System.Drawing.Point(141, 27);
            this.lLadoUno.Name = "lLadoUno";
            this.lLadoUno.Size = new System.Drawing.Size(34, 13);
            this.lLadoUno.TabIndex = 7;
            this.lLadoUno.Text = "Lado:";
            this.lLadoUno.Visible = false;
            // 
            // tLadoDos
            // 
            this.tLadoDos.Location = new System.Drawing.Point(186, 47);
            this.tLadoDos.Name = "tLadoDos";
            this.tLadoDos.Size = new System.Drawing.Size(53, 20);
            this.tLadoDos.TabIndex = 6;
            this.tLadoDos.Visible = false;
            // 
            // tLadoUno
            // 
            this.tLadoUno.Location = new System.Drawing.Point(186, 24);
            this.tLadoUno.Name = "tLadoUno";
            this.tLadoUno.Size = new System.Drawing.Size(53, 20);
            this.tLadoUno.TabIndex = 5;
            this.tLadoUno.Visible = false;
            // 
            // lAltura
            // 
            this.lAltura.AutoSize = true;
            this.lAltura.Location = new System.Drawing.Point(7, 50);
            this.lAltura.Name = "lAltura";
            this.lAltura.Size = new System.Drawing.Size(37, 13);
            this.lAltura.TabIndex = 4;
            this.lAltura.Text = "Altura:";
            this.lAltura.Visible = false;
            // 
            // tAltura
            // 
            this.tAltura.Location = new System.Drawing.Point(50, 47);
            this.tAltura.Name = "tAltura";
            this.tAltura.Size = new System.Drawing.Size(53, 20);
            this.tAltura.TabIndex = 3;
            this.tAltura.Visible = false;
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(50, 24);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(53, 20);
            this.tRadio.TabIndex = 2;
            // 
            // lFigura
            // 
            this.lFigura.AutoSize = true;
            this.lFigura.Location = new System.Drawing.Point(7, 27);
            this.lFigura.Name = "lFigura";
            this.lFigura.Size = new System.Drawing.Size(38, 13);
            this.lFigura.TabIndex = 1;
            this.lFigura.Text = "Radio:";
            // 
            // pFiguras
            // 
            this.pFiguras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pFiguras.Controls.Add(this.gbFigura);
            this.pFiguras.Controls.Add(this.gbFiguras);
            this.pFiguras.Controls.Add(this.bAgregar);
            this.pFiguras.Location = new System.Drawing.Point(12, 12);
            this.pFiguras.Name = "pFiguras";
            this.pFiguras.Size = new System.Drawing.Size(380, 140);
            this.pFiguras.TabIndex = 9;
            // 
            // lCantFigura
            // 
            this.lCantFigura.AutoSize = true;
            this.lCantFigura.Location = new System.Drawing.Point(19, 291);
            this.lCantFigura.Name = "lCantFigura";
            this.lCantFigura.Size = new System.Drawing.Size(106, 13);
            this.lCantFigura.TabIndex = 10;
            this.lCantFigura.Text = "Cantidad de circulos:";
            // 
            // fFiguras
            // 
            this.AcceptButton = this.bAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(401, 336);
            this.Controls.Add(this.lCantFigura);
            this.Controls.Add(this.pFiguras);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.lbFiguras);
            this.Controls.Add(this.bCerrar);
            this.Name = "fFiguras";
            this.Text = "Figuras";
            this.gbFigura.ResumeLayout(false);
            this.gbFigura.PerformLayout();
            this.gbFiguras.ResumeLayout(false);
            this.gbFiguras.PerformLayout();
            this.pFiguras.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.GroupBox gbFigura;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox lbFiguras;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.RadioButton rbTriangulo;
        private System.Windows.Forms.RadioButton rbRectangulo;
        private System.Windows.Forms.RadioButton rbCuadrado;
        private System.Windows.Forms.RadioButton rbCirculo;
        private System.Windows.Forms.GroupBox gbFiguras;
        private System.Windows.Forms.Label lFigura;
        private System.Windows.Forms.TextBox tAltura;
        private System.Windows.Forms.TextBox tRadio;
        private System.Windows.Forms.Label lAltura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pFiguras;
        private System.Windows.Forms.Label lCantFigura;
        private System.Windows.Forms.Label lLadoDos;
        private System.Windows.Forms.Label lLadoUno;
        private System.Windows.Forms.TextBox tLadoDos;
        private System.Windows.Forms.TextBox tLadoUno;
    }
}

