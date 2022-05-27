namespace Patterns.Tests
{
  public class PatternCalculatorTests
  {
    // [Fact]
    // public void should_create_command_with_only_operation()
    // {
    //   // act
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add);

    //   // assert
    //   cmd.Should().NotBe(null);
    //   cmd.OperationType.Should().Be(OperationType.Add);
    // }

    // [Fact]
    // public void should_create_command_with_operation_and_single_argument()
    // {
    //   // act
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, 12);

    //   // assert
    //   cmd.Should().NotBe(null);
    //   cmd.OperationType.Should().Be(OperationType.Add);
    //   cmd.Arguments.Length.Should().Be(1);
    // }

    // [Fact]
    // public void should_create_command_with_operation_and_array_of_arguments()
    // {
    //   // act
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2, 3, 4 });

    //   // assert
    //   cmd.Should().NotBe(null);
    //   cmd.OperationType.Should().Be(OperationType.Add);
    //   cmd.Arguments.Length.Should().Be(4);
    // }

    // [Fact]
    // public void should_return_a_fluentCalculator_from_calculate()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add);

    //   // act
    //   var next = calc.Calculate(cmd);

    //   // assert
    //   next.Should().NotBe(null);
    //   next.Should().BeOfType(typeof(FluentCalculator));
    // }

    // [Fact]
    // public void should_return_0_as_initial_result()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();

    //   // act
    //   var result = calc.GetResult();

    //   // assert
    //   result.Should().Be(0);
    // }

    // [Fact]
    // public void should_echo_argument_for_add_of_single_argument()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, 12);

    //   // act
    //   var result = calc.Calculate(cmd).GetResult();

    //   // assert
    //   result.Should().Be(12);
    // }

    // [Fact]
    // public void should_add_array_of_numbers()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2, 3, 4, 5 });

    //   // act
    //   var result = calc.Calculate(cmd).GetResult();

    //   // assert
    //   result.Should().Be(15);
    // }

    // [Fact]
    // public void should_chain_add_commands()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd1 = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1 });
    //   var cmd2 = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2 });
    //   var cmd3 = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2, 3 });
    //   var cmd4 = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2, 3, 4 });

    //   // act
    //   var result = calc
    //     .Calculate(cmd1)
    //     .Calculate(cmd2)
    //     .Calculate(cmd3)
    //     .Calculate(cmd4)
    //     .GetResult();

    //   // assert
    //   result.Should().Be(20);
    // }


    // [Fact]
    // public void should_echo_argument_for_subtract_of_single_argument()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Subtract, 12);

    //   // act
    //   var result = calc.Calculate(cmd).GetResult();

    //   // assert
    //   result.Should().Be(-12);
    // }

    // [Fact]
    // public void should_subtract_array_of_numbers()
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Subtract, new[] { 5, 4, 3, 2, 1 });

    //   // act
    //   var result = calc.Calculate(cmd).GetResult();

    //   // assert
    //   result.Should().Be(-15);
    // }


    // [Theory]
    // [InlineData(15, 15, 30)]
    // [InlineData(10, 15, 0)]
    // [InlineData(15, 10, 50)]
    // [InlineData(1, 100, -394)]
    // [InlineData(100, 1, 596)]
    // public void should_chain_mixed_commands(int addParameter, int subtractParameter, int expectedResult)
    // {
    //   // arrange
    //   var calc = new FluentCalculator();
    //   var cmd1 = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { addParameter, addParameter });
    //   var cmd2 = CalculationCommandFactory.CreateCalculationCommand(OperationType.Subtract, new[] { subtractParameter, subtractParameter });

    //   // act
    //   var result = calc
    //     .Calculate(cmd1)
    //     .Calculate(cmd2)
    //     .Calculate(cmd1)
    //     .Calculate(cmd2)
    //     .Calculate(cmd1)
    //     .GetResult();

    //   // assert
    //   result.Should().Be(expectedResult);
    // }
  }
}
