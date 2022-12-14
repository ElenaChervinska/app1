namespace app1
{
    public class Software
    {
        public string Name { get; set; }

        public string Annotation { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }

        public string Author { get; set; }

        public string TermsOfUse { get; set; }

        public Software(string name, string annotation, string type, string version, string authorSurname, string termsOfUse)
        {
            Name = name;
            Annotation = annotation;
            Type = type;
            Version = version;
            Author = authorSurname;
            TermsOfUse = termsOfUse;
        }

        public override string ToString()
        {
            return "Software: \nName: " + Name + ". Annotation: " + Annotation + ". Type: " + Type + "\nVersion: " + Version + ". Author: " + Author + "\nTerms of use: " + TermsOfUse + "\n";
        }
    }
}
