internal class NonPublicWithNested
{
    public class PublicNestedClass
    {
        public string MethodReturnsNull()
        {
            // This is an example of a false positive of the "every public method will be rewritten" rule (see 
            // IsPublicOrExplicitInterfaceImplementation) (although NonPublic is missing):
            return null;
        }
    }
}