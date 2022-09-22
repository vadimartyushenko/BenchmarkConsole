// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using System.Collections.Generic;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private static List<int> _list;



    [Params(100, 100_000, 1_000_000)]
    public int Size { get; set; }

    [GlobalSetup]
    public void GlobalSetup()
    {
        _list = Enumerable.Range(1, Size).ToList();
        
    }

    [Benchmark]
    public void TestHashSetApproach()
    {
        var result = _list.ContainsDuplicatesHashSetApproach();
    }
    [Benchmark]
    public void TestContainsDuplicatesDistinctCountApproach()
    {
        var result = _list.ContainsDuplicatesDistinctCountApproach();
    }
}