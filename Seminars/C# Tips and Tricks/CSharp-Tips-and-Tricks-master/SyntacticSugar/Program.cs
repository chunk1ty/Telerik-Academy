namespace SyntacticSugar
{
    using System;

    using SyntacticSugar.CombinableEnumValues;
    using SyntacticSugar.ConstrainingGenerics;
    using SyntacticSugar.Yield;

    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine(new string('=', 75));
            CombinableEnumValues();
            Console.WriteLine(new string('=', 75));
            CastingVsAsOperator();
            Console.WriteLine(new string('=', 75));
            YieldDemo();
            Console.WriteLine(new string('=', 75));
            ConstrainingGenerics();
            Console.WriteLine(new string('=', 75));
        }

        private static void CombinableEnumValues()
        {
            var bottomRightMargin = Margins.Bottom | Margins.Right;
            var topLeftMargin = Margins.Top | Margins.Left;

            // Getting information
            Console.WriteLine("bottomRightMargin string value: {0}", bottomRightMargin);
            Console.WriteLine("bottomRightMargin integer value: {0}", (int)bottomRightMargin);
            Console.WriteLine("bottomRightMargin == Margins.Bottom: {0}", bottomRightMargin == Margins.Bottom);
            Console.WriteLine(
                "bottomRightMargin has flag Margins.Bottom: {0}",
                bottomRightMargin.HasFlag(Margins.Bottom)); // Equivalent to (bottomRightMargin & Margins.Bottom) != 0

            // Combining combinations
            Console.WriteLine("bottomRightMargin and topLeftMargin: {0}", bottomRightMargin | topLeftMargin);

            // Toggling values
            bottomRightMargin ^= Margins.Bottom;
            Console.WriteLine("bottomRightMargin ^= Margins.Bottom => {0}", bottomRightMargin);
            bottomRightMargin ^= Margins.Bottom;
            Console.WriteLine("bottomRightMargin ^= Margins.Bottom => {0}", bottomRightMargin);
        }

        private static void CastingVsAsOperator()
        {
            object number = "Five";

            Console.WriteLine("The type of 'number' is: {0}", number.GetType());

            if (number is string)
            {
                Console.WriteLine("'number is string' is true");
            }

            //// This will cause an unhandled exception of type 'InvalidCastException' because the specified cast is not valid.
            //// var numberAsInt = (int?)number;

            //// var numberAsInt = number as int?;
            //// This will cause an unhandled exception of type 'InvalidOperationException' because numberAsInt will be null
            //// Console.WriteLine(numberAsInt.Value);
            
            //// When using the 'as' operator we should always consider the possible null value
            //// Console.WriteLine(numberAsInt.GetValueOrDefault(0));
        }

        private static void YieldDemo()
        {
            foreach (var evenNumber in YieldNumbersGenerator.EvenNumbers(50, 60))
            {
                Console.WriteLine("!! Iterated number {0}", evenNumber);
                if (evenNumber > 55)
                {
                    break;
                }
            }
        }

        private static void ConstrainingGenerics()
        {
            // This is allowed (where T : ClassB)
            var templateClassInstance = new TemplateClass<ClassB>();

            // This is also allowed (ClassC is successor of ClassB)
            var templateClassInstance2 = new TemplateClass<ClassC>();

            // This is invalid:
            //// var templateClassInstance3 = new TemplateClass<ClassA>();
            // 'ClassA' cannot be used as type parameter 'T'
            // There is no implicit reference conversion from 'ClassA' to 'ClassB'.

            // These are allowed (where T : IClassable)
            var templateClassConstrainedByInterface =
                new TemplateClassConstrainedByInterface<ClassA>();
            var templateClassConstrainedByInterface2 =
                new TemplateClassConstrainedByInterface<ClassB>();
            var templateClassConstrainedByInterface3 =
                new TemplateClassConstrainedByInterface<StructureA>();

            // This is allowed (where T : class)
            var templateClassConstrainedByReference =
                new TemplateClassConstrainedByReference<ClassA, ClassB>();

            // This is invalid
            //// var templateClassConstrainedByReference2 =
            ////     new TemplateClassConstrainedByReference<ClassB, ClassA>();
            // 'ClassA' cannot be used as type parameter 'T2' in the generic type or method 'TemplateClassConstrainedByReference<T,T2>'.
            // There is no implicit reference conversion from 'ClassA' to 'ClassB'.

            // This is also invalid
            //// var templateClassConstrainedByReference3 =
            ////     new TemplateClassConstrainedByReference<StructureA, StructureA>();
            // 'StructureA' must be a reference type in order to use it as parameter 'T'
            // in the generic type or method 'TemplateClassConstrainedByReference<T,T2>'

            // This is allowed (where T : new())
            var templateClassConstrainedByEmptyConstructor =
                new TemplateClassConstrainedByEmptyConstructor<ClassA>();

            // This is invalid
            //// var templateClassConstrainedByEmptyConstructor2 =
            ////     new TemplateClassConstrainedByEmptyConstructor<ClassC>();
            // 'ClassC' must be a non-abstract type with a public parameterless constructor
            // in order to use it as parameter 'T' in the generic type or method 'TemplateClassConstrainedByEmptyConstructor<T>'
        }
    }
}
