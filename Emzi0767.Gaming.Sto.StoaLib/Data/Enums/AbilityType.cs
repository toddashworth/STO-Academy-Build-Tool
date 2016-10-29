﻿using Emzi0767.Gaming.Sto.StoaLib.Data.Attributes;

namespace Emzi0767.Gaming.Sto.StoaLib.Data.Enums
{
    public enum AbilityType : int
    {
        [DisplayAs("N/A")]
        Unknown = 0,

        [DisplayAs("Captain Ability")]
        Captain = 1,

        [DisplayAs("Bridge Officer Ability")]
        BOFF = 2
    }
}
