namespace ServiceStackAppHarbor.ServiceModel
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://schemas.servicestack.net/types")]
    public class GetFactorialResponse
    {
        [DataMember]
        public long Result { get; set; }
    }
}
