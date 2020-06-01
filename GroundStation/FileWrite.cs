using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GroundStation
{
    class FileWrite
    {
        private readonly FileStream fs;
        public FileWrite()
        {
            if (fs == null)
                fs = new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.Write);
        }
        public void Write_Double_Pair_Data(double a, double b)
        {
            string stra = a.ToString("#0.0000");
            string strb = b.ToString("#0.0000");
            string str = stra + " " + strb + "\r\n";
            byte[] data = Encoding.UTF8.GetBytes(str);
            try
            {
                fs.Write(data, 0, data.Length);
            }
            catch (Exception) { }
        }
        public void Write_File()
        {
            try
            {
                fs.Flush();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
