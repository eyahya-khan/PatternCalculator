# The Pattern Calculator

It's time to build a calculator again... it's the best thing you can do with code, right? :)

This time, we are going to use a few of the patterns that we talked about during the week - and build a pattern-based calculator. This specification will be written using much of the concepts and language that we have used in the last two weeks. You can go back and look up the what the concepts means in the slides.

## Specification

There are three main patterns we are going to use; `Factory method`, `Command Object` pattern, and `Fluent API` (which could be called Chain of Responsibility, but it's a bit of stretch in this case) to build our calculator. We want to end up with a calculator that can be called like this:

```c#
var cmd = CalculationCommandFactory.CreateCalculationCommand(OperationType.Add, new[] { 1, 2, 3, 4 });

var calc = new FluentCalculator();
var result1 = calcCalculate(cmd).GetResult();
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

Clone this repository:

```bash
git clone git@github.com:saltSthlm/dnfs-summer-22-test-patternCalculator.git
cd dnfs-summer-22-test-patternCalculator
```

Then restore the projects dependencies

```bash
dotnet restore
```

And then to run the tests

```bash
dotnet test
```

We have supplied tests that you can use to verify your code, but left it commented out so that your code will compile. You will need to uncomment these test to implement the rest of the methods for the tests. These are not all the test you will need to verify that your implementation works.

## Evaluation

Evaluation will be done by:

- running our own test suite (not supplied, that validates the specification above with more cases) against your code.
- looking through the code and making sure that it is easy to understand and well written

## Handing in the solution

Upload the `Solution.cs` in a folder called `patternCalculator`.

## FAQ

Should we also submit our test files?

> Nope. But you should write tests to make sure your code works.

Where's my starting tests?

> There are none, this time around. You probably know how to write one by now... or this a good time to learn

Should we handle errors

> Yes - see "Error handling" above
