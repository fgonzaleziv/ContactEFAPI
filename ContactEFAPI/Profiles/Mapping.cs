using AutoMapper;
using ContactEFAPI.Models;

namespace ContactEFAPI.Profiles
{
    public class Mapping : Profile
    {
        public Mapping()
        {         CreateMap<Department, DepartmentDTO>();}

    }
}
