namespace TestGenerics
{
    public class GenericClass<T, K>
        where T : class
    {
        private T someData;
        private K someOtherData;

        public GenericClass()
        {
        }

        public GenericClass(T data, K otherData)
        {
            this.someData = data;
            this.someOtherData = otherData;
        }
    }
}
