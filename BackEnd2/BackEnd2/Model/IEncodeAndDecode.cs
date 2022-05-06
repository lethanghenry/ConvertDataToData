using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd2.Model
{
    interface IEncodeAndDecode
    {
        string Encode(string request, string inputData);
        string Decode(string request,  string outputData);
    }
}
