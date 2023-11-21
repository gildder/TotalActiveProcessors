using System;
using System.Threading;

namespace ProcessorInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            int processorCount = Environment.ProcessorCount;
            Console.WriteLine($"Número total de procesadores lógicos: {processorCount}");

            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                Console.WriteLine($"Nombre del procesador: {item["Name"]}");
                Console.WriteLine($"Descripción: {item["Description"]}");
                Console.WriteLine($"ID del procesador: {item["ProcessorId"]}");
                Console.WriteLine($"Velocidad del reloj: {item["MaxClockSpeed"]} MHz");
            }

            // Pausa el programa por 15 segundos
            Thread.Sleep(15000);
        }
    }
}
