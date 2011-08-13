using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using PuttyManager.Business;

namespace PuttyManager.Domain
{
    [Serializable]
    [XmlRoot("Settings")]
    public class EncryptedStorageContent
    {
        public EncryptedStorageContent()
        {
            Hosts = new List<HostInfo>();
        }

        // Topological sorted hosts information. Less index => less dependencies.
        public List<HostInfo> Hosts { get; set; }
    }
}