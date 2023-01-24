namespace calculos.tests;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    }

    [Theory]
    [InlineData(0.242, 0.24)]
    [InlineData(1.342, 1.34)]
    [InlineData(2.346, 2.35)]
    [InlineData(3.3452, 3.35)]
    [InlineData(4.3450, 4.34)]
    [InlineData(5.332, 5.33)]
    [InlineData(6.336, 6.34)]
    [InlineData(7.3352, 7.34)]
    [InlineData(8.3350, 8.34)]
    [InlineData(9.3050, 9.30)]
    [InlineData(10.3150, 10.32)]
    [InlineData(1.333, 1.33)]
    [InlineData(1.666, 1.67)]
    [InlineData(4.850, 4.85)]
    [InlineData(4.550, 4.55)]
    [InlineData(4.850, 4.85)]
    public void TestRoundAbnt(decimal valorOriginal, decimal arredondadoEsperado)
    {
        decimal arredondadoMetodoABNT = valorOriginal.RoundAbnt(2);
        Assert.Equal(arredondadoEsperado, arredondadoMetodoABNT);
    }

    [Theory]
    [InlineData(1.333, 1.3)]
    [InlineData(1.666, 1.7)]
    [InlineData(4.850, 4.9)]
    [InlineData(4.550, 4.6)]
    [InlineData(4.850, 4.8)]
    public void TestRoundAbntDecimal1(decimal valorOriginal, decimal arredondadoEsperado)
    {
        decimal arredondadoMetodoABNT = valorOriginal.RoundAbnt(1);
        Assert.Equal(arredondadoEsperado, arredondadoMetodoABNT);
    }
}