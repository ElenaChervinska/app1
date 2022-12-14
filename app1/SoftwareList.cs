using System.Collections.Generic;
using System.IO;
using System;
using Newtonsoft.Json;
using System.Linq;

namespace app1
{
    public class SoftwareList
    {
        public List<Software> Softwares { get; set; }

        private string file = "file.xml";

        public List<Software> FindByName(string name)
        {
            return Softwares.Where(x => x.Name == name).ToList();
        }

        public List<Software> FindByAnnotation(string annotation)
        {
            return Softwares.Where(x => x.Annotation == annotation).ToList();
        }

        public List<Software> FindByAuthor(string author)
        {
            return Softwares.Where(x => x.Author == author).ToList();
        }


        public void AddSoft(Software software)
        {
            foreach (var soft in Softwares)
            {
                if (soft.Name == software.Name)
                {
                    throw new Exception("Програмний застосунок з такою назвою вже було додано");
                }
            }
            Softwares.Add(software);
        }

        public void EditSoft(Software software)
        {
            foreach (var soft in Softwares)
            {
                if (soft.Name == software.Name)
                {
                    soft.Author = software.Author;
                    soft.Version = software.Version;
                    soft.TermsOfUse = software.TermsOfUse;
                    soft.Type = software.Type;
                    soft.Annotation = software.Annotation;
                }
            }
        }

        public void DeleteSoft(string name)
        {
            foreach (var soft in Softwares)
            {
                if (soft.Name == name)
                {
                    Softwares.Remove(soft);
                    return;
                }
            }
        }

        public void LoadFromFile()
        {
            using (var sr = new StreamReader(file))
            {
                Softwares = JsonConvert.DeserializeObject<List<Software>>(sr.ReadToEnd());
            }
        }

        public void LoadToFile()
        {
            using (var sw = new StreamWriter(file))
            {
                sw.Write(JsonConvert.SerializeObject(Softwares));
            }
        }

        public SoftwareList()
        {
            Softwares = new List<Software>();
        }
    }
}
