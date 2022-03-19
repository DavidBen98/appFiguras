using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioFiguras
{
    public partial class fFiguras : Form
    {
        #region variables
        Figura[] arFiguras;
        int tope;
        int ultimo;
        #endregion
        public fFiguras()
        {
            InitializeComponent();
            tope = 100;
            ultimo = -1;
            arFiguras = new Figura[tope];
        }

        #region metodos
        public void actualizarGB()
        {
            tAltura.Visible = false;
            lAltura.Visible = false;
            lLadoUno.Visible = false;
            lLadoDos.Visible = false;
            tLadoUno.Visible = false;
            tLadoDos.Visible = false;
            if (rbCirculo.Checked)
            {
                gbFiguras.Text = "Circulo";
                lFigura.Text = "Radio:";
                pFiguras.BackColor = Color.FromArgb(192, 255, 192);
            }
            else if (rbCuadrado.Checked)
            {
                gbFiguras.Text = "Cuadrado";
                lFigura.Text = "Lado:";
                pFiguras.BackColor = Color.FromArgb(255, 192, 192);
            }
            else if (rbRectangulo.Checked)
            {
                gbFiguras.Text = "Rectangulo";
                tAltura.Visible = true;
                lAltura.Visible = true;
                lFigura.Text = "Base:";
                pFiguras.BackColor = Color.FromArgb(192, 192, 255);
            }
            else
            {
                gbFiguras.Text = "Triangulo";
                lFigura.Text = "Base:";
                lAltura.Visible = true;
                tAltura.Visible = true;
                lLadoUno.Visible = true;
                lLadoDos.Visible = true;
                tLadoUno.Visible = true;
                tLadoDos.Visible = true;
                pFiguras.BackColor = Color.FromArgb(255, 255, 192);
            }
        }
        private void actualizarListado()
        {
            lbFiguras.Items.Clear();
            if (rbCirculo.Checked)
            {
                for (int i = 0; i <= ultimo; i++)
                {
                    if (arFiguras[i].GetType() == typeof(Circulo))
                        lbFiguras.Items.Add(arFiguras[i].ToString());
                }
                lCantFigura.Text = $"Cantidad de circulos: {lbFiguras.Items.Count}";
            }
            else if (rbCuadrado.Checked)
            {
                for (int i = 0; i <= ultimo; i++)
                {
                    if (arFiguras[i].GetType() == typeof(Cuadrado))
                        lbFiguras.Items.Add(arFiguras[i].ToString());
                }
                lCantFigura.Text = $"Cantidad de cuadrados: {lbFiguras.Items.Count}";
            }
            else if (rbRectangulo.Checked)
            {
                for (int i = 0; i <= ultimo; i++)
                {
                    if (arFiguras[i].GetType() == typeof(Rectangulo))
                        lbFiguras.Items.Add(arFiguras[i].ToString());
                }
                lCantFigura.Text = $"Cantidad de rectangulos: {lbFiguras.Items.Count}";
            }
            else
            {
                for (int i = 0; i <= ultimo; i++)
                {
                    if (arFiguras[i].GetType() == typeof(Triangulo))
                        lbFiguras.Items.Add(arFiguras[i].ToString());
                }
                lCantFigura.Text = $"Cantidad de triangulos: {lbFiguras.Items.Count}";
            }
            lCantidad.Text = $"Cantidad de figuras: {ultimo + 1}";

            if (lbFiguras.Items.Count != 0)
                lbFiguras.SelectedIndex = 0;
        }
        private bool ExisteFigura(Figura actual, Figura[] arreglo,int ultimo)
        {
            int posicion = 0;
            while ((posicion <= ultimo) && (!arreglo[posicion].Equals(actual)))
            {
                posicion++;
            }
            return (posicion <= ultimo);
        }
        private int BuscarPosicion (string elemento)
        {
            int i = 0;
            while (i <= ultimo && arFiguras[i].ToString() != elemento)
            {
                i++;
            }
            return i;
        }
        #endregion

        #region botones
        private void bAgregar_Click(object sender, EventArgs e)
        {
            double datoActual = tRadio.Text != "" ? Convert.ToDouble(tRadio.Text) : 0; //puede ser radio, lado o base segun la figura
            double alturaActual = tAltura.Text != "" ? Convert.ToDouble(tAltura.Text) : Rectangulo.altura_inicial;
            if (ultimo + 1 == tope)
            {
                MessageBox.Show("No se pueden agregar mas figuras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bAgregar.Enabled = false;
            }
            else if (tRadio.Text == "")
            {
                MessageBox.Show("Falta completar el primer campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tRadio.Focus();
            }
            else if (tAltura.Visible && tAltura.Text == "")
            {
                MessageBox.Show("Falta completar la altura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tAltura.Focus();
            }
            else if (rbTriangulo.Checked && (tLadoUno.Text == "" || tLadoDos.Text == ""))
            {
                MessageBox.Show("Falta completar al menos un lado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tLadoUno.Text == "")
                    tLadoUno.Focus();
                else
                    tLadoDos.Focus();
            }
            else if (rbCirculo.Checked)
            {
                Circulo nuevo = new Circulo(datoActual);

                if (!Circulo.esValido(datoActual))
                {
                    MessageBox.Show("El radio tiene que ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ExisteFigura(nuevo,arFiguras, ultimo))
                {
                    MessageBox.Show("El radio ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    arFiguras[++ultimo] = nuevo;
                    actualizarListado();
                    MessageBox.Show("Se ha creado exitosamente", "Crear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbFiguras.SelectedIndex = 0;
                }
                tRadio.Text = "";
                tRadio.Focus();
            }
            else if (rbCuadrado.Checked)
            {
                Cuadrado nuevo = new Cuadrado(datoActual);

                if (!Cuadrado.esValido(datoActual))
                {
                    MessageBox.Show("El lado tiene que ser mayor a 0 y menor o igual a 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ExisteFigura(nuevo,arFiguras, ultimo))
                {
                    MessageBox.Show("El cuadrado ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    arFiguras[++ultimo] = nuevo;
                    actualizarListado();
                    MessageBox.Show("Se ha creado exitosamente", "Crear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbFiguras.SelectedIndex = 0;
                }
                tRadio.Text = "";
                tRadio.Focus();
            }
            else if (rbRectangulo.Checked)
            {
                Rectangulo nuevo = new Rectangulo(datoActual, alturaActual);

                if (!Rectangulo.esValido(datoActual, alturaActual))
                {
                    MessageBox.Show("La base y la altura tienen que ser mayores a 0, y menores o iguales a 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ExisteFigura(nuevo,arFiguras, ultimo))
                {
                    MessageBox.Show("El rectangulo ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    arFiguras[++ultimo] = nuevo;
                    actualizarListado();
                    MessageBox.Show("Se ha creado exitosamente", "Crear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbFiguras.SelectedIndex = 0;
                }
                tRadio.Text = "";
                tAltura.Text = "";
                tRadio.Focus();
            }
            else
            {
                double ladoUno = Convert.ToDouble(tLadoUno.Text);
                double ladoDos = Convert.ToDouble(tLadoUno.Text);
                Triangulo nuevo = new Triangulo(datoActual, alturaActual, ladoUno, ladoDos);

                if (!Triangulo.esValido(datoActual, alturaActual,ladoUno,ladoDos))
                {
                    MessageBox.Show("La base,la altura y los lados tienen que ser mayores a 0, y menores o iguales a 1000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ExisteFigura(nuevo,arFiguras, ultimo))
                {
                    MessageBox.Show("El triangulo ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    arFiguras[++ultimo] = nuevo;
                    actualizarListado();
                    MessageBox.Show("Se ha creado exitosamente", "Crear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbFiguras.SelectedIndex = 0;
                }
                tRadio.Text = "";
                tAltura.Text = "";
                tLadoUno.Text = "";
                tLadoDos.Text = "";
                tRadio.Focus();
            }
        }
        private void bArea_Click(object sender, EventArgs e)
        {
            if (lbFiguras.Items.Count == 0)
            {
                MessageBox.Show("No existe ningun elemento en el listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = BuscarPosicion(lbFiguras.SelectedItem.ToString());
                MessageBox.Show($"El area es: {arFiguras[i].Area()}");
            }
        }
        private void bPerimetro_Click(object sender, EventArgs e)
        {
            if (lbFiguras.Items.Count == 0)
            {
                MessageBox.Show("No existe ningun elemento en el listado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int i = BuscarPosicion(lbFiguras.SelectedItem.ToString());
                MessageBox.Show($"El perimetro es: {arFiguras[i].Perimetro()}");
            }
        }
        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
                Close();
        }
        #endregion

        #region cambioRB
        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarGB();
            actualizarListado();
        }
        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            actualizarGB();
            actualizarListado();
        }
        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarGB();
            actualizarListado();
        }
        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            actualizarGB();
            actualizarListado();
        }
        #endregion
    }
}