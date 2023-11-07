using AutoMapper;
using SchoolAPI.Data.Entities;
using SchoolAPI.Models;

namespace SchoolAPI.Data
{
    public class FinalProfile : Profile
    {
        public FinalProfile()
        {
            this.CreateMap<Final, FinalModel>();
            this.CreateMap<FinalModel, Final>();
        }
    }
}
