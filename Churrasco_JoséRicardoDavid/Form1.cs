using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace inData
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region previa validação e Enter para textbox.

        private void txtCarne_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtCarne.Text))
                {
                    txtQuantCarne.Focus();
                }



            }
        }

        private void txtLinguica_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtLinguica.Text))
                {
                    txtQuantLinguica.Focus();
                }



            }
        }

        private void txtPaoDeAlho_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtPaoDeAlho.Text))
                {
                    txtQuantPaoAlho.Focus();
                }
            }
        }

        private void txtCerveja_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtCerveja.Text))
                {
                    txtQuantCerveja.Focus();
                }
            }
        }

        private void txtRefri_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtRefri.Text))
                {
                    txtQuantRefri.Focus();
                }
            }
        }

        private void txtCarvao_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtCarvao.Text))
                {
                    txtQuantCarvao.Focus();
                }
            }
        }

        private void txtQuantCarne_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtQuantCarne.Text))
                {
                    txtLinguica.Focus();
                }
            }
        }

        private void txtQuantLinguica_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtQuantLinguica.Text))
                {
                    txtPaoDeAlho.Focus();
                }
            }
        }

        private void txtQuantPaoAlho_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtQuantPaoAlho.Text))
                {
                    txtCerveja.Focus();
                }
            }
        }

        private void txtQuantCerveja_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtQuantCerveja.Text))
                {
                    txtRefri.Focus();
                }
            }
        }

        private void txtQuantRefri_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtQuantRefri.Text))
                {
                    txtCarvao.Focus();
                }
            }
        }

        private void txtQuantCarvao_KeyDown(object sender, KeyEventArgs e)
        {
            Validar valide = new Validar();

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;

                if (valide.validar(txtQuantCarvao.Text))
                {
                    txtQuantPessoas.Focus();
                }
            }
        }

        private void txtQuantPaoAlho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantCerveja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private void btnCalcular_Click(object sender, EventArgs e)
        {



            if (verificarCampos() & verificarCampos2() & verificaCampos3())
            {
                InsertData();
            }
            else
            {
                MessageBox.Show("Verifique os campos em amarelo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




        }
        #region verificar campos preenchidos e campos vazios.
        public bool verificarCampos()
        {
            int cont = 0;

            foreach (Control c in this.panel1.Controls)
            {

                if (c is TextBox)
                {
                    if (c.Text == String.Empty)
                    {
                        c.BackColor = Color.Yellow;
                        cont++;
                    }
                    else c.BackColor = Color.White;
                }
                try
                {
                    if (c is TextBox)
                    {
                        double convert = double.Parse(c.Text);
                        c.BackColor = Color.White;
                    }

                }
                catch
                {
                    if (c is TextBox)
                    {
                        c.BackColor = Color.Yellow;
                        cont++;
                    }

                }
            }

            if (cont == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verificarCampos2()
        {
            int cont = 0;

            foreach (Control c in this.panel2.Controls)
            {

                if (c is TextBox)
                {
                    if (c.Text == String.Empty)
                    {
                        c.BackColor = Color.Yellow;
                        cont++;
                    }
                    else c.BackColor = Color.White;
                }
                try
                {
                    if (c is TextBox)
                    {
                        double convert = double.Parse(c.Text);
                        c.BackColor = Color.White;
                    }

                }
                catch
                {
                    if (c is TextBox)
                    {
                        c.BackColor = Color.Yellow;
                        cont++;
                    }

                }
            }

            if (cont == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool verificaCampos3()
        {
            if (chkCalcPessoa.Checked == true && txtQuantPessoas.Text == String.Empty)
            {
                txtQuantPessoas.BackColor = Color.Yellow;
                return false;
            }
            else
            {
                txtQuantPessoas.BackColor = Color.White;
                return true;
            }
        }
        #endregion


        private void InsertData()
        {
            try
            {
                double precoCarne = double.Parse(txtCarne.Text);
                double quantCarne = double.Parse(txtQuantCarne.Text);
                double precolinguica = double.Parse(txtLinguica.Text);
                double quantLinguica = double.Parse(txtQuantLinguica.Text);
                double precoPao = double.Parse(txtPaoDeAlho.Text);
                double quantPao = double.Parse(txtQuantPaoAlho.Text);

                double precoCerveja = double.Parse(txtCerveja.Text);
                double quantCerveja = double.Parse(txtQuantCerveja.Text);
                double precoRefri = double.Parse(txtRefri.Text);
                double quantRefri = double.Parse(txtQuantRefri.Text);
                double precoCarvao = double.Parse(txtCarvao.Text);
                double quantCarvao = double.Parse(txtQuantCarvao.Text);

                double nPessoas = double.Parse(txtQuantPessoas.Text);

                Churrasco churrasco = new Churrasco(precoCarne, quantCarne, precolinguica, quantLinguica, precoPao, quantPao, precoCerveja, quantCerveja,
               precoRefri, quantRefri, precoCarvao, quantCarvao, nPessoas);

                TxtValorTotal.Text = churrasco.valorTotal().ToString("F");

                if (chkCalcPessoa.Checked == true)
                {
                    double valorPorPessoa = churrasco.valorTotal() / churrasco.NPessoas;

                    txtValorPorPessoa.Text = valorPorPessoa.ToString("F");

                }
            }
            catch
            {
                MessageBox.Show("Erro de conversão, verifique os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
