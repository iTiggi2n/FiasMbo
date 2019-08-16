using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "NormativeDocument", IsNullable = true)]
    public class NormativeDocument
    {
        #region proporties
        [XmlAttribute("NORMDOCID")]
        public string NORMDOCID { get; set; }
        [XmlAttribute("DOCNAME")]
        public string DOCNAME { get; set; }
        [XmlAttribute("DOCDATE")]
        public string DOCDATE { get; set; }
        [XmlAttribute("DOCNUM")]
        public string DOCNUM { get; set; }
        [XmlAttribute("DOCTYPE")]
        public string DOCTYPE { get; set; }
        #endregion
    }
}
