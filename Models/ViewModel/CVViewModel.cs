using System.Security.Cryptography.Xml;

namespace CVApp.Models.ViewModel
{
    public class CVViewModel
    {
        public Profile Profile { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Project> Projects { get; set; }
        public Education Education { get; set; }
        public List<Leadership> LeadershipRoles { get; set; }
        public List<Reference> References { get; set; }
    }
}