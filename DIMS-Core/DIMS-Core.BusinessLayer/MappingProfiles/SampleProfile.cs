﻿using AutoMapper;
using DIMS_Core.BusinessLayer.Models.Samples;
using DIMS_Core.DataAccessLayer.Models;

namespace DIMS_Core.BusinessLayer.MappingProfiles
{
    internal class SampleProfile : Profile
    {
        public SampleProfile()
        {
            CreateMap<SampleRequestDto, Sample>();
            CreateMap<Sample, SampleResponseDto>();
        }
    }
}