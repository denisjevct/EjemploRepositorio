namespace TestCalculadora;

public class TestOperaciones
{
    [Fact]
    public void sumaOK()
    {
        var op = new Operaciones();
        int res = op.Suma(1,2);
        Assert.Equal(3, res);
    }

    [Fact]
    public void restaOK()
    {
        var op = new Operaciones();
        int res = op.Resta(4,2);
        Assert.Equal(2, res);
    }
}