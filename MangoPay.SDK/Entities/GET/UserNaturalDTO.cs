﻿using MangoPay.SDK.Core;
using MangoPay.SDK.Core.Enumerations;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace MangoPay.SDK.Entities.GET
{
    /// <summary>UserNatural entity.</summary>
    public sealed class UserNaturalDTO : UserDTO
    {
        /// <summary>First name.</summary>
        public String FirstName { get; set; }

        /// <summary>Last name.</summary>
        public String LastName { get; set; }

        /// <summary>Address.</summary>
		public Address Address { get; set; }

		public String AddressObsolete { get; set; }

        /// <summary>Date of birth (UNIX timestamp).</summary>
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Birthday { get; set; }

        /// <summary>Place of birth.</summary>
        public String Birthplace { get; set; }

        /// <summary>User's country.</summary>
		[JsonConverter(typeof(EnumerationConverter))]
        public CountryIso Nationality { get; set; }

        /// <summary>Country of residence.</summary>
		[JsonConverter(typeof(EnumerationConverter))]
        public CountryIso CountryOfResidence { get; set; }

        /// <summary>User's occupation.</summary>
        public String Occupation { get; set; }

        /// <summary>Income ranges:
        /// 1 (-18K€),
        /// 2 (18-30K€),
        /// 3 (30-50K€),
        /// 4 (50-80K€),
        /// 5 (80-120K€),
        /// 6 (+120K€).</summary>
        public static class IncomeRanges
        {
            public static readonly int Below18 = 1;
            public static readonly int From18To30 = 2;
            public static readonly int From30To50 = 3;
            public static readonly int From50To80 = 4;
            public static readonly int From80To120 = 5;
            public static readonly int Above120 = 6;
        }

        /// <summary>Income range. One of UserNatural.IncomeRanges constants or null, if not specified.</summary>
        public int? IncomeRange { get; set; }

        /// <summary>Proof of identity.</summary>
        public String ProofOfIdentity { get; set; }

        /// <summary>Proof of address.</summary>
        public String ProofOfAddress { get; set; }
    }
}
