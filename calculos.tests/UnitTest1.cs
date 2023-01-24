namespace calculos.tests;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
    }

    [Theory]
    [InlineData(0.342, 0.34)]
    [InlineData(0.346, 0.35)]
    [InlineData(0.3452, 0.35)]
    [InlineData(0.3450, 0.34)]
    [InlineData(0.332, 0.33)]
    [InlineData(0.336, 0.34)]
    [InlineData(0.3352, 0.34)]
    [InlineData(0.3350, 0.34)]
    [InlineData(0.3050, 0.30)]
    [InlineData(0.3150, 0.32)]
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