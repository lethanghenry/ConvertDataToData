using BackEnd2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd2.AdapterFolder
{
    public class Adapter 
    {
       
        public string Encode(string request, string inputData)
        {
            if (String.Compare("String",inputData)==0)
                {
                    StringClass stringClass = new StringClass();
                    return stringClass.Encode(request, "String");
                }
                else if (String.Compare("Hex", inputData) == 0)
                {
                    HexClass hexClass = new HexClass();
                    return hexClass.Encode(request, "Hex");
                }
               else if (String.Compare("Base64", inputData) == 0)
                {
                    Base64Class base64Class = new Base64Class();
                    return base64Class.Encode(request, "Base64");
                }
            
            return request;

        }
        public string Decode(string request, string outputData)
        {
            //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            //myDictionary.Add(1, "String");
            //myDictionary.Add(2, "Hex");
            //myDictionary.Add(3, "Base64");
            //myDictionary.Add(4, "Byte");
            //foreach(var item in myDictionary)
            //{
                if (String.Compare("String", outputData) == 0)
                {
                    StringClass stringClass = new StringClass();
                    return stringClass.Decode(request, "String");
                }
                else if (String.Compare("Hex", outputData) == 0)
                {
                    HexClass hexClass = new HexClass();
                    return hexClass.Decode(request, "Hex");
                }
                else if (String.Compare("Base64", outputData) == 0)
                {
                    Base64Class base64Class = new Base64Class();
                    return base64Class.Decode(request, "Base64");
                }
            
            return request;
        }




    }
}
