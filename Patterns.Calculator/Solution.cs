using System;
using System.Linq;

namespace Patterns
{
    public class FluentCalculator
    {
        private readonly int Result;
        public FluentCalculator() : this(0) { }

        public FluentCalculator(int result)
        {
            Result = result;
        }
        public FluentCalculator Calculate(CalculationCommand command)
        {
            if (command.Arguments.Length < 1)
                return new FluentCalculator(this.Result);

            switch (command.OperationType)
            {
                case OperationType.Add:
                    {
                        return new FluentCalculator(this.Result + command.Arguments.Sum());
                    }
                case OperationType.Subtract:
                    {
                        return new FluentCalculator(this.Result - command.Arguments.Sum());
                    }
                default:
                    throw new ArgumentException("Unsupported operation type");
            }
        }
        public int GetResult() { return this.Result; }
    }


    public enum OperationType
    {
        Add, Subtract
    }
    public class CalculationCommand
    {
        public OperationType OperationType { get; private set; }
        public int[] Arguments { get; private set; }

        private CalculationCommand()
        {
            Arguments = new int[] { };
        }
        private CalculationCommand(OperationType type)
          : this(type, new[] { 0 })
        { }
        private CalculationCommand(OperationType type, int argument)
          : this(type, new[] { argument })
        { }
        private CalculationCommand(OperationType type, int[] arguments)
          : this()
        {
            this.OperationType = type;
            this.Arguments = arguments;
        }


        public static class CalculationCommandFactory
        {
            public static CalculationCommand CreateCalculationCommand(OperationType type)
            {
                return new CalculationCommand(type);
            }

            public static CalculationCommand CreateCalculationCommand(OperationType type, int argument)
            {
                return new CalculationCommand(type, argument);
            }

            public static CalculationCommand CreateCalculationCommand(OperationType type, int[] arguments)
            {
                return new CalculationCommand(type, arguments);
            }
        }
    }
}