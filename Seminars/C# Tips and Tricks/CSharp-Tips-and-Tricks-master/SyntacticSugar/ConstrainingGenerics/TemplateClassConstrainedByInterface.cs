namespace SyntacticSugar.ConstrainingGenerics
{
    public class TemplateClassConstrainedByInterface<T>
            where T : IHaveInterface
    {
    }
}
