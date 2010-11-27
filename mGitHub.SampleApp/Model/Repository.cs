using System.Runtime.Serialization;

namespace mGitHub.SampleApp.Model
{
    [DataContract]
    public class Repository
    {
        [DataMember(Name = "url")]
        public string URL { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "homepage")]
        public string Homepage { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "owner")]
        public string Owner { get; set; }

        [DataMember(Name = "fork")]
        public bool Fork { get; set; }

        [DataMember(Name = "private")]
        public bool Private { get; set; }

        [DataMember(Name = "open_issues")]
        public int OpenIssues { get; set; }

        [DataMember(Name = "watchers")]
        public int Watchers { get; set; }

        [DataMember(Name = "forks")]
        public int Forks { get; set; }
    }
}
