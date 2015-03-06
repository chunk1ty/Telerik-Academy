namespace GenericListNamespace
{
    using System;
    class TestGeneric
    {
        static void Main()
        {
            GenericList<int> genericInt = new GenericList<int>();
            genericInt.AddElement(11);
            genericInt.AddElement(22);
            genericInt.AddElement(33);
            genericInt.AddElement(44);
            genericInt.AddElement(55);
            genericInt.AddElement(66);
            genericInt.AddElement(66);
            genericInt.AddElement(66);            
            genericInt.InsertAt(6, 17);
            //genericInt.RemoveElementAt(1);
            //Console.WriteLine(genericInt[1]);
            //genericInt.Clear();
            //int index = genericInt.FindElement(0);
            //Console.WriteLine(genericInt.ToString());
            Console.WriteLine(genericInt.Max<int>());
            
        }
    }
}
