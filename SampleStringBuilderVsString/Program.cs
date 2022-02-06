using SampleStringBuilderVsString;
using System.Diagnostics;

if (args.Length > 0)
{
    int gc0 = GC.CollectionCount(0);
    int gc1 = GC.CollectionCount(1);
    int gc2 = GC.CollectionCount(2);

    var sw = new Stopwatch();
    sw.Start();

    TestarAlgoritmo(int.Parse(args[0]));

    sw.Stop();
    Console.WriteLine($"\nTempo: {sw.Elapsed}s");
    Console.WriteLine($"  Gen0: {GC.CollectionCount(0) - gc0}");
    Console.WriteLine($"  Gen1: {GC.CollectionCount(1) - gc1}");
    Console.WriteLine($"  Gen2: {GC.CollectionCount(2) - gc2}");
    Console.WriteLine($"Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024}mb");
}

void TestarAlgoritmo(int tipo)
{
    var numeros = Enumerable.Range(1, 1000);

    switch (tipo)
    {
        case 1:
            // Pior cenário: 00:00:00.0091134s - melhor: 00:00:00.0082978s
            // 18mb
            Console.WriteLine("Usando Concatenação de Strings com Array");
            Console.WriteLine(SampleExample.ParseNumberString(numeros.ToArray()));
            break;
        case 2:
            // Pior cenário: 00:00:00.0101379s - melhor: 00:00:00.0085114s
            // 18mb
            Console.WriteLine("Usando Concatenação de Strings com Enumerable");
            Console.WriteLine(SampleExample.ParseNumberString(numeros));
            break;
        case 3:
            // Pior cenário: 00:00:00.0082356s - melhor: 00:00:00.0072257s
            // 16mb
            Console.WriteLine("Usando StringBuilder de Strings com Array");
            Console.WriteLine(SampleExampleOtimization.ParseNumberString(numeros.ToArray()));
            break;
        case 4:
            // Pior cenário: 00:00:00.0080734s - melhor: 00:00:00.0074492s
            // 16mb
            Console.WriteLine("Usando StringBuilder de Strings com Enumerable");
            Console.WriteLine(SampleExampleOtimization.ParseNumberString(numeros.ToArray()));
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}