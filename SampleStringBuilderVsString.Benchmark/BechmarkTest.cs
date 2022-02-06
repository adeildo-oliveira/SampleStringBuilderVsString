using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;
using SampleStringBuilderVsString;

[MemoryDiagnoser]
[EventPipeProfiler(EventPipeProfile.CpuSampling)]
public class BechmarkTest
{
    private readonly int[] _numeros;
    public BechmarkTest() => _numeros = Enumerable.Range(1, 1000).ToArray();

    [Benchmark]
    public string UsandoConcatenacaoDeStringComArray() => SampleExample.ParseNumberString(_numeros);

    [Benchmark]
    public string UsandoConcatenacaoDeStringComEnumerable() => SampleExample.ParseNumberString(_numeros);

    [Benchmark]
    public string UsandoStringBuilderComArray() => SampleExampleOtimization.ParseNumberString(_numeros);

    [Benchmark]
    public string UsandoStringBuilderStringComEnumerable() => SampleExampleOtimization.ParseNumberString(_numeros);
}