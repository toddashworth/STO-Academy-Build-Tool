﻿using Emzi0767.Gaming.Sto.StoaLib.Data.Attributes;

namespace Emzi0767.Gaming.Sto.StoaLib.Data.Enums
{
    public enum SkillCareer : int
    {
        [DisplayAs("N/A")]
        Unknown = 0,

        [DisplayAs("Engineering")]
        Engineering = 1,

        [DisplayAs("Science")]
        Science = 2,

        [DisplayAs("Tactical")]
        Tactical = 3
    }
}
