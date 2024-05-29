[TestFixture]
public class CalculatorTests
{
    [Test]
    public void AddTest(
        [Values(1, 2, 3)] int a,
        [Values(1, 2, 3)] int b)
    {

        var calculator = new Calculator();
        int expected = a + b;
        int result = calculator.Add(a, b);

        Assert.AreEqual(expected, result);
    }
}

public class Calculator
{
    public int Add(int x, int y) => x + y;
}
