using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace JsonSerializeSample
{
    [DataContract]
    public class SampleData
    {
        [DataMember(Name = "body")]
        public Body Body { get; set; }
        [DataMember(Name = "header")]
        public Header Header { get; set; }
    }

    [DataContract]
    public class Origin
    {
        [DataMember(Name = "type")]
        public string type { get; set; }
    }

    [DataContract]
    public class Body
    {
        [DataMember(Name = "origin")]
        public Origin Origin { get; set; }

        [DataMember(Name = "commandLine")]
        public string commandLine { get; set; }

        [DataMember(Name = "version")]
        public string version { get; set; }
    }

    [DataContract]
    public class Header
    {
        [DataMember(Name = "requestId")]
        public string requestId { get; set; }

        [DataMember(Name = "messagePurpose")]
        public string messagePurpose { get; set; }

        [DataMember(Name = "version")]
        public string version { get; set; }

        [DataMember(Name = "messageType")]
        public string messageType { get; set; }
    }
}
