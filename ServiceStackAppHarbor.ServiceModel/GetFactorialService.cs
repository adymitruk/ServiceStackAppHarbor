namespace ServiceStackAppHarbor.ServiceModel
{
    using ServiceStack.ServiceHost;

    public class GetFactorialService : IService<GetFactorial>
    {
        public object Execute(GetFactorial request)
        {
            return new GetFactorialResponse { Result = GetFactorial(request.ForNumber) };
        }

        static long GetFactorial(long n)
        {
            return n > 1 ? n * GetFactorial(n - 1) : 1;
        }
    }
}