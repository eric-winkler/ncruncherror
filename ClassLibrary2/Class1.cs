using ClassLibrary1;

namespace ClassLibrary2
{
    public class Function1
    {
        public void Foo()
        {
            var instance = new FirstInitPropertyClass
            {
                FirstProperty = 1
            };
        }

        private static void SomeUncalledStaticMethod()
        {
            var thing = new SecondInitPropertyClass()
            {
                SecondProperty = 2
            };
        }
    }

    public class FirstInitPropertyClass
    {
        public int FirstProperty { get; init; }
    }
}