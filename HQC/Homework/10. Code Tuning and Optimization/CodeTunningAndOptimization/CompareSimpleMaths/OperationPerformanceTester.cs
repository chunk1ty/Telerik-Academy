namespace CompareSimpleMaths
{
    using System;
using System.Diagnostics;

    public static class OperationPerformanceTester
    {
        private const int INTEGER_VALUE = 1;
        private const int LONG_VALUE = 1;
        private const int FLOAT_VALUE = 1;
        private const int DOUBLE_VALUE = 1;
        private const int DECIMAL_VALUE = 1;

        private const int REPEAT_OPERATION_COUNTER = 1000000;
        private static Stopwatch sw = new Stopwatch();
           
        public static void TestPerformance(Operation operation)
        {
            Console.WriteLine(operation);

            int resultInt = INTEGER_VALUE;
            sw.Start();

            for (int i = 0; i < REPEAT_OPERATION_COUNTER; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultInt += INTEGER_VALUE;
                        break;
                    case Operation.Subtraction:
                        resultInt -= INTEGER_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultInt *= INTEGER_VALUE;
                        break;
                    case Operation.Division:
                        resultInt /= INTEGER_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            sw.Stop();
            Console.WriteLine("{0, -10}{1}","Int", sw.Elapsed);
            sw.Reset();
            
            long resultLong = LONG_VALUE;
            sw.Start();

            for (int i = 0; i < REPEAT_OPERATION_COUNTER; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultLong += LONG_VALUE;
                        break;
                    case Operation.Subtraction:
                        resultLong -= LONG_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultLong *= LONG_VALUE;
                        break;
                    case Operation.Division:
                        resultLong /= LONG_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            sw.Stop();
            Console.WriteLine("{0, -10}{1}", "Long", sw.Elapsed);
            sw.Reset();

            float resultFloat = FLOAT_VALUE;
            sw.Start();

            for (int i = 0; i < REPEAT_OPERATION_COUNTER; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultFloat += FLOAT_VALUE;
                        break;
                    case Operation.Subtraction:
                        resultFloat -= FLOAT_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultFloat *= FLOAT_VALUE;
                        break;
                    case Operation.Division:
                        resultFloat /= FLOAT_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            sw.Stop();
            Console.WriteLine("{0, -10}{1}", "Float", sw.Elapsed);
            sw.Reset();

            double resultDouble = DOUBLE_VALUE;
            sw.Start();

            for (int i = 0; i < REPEAT_OPERATION_COUNTER; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultDouble += DOUBLE_VALUE;
                        break;
                    case Operation.Subtraction:
                        resultDouble -= DOUBLE_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultDouble *= DOUBLE_VALUE;
                        break;
                    case Operation.Division:
                        resultDouble /= DOUBLE_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            sw.Stop();
            Console.WriteLine("{0, -10}{1}", "Double", sw.Elapsed);
            sw.Reset();

            decimal resultDecimal = DECIMAL_VALUE;
            sw.Start();

            for (int i = 0; i < REPEAT_OPERATION_COUNTER; i++)
            {
                switch (operation)
                {
                    case Operation.Addition:
                        resultDecimal += DECIMAL_VALUE;
                        break;
                    case Operation.Subtraction:
                        resultDecimal -= DECIMAL_VALUE;
                        break;
                    case Operation.Multiplication:
                        resultDecimal *= DECIMAL_VALUE;
                        break;
                    case Operation.Division:
                        resultDecimal /= DECIMAL_VALUE;
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            }

            sw.Stop();
            Console.WriteLine("{0, -10}{1}", "Decimal", sw.Elapsed);
            sw.Reset();
            Console.WriteLine("------------------------------------------------");
        }
    }
}
