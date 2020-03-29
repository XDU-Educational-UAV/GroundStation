using System.IO;
using System.Text;

namespace GroundStation
{
    class FileWrite
    {
        private FileStream fs = new FileStream("data.dat", FileMode.Create);
        public void Write_Double_Pair_Data(double a, double b)
        {
            string stra = a.ToString("#0.00");
            string strb = b.ToString("#0.00");
            string str = stra + " " + strb + "\r\n";
            byte[] data = Encoding.UTF8.GetBytes(str);
            fs.Write(data, 0, data.Length);
        }
        public void Write_File()
        {
            fs.Flush();
            fs.Close();
        }
    }
}
