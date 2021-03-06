﻿using Emzi0767.Gaming.Sto.StoaLib.Data.Attributes;

namespace Emzi0767.Gaming.Sto.StoaLib.Data.Enums
{
    public enum TraitCareer : int
    {
        [DisplayAs("N/A")]
        Unknown = 0,

        [DisplayAs("Engineering")]
        Engineering = 1,

        [DisplayAs("Science")]
        Science = 2,

        [DisplayAs("Tactical")]
        Tactical = 3,

        [DisplayAs("Universal")]
        Universal = 4
    }
}
