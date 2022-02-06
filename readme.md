>## Objetivo
Demonstrar a diferença de performance entre `string` vs `StringBuilder`.

Neste processo, a ideia é demonstrar, como o uso de concatenação de string pode performar negativamente em um trecho de código muito executado ou com uma carga de dados grande.


>## Resultados

``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10
Intel Core i5 CPU 2.70GHz, 1 CPU, 4 logical and 4 physical cores
.NET SDK=6.0.200-preview.22055.15
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|                                  Method |      Mean |    Error |    StdDev |    Gen 0 | Allocated |
|---------------------------------------- |----------:|---------:|----------:|---------:|----------:|
|      UsandoConcatenacaoDeStringComArray | 237.11 μs | 1.346 μs |  1.259 μs | 908.9355 |  2,786 KB |
| UsandoConcatenacaoDeStringComEnumerable | 245.54 μs | 5.062 μs | 14.605 μs | 908.9355 |  2,786 KB |
|             UsandoStringBuilderComArray |  11.44 μs | 0.077 μs |  0.072 μs |   4.7455 |     15 KB |
|  UsandoStringBuilderStringComEnumerable |  11.53 μs | 0.086 μs |  0.076 μs |   4.7455 |     15 KB |
