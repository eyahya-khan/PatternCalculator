using System;

namespace Patterns
{
    public enum OperationType
    {
        Add,
        Subtract
    }

    public static class CalculationCommandFactory
    {
        public static CalculationCommand CreateCalculationCommand(OperationType operation)
        {
            switch (operation)
            {
                case OperationType.Add:
                    return new AdditionCommand();
                case OperationType.Subtract:
                    return new SubtractionCommand();
                default:
                    throw new ApplicationException("Some Exception in code");
            }
        }
            public static CalculationCommand CreateCalculationCommand(OperationType operation, int[] array)
        {
            switch (operation)
            {
                case OperationType.Add:
                    return new AdditionCommand(array);
                case OperationType.Subtract:
                    return new SubtractionCommand(array);
                default:
                    throw new ApplicationException("Some Exception in code");
            }          
        }
        
        public static CalculationCommand CreateCalculationCommand(OperationType operation, int value)
        {
            switch (operation)
            {
                case OperationType.Add:
                    return new AdditionCommand(value);
                case OperationType.Subtract:
                    return new SubtractionCommand(value);
                default:
                    throw new ApplicationException("Some Exception in code");
            }
        }
    }

    public interface CalculationCommand
    { 
        public OperationType OperationType { get; set; }
        public int[] Arguments { get; set; }
        public int GetResult();       
    }

    public class AdditionCommand : CalculationCommand
    {
        public int[] _arguments;     
        public OperationType _operationtype;
        public AdditionCommand()
        {           
        }
        public AdditionCommand(int[] array)
        {
            this._arguments = array;
        }
        public AdditionCommand(int value)
        {
             this.Arguments = new int[] { value } ;
        }

        public OperationType OperationType { get =>  this._operationtype; set => this.OperationType = value; }
        public int[] Arguments { get => this._arguments; set => this._arguments = value; }

        public int GetResult()
        {
            int result = 0;
            foreach (int item in Arguments)
            {
                result += item;
            }
            return result;
        }        
    }

    public class SubtractionCommand : CalculationCommand
    {
        public int[] _arguments;       
        public OperationType _operationtype;

        public SubtractionCommand()
        {
           
        }
        public SubtractionCommand(int[] array)
        {
            this._arguments = array;
        }

        public SubtractionCommand(int value)
        {
            this.Arguments = new int[] { value };
        }

        public OperationType OperationType { get => this._operationtype; set => this.OperationType = value; }
        public int[] Arguments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int GetResult()
        {
            int result = 0;
            foreach (int item in Arguments)
            {
                result -= item;
            }
            return result;
        }
    }

    public class FluentCalculator
    {
        private CalculationCommand command;
        public FluentCalculator ()
        {
            this.command = new AdditionCommand();
            this.command.Arguments = new int[] { };               

        }
        public FluentCalculator Calculate(CalculationCommand cmd)
        {
            this.command = cmd;
            return this;             
        }
        
        public int GetResult()
        {
            return command.GetResult();
        }
    }

}
