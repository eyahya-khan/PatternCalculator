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
            Arguments = new int[] {  };
        }
        public AdditionCommand(int[] array)
        {
            Arguments = array;
        }
        public AdditionCommand(int value)
        {
             Arguments = new int[] { value } ;
        }

        public OperationType OperationType { get =>  _operationtype; set => OperationType = value; }
        public int[] Arguments { get => _arguments; set => _arguments=value; }

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
           _arguments = array;
        }

        public SubtractionCommand(int value)
        {
            Arguments = new int[] { value };
        }

        public OperationType OperationType { get => _operationtype; set => OperationType = value; }
        public int[] Arguments { get => _arguments; set => _arguments = value; }

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
        static int result= 0;
        public FluentCalculator ()
        {
            command = new AdditionCommand();
            command.Arguments = new int[] { };               

        }
        public FluentCalculator Calculate(CalculationCommand cmd)
        {
            command = cmd;
            result += command.GetResult();
            return this;
                       
        }
        
        public int GetResult()
        {
            return command.GetResult();
        }

       
    }

}
