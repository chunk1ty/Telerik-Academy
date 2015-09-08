namespace Company.SampleGenerator
{
    internal interface IRandomGenerator
    {
        int GetRandomNumber(int min, int max);

        string GetRandomString(int length);

        string GetRandomStringWithRandomRange(int min, int max);
    }
}
