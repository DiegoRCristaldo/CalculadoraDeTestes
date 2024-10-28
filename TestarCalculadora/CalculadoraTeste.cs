using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTeste
{
    [Fact]
    public void Soma2mais2retorna4()
    {
        //Arrange
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoEsperado = 4;

        //Act
        int resultado = calc.Somar(2, 2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Fact]
    public void Subtrair8menos2retorna6()
    {
        //Arrange
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoEsperado = 6;

        //Act
        int resultado = calc.Subtrair(8, 2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Fact]
    public void Multiplicar5vezes2retorna10()
    {
        //Arrange
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoEsperado = 10;

        //Act
        int resultado = calc.Multiplicar(5, 2);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
    [Fact]
    public void Dividir21por3retorna7()
    {
        //Arrange
        CalculadoraImp calc = new CalculadoraImp();
        int resultadoEsperado = 7;

        //Act
        int resultado = calc.Dividir(21, 3);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}