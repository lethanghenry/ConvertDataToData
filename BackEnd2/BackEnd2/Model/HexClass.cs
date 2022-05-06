using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd2.Model
{
    public class HexClass:IEncodeAndDecode
    {
        public string Encode(string request, string inputData)
        {
            byte[] m;
            try
            {
                m = Enumerable.Range(0, request.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(request.Substring(x, 2), 16)).ToArray();
            }
            catch (Exception e)
            {
                return "wrong data";
            }
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
            return Convert.ToHexString(b.ToArray());


        }
    }
}
