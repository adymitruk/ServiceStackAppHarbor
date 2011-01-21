namespace ServiceStackAppHarbor.ServiceModel
{
    using System.Runtime.Serialization;

    [DataContract(Namespace = "http://schemas.servicestack.net/types")]
    public class GetFactorial
    {
        [DataMember]
        public long ForNumber { get; set; }
    }
}