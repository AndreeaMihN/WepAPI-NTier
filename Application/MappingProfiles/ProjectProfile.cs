using A2Mac1.Costino.Application.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Mac1.Costino.Application.MappingProfiles
{
    public class ProjectProfile: Profile
    {
        public ProjectProfile()
        {
            CreateMap<ProjectModel, Project>();
            CreateMap<Project, ProjectModel>();
        }
    }
}
