namespace SyntacticSugar.ConstrainingGenerics
{
    // T has to be a reference type (class, interface, delegate, or array type)
    // T can also be any other type parameter that is constrained to be a reference type.
    public class TemplateClassConstrainedByReference<T, T2>
        where T : class
        where T2 : class, T
        //// where T : struct // for value types
    {
    }
}
