using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASNET Core 1", "Descrição 1", 1, 1, 10000),
                new Project("Meu projeto ASNET Core 2", "Descrição 2", 1, 1, 20000),
                new Project("Meu projeto ASNET Core 3", "Descrição 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Donizete", "don@teste.com", new DateTime(1999, 04, 12)),
                new User("Gomes", "gomes@teste.com", new DateTime(1998, 05, 13)),
                new User("Junior", "junior@teste.com", new DateTime(1997, 06, 14)),
            };

            Skills = new List<Skill>
            {
                new Skill("Azure"),
                new Skill("C#"),
                new Skill("AWS")
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
