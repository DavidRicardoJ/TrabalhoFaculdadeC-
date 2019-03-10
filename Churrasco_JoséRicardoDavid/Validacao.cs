using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Validar 
    {
        public bool validar(string value)
        {
            try
            {
                double valueVerification = double.Parse(value);
                return true;
            }
            catch
            {
                MessageBox.Show("Valor incorreto, verifique a digitação.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

    }
}
