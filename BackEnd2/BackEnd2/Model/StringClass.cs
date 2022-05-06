using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd2.Model
{
    public class StringClass : IEncodeAndDecode
    {
        public string Encode(string request, string inputData)
            {
            byte[] m = Encoding.ASCII.GetBytes(request);
            string a = "";
            for (int i = 0; i < m.Length; i++)
            {
                a = a + m[i].ToString();
                if (i < m.Length - 1)
                {
                    a = a + "-";
                }
            }
            return a;
        }
        public string Decode(string request, string outputData)
        {
            string[] a = request.Split("-");
            List<byte> b = new List<byte>();
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    b.Add((byte)int.Parse(a[i].ToString()));
                }
            }
            catch (Exception e)
            {
                return "wrong data";
            }
            return Encoding.ASCII.GetString(b.ToArray());
        }
    }

}
