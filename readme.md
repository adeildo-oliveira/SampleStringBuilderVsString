[![Build status](https://ci.appveyor.com/api/projects/status/ucxwgqb0ypj73tt9?svg=true)](https://ci.appveyor.com/project/adeildo-oliveira/StringLinearSearch)

>## Objetivo
Para efetuar buscas em uma string, usamos diferentes estratégias, uma delas é os uso do já conhecido `Regex`. No entanto, ao usa-lo em um cenário de alta performance, percebemos maior uso de memória e maior tempo de reposta.

Uma solução para este cenário é usarmos um algoritmos que dispese menor alocação e com isso maior tempo de resposta.

>## Sample Linear Search
Buscando uma maneira de como resolver isso, podemos usar o `stringbuilder` aliado a um loop de repetição.

Neste cenário, temos uma operação de ordem linear, ou seja, uma complexidade O(n).

>## Resultados

|                       Method |                input |      Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------------- |--------------------- |----------:|---------:|---------:|-------:|------:|------:|----------:|
|  **ExtractIntUsingLinearSearch** | **32Wit(...)le.42 [35]** |  **91.37 ns** | **1.648 ns** | **1.692 ns** | **0.0126** |     **-** |     **-** |      **40 B** |
| ExtractIntUsingCompiledRegex | 32Wit(...)le.42 [35] | 157.76 ns | 2.954 ns | 2.764 ns | 0.0763 |     - |     - |     240 B |
|  **ExtractIntUsingLinearSearch** |                   **42** |  **42.35 ns** | **0.422 ns** | **0.352 ns** | **0.0102** |     **-** |     **-** |      **32 B** |
| ExtractIntUsingCompiledRegex |                   42 | 141.49 ns | 1.033 ns | 0.915 ns | 0.0663 |     - |     - |     208 B |
|  **ExtractIntUsingLinearSearch** | **42, s(...)mber. [27]** |  **71.83 ns** | **0.626 ns** | **0.489 ns** | **0.0101** |     **-** |     **-** |      **32 B** |
| ExtractIntUsingCompiledRegex | 42, s(...)mber. [27] | 155.08 ns | 2.325 ns | 2.175 ns | 0.0763 |     - |     - |     240 B |
|  **ExtractIntUsingLinearSearch** |  **O(lo(...) on. [224]** |        **NA** |       **NA** |       **NA** |      **-** |     **-** |     **-** |         **-** |
| ExtractIntUsingCompiledRegex |  O(lo(...) on. [224] | 264.81 ns | 2.948 ns | 2.614 ns | 0.0739 |     - |     - |     232 B |
|  **ExtractIntUsingLinearSearch** | **The s(...)s 42. [24]** |  **65.81 ns** | **0.862 ns** | **0.764 ns** | **0.0101** |     **-** |     **-** |      **32 B** |
| ExtractIntUsingCompiledRegex | The s(...)s 42. [24] | 178.73 ns | 3.558 ns | 5.215 ns | 0.0763 |     - |     - |     240 B |
|  **ExtractIntUsingLinearSearch** | **With (...)ddle. [31]** |  **72.42 ns** | **1.455 ns** | **1.557 ns** | **0.0101** |     **-** |     **-** |      **32 B** |
| ExtractIntUsingCompiledRegex | With (...)ddle. [31] | 174.36 ns | 3.470 ns | 5.797 ns | 0.0763 |     - |     - |     240 B |

Benchmarks with issues:
  BechmarkTest.ExtractIntUsingLinearSearch: DefaultJob [input=O(lo(...) on. [224]]
