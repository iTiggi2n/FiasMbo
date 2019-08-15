
namespace FiasOffSite.FI
{
    internal struct QualifiedName
    {
        internal void Init(string prefix, string ns, string localName)
        {
            Prefix = prefix;
            Ns = ns;
            LocalName = localName;
        }

        internal string Prefix;
        internal string Ns;
        internal string LocalName;
    }
}
