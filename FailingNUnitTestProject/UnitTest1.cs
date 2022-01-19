using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FailingNUnitTestProject;

public enum MyEnum
{
    Enum1,
    Enum2,
    Enum3,
    Enum4,
}

[TestFixtureSource(nameof(GetAllMyEnums))]
public abstract class BaseClass
{
    public static readonly IEnumerable<MyEnum> GetAllMyEnums = new[] { MyEnum.Enum1, MyEnum.Enum2, MyEnum.Enum3, MyEnum.Enum4};
    private readonly MyEnum _myEnum;

    protected BaseClass(MyEnum myEnum)
    {
        _myEnum = myEnum;
    }
}

public class MyClass : BaseClass
{
    public MyClass(MyEnum myEnum) : base(myEnum)
    {
    }

    [Test]
    public async Task MyTest()
    {
        await Task.CompletedTask;
    }
    
    [Test]
    public async Task MyTest2()
    {
        await Task.CompletedTask;
    }
}