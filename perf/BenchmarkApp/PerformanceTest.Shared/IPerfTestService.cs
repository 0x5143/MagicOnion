using MagicOnion;
using MessagePack;

namespace PerformanceTest.Shared;

public interface IPerfTestService : IService<IPerfTestService>
{
    UnaryResult<Nil> UnaryParameterless();
    UnaryResult<string> UnaryArgRefReturnRef(string arg1);
    UnaryResult<string> UnaryArgDynamicArgumentTupleReturnRef(string arg1, int arg2);
    UnaryResult<int> UnaryArgDynamicArgumentTupleReturnValue(string arg1, int arg2);
    UnaryResult<(int StatusCode, byte[] Data)> UnaryLargePayloadAsync(string arg1, int arg2, byte[] arg3);
    UnaryResult<ComplexResponse> UnaryComplexAsync(string arg1, int arg2);
}

[MessagePackObject]
public class ComplexResponse
{
    public static ComplexResponse Cached { get; } = new ComplexResponse
    {
        Value1 = true,
        Value2 = 1234567,
        Value3 = new InnerObject1
        {
            Value1 = 987654321,
            Value2 = "FooBarBazQux",
            Value3 = 1234567890123,
            Value4 = true,
            Value5 = 123456789,
            Value6 = 0,
            Value7 = 20,
            Value8 = 256,
            Value9 = DateTimeOffset.Now,
        },
        Value4 = new InnerObject2[]
        {
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
            new InnerObject2 { Value1 = 123456789, Value2 = 123 },
        },
    };

    [Key(0)]
    public bool Value1 { get; set; }
    [Key(1)]
    public int Value2 { get; set; }
    [Key(2)]
    public InnerObject1 Value3 { get; set; } = default!;
    [Key(3)]
    public IReadOnlyList<InnerObject2> Value4 { get; set; } = default!;

    [MessagePackObject]
    public class InnerObject1
    {
        [Key(0)]
        public int Value1 { get; set; }
        [Key(1)]
        public string Value2 { get; set; } = default!;
        [Key(2)]
        public long Value3 { get; set; }
        [Key(3)]
        public bool Value4 { get; set; }
        [Key(4)]
        public int Value5 { get; set; }
        [Key(5)]
        public int Value6 { get; set; }
        [Key(6)]
        public int Value7 { get; set; }
        [Key(7)]
        public int Value8 { get; set; }
        [Key(8)]
        public DateTimeOffset Value9 { get; set; }
    }
    
    [MessagePackObject]
    public class InnerObject2
    {
        [Key(0)]
        public long Value1 { get; set; }
        [Key(1)]
        public int Value2 { get; set; }
    }
}