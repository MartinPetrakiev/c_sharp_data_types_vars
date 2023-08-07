using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteVar = -115; //-128 to 127
            byte byteVar = 97; //0 to 255
            short shortVar = -10000; //	-32,768 to 32,767
            ushort ushortVar = 52130; //	0 to 65,535
            int intVar = 4825932; //	-2,147,483,648 to 2,147,483,647
            uint uintVar = 4825932; //	0 to 4,294,967,295
            long longVar = 4825932; // -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong ulongVar = 4825932; //0 to 18,446,744,073,709,551,615
        }
    }
}

//52130, -115, 4825932, 97, -10000