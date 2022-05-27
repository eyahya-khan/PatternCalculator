## Specification

There are three main patterns we are going to use; `Factory method`, `Command Object` pattern, and `Fluent API` (which could be called Chain of Responsibility, but it's a bit of stretch in this case) to build our calculator. We want to end up with a calculator that can be called like this:

```c#
var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2, 3, 4 });

var calc = new FluentCalculator();
var result1 = calc.Calculate(cmd).GetResult();
var result2 = calc.Calculate(cmd).Calculate(cmd).Calculate(cmd).GetResult();
var result3 = calc.Calculate(cmd).Calculate(cmd).GetResult();

Console.WriteLine(result1 == 10); // true
Console.WriteLine(result2 == 20); // true
Console.WriteLine(result3 == 20); // true
```

- Build a calculator class `FluentCalculator` that supports the fluent interface shown above

  - Ensure that you can pass a command object into the `Calculate`-method
  - Have a `GetResult()` method that returns the current result of all calculations made
  - Ensure that the result is initialized to 0

- Make the `Calculate`-methods should follow the Command object pattern

  - Name the command class `CalculationCommand`
    - Have an array of integers as an `Arguments`-property
    - Define an `OperationType` property that is an `enum` of the possible calculations.
      - Let the `OperationType` enum have the following values; `Add` and `Subtract`
  - Write code in the `Calculate`-method that performs the given `OperationType` on all `Arguments`
    - The type of calculation is defined in the command object's `OperationType`-property
    - Perform the calculation on all the arguments in the `Arguments` array
    - If there are no arguments in the `Arguments` array no calculation should be made, and previous result is unchanged

- Only allow clients to create `CalculationCommand` through a factory method

  - Call the factory `CalculationCommandFactory` and the factory method `CreateCalculationCommand`
  - Create overloaded versions of the factory method that takes:
    - Only an operation type
    - An operation type and a single integer
    - An operation type and an array of integers
  - Make the factory and factory method static

- Error handling
  - All other errors can be left uncaught (no checking for division by 0 etc.), you can also assume only integer values being passed in.
  - Only return integers too... which makes some of the math strange (2/4 will be equal 0 in this case), but the test is about writing code, not making perfect math-calculations.

## Get started

Clone this repository.


Then restore the projects dependencies

```bash
dotnet restore
```

And then to run the tests

```bash
dotnet test
```

Uncomment test and try to solve all the test