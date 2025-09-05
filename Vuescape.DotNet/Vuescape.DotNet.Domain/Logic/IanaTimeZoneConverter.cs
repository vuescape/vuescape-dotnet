// <copyright file="IanaTimeZoneConverter.cs" company="Vuescape">
//    Copyright (c) Vuescape 2021. All rights reserved.
// </copyright>

// ReSharper disable once CheckNamespace
namespace Vuescape.DotNet.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using OBeautifulCode.CodeAnalysis.Recipes;
    using OBeautifulCode.Type;

    /// <summary>
    /// Utility class for converting IANA timezone identifiers to StandardTimeZone enum values.
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
    public static class IanaTimeZoneConverter
    {
        private static readonly Dictionary<string, StandardTimeZone> IanaToStandardTimeZoneMapping =
            new Dictionary<string, StandardTimeZone>(StringComparer.OrdinalIgnoreCase)
            {
                // UTC-12:00 - International Date Line West
                { "Etc/GMT+12", StandardTimeZone.Dateline },

                // UTC-11:00 - Coordinated Universal Time-11
                { "Pacific/Midway", StandardTimeZone.Samoa },
                { "Pacific/Pago_Pago", StandardTimeZone.Samoa },

                // UTC-10:00 - Aleutian Islands
                { "America/Adak", StandardTimeZone.Aleutian },

                // UTC-10:00 - Hawaii
                { "Pacific/Honolulu", StandardTimeZone.Hawaiian },
                { "Pacific/Johnston", StandardTimeZone.Hawaiian },
                { "Etc/GMT+10", StandardTimeZone.Hawaiian },

                // UTC-09:30 - Marquesas Islands
                { "Pacific/Marquesas", StandardTimeZone.Marquesas },

                // UTC-09:00 - Alaska
                { "America/Anchorage", StandardTimeZone.Alaskan },
                { "America/Juneau", StandardTimeZone.Alaskan },
                { "America/Metlakatla", StandardTimeZone.Alaskan },
                { "America/Nome", StandardTimeZone.Alaskan },
                { "America/Sitka", StandardTimeZone.Alaskan },
                { "America/Yakutat", StandardTimeZone.Alaskan },

                // UTC-08:00 - Baja California
                { "America/Tijuana", StandardTimeZone.PacificMexico },

                // UTC-08:00 - Pacific Time (US & Canada)
                { "America/Los_Angeles", StandardTimeZone.Pacific },
                { "America/Vancouver", StandardTimeZone.Pacific },
                { "Etc/GMT+8", StandardTimeZone.Pacific },

                // UTC-07:00 - Arizona
                { "America/Phoenix", StandardTimeZone.UnitedStatesMountain },

                // UTC-07:00 - Chihuahua, La Paz, Mazatlan
                { "America/Chihuahua", StandardTimeZone.MountainMexico },
                { "America/Mazatlan", StandardTimeZone.MountainMexico },

                // UTC-07:00 - Mountain Time (US & Canada)
                { "America/Denver", StandardTimeZone.Mountain },
                { "America/Edmonton", StandardTimeZone.Mountain },
                { "America/Boise", StandardTimeZone.Mountain },

                // UTC-07:00 - Yukon
                { "America/Whitehorse", StandardTimeZone.Yukon },
                { "America/Dawson", StandardTimeZone.Yukon },

                // UTC-06:00 - Central America
                { "America/Belize", StandardTimeZone.CentralAmerica },
                { "America/Costa_Rica", StandardTimeZone.CentralAmerica },
                { "America/El_Salvador", StandardTimeZone.CentralAmerica },
                { "America/Guatemala", StandardTimeZone.CentralAmerica },
                { "America/Managua", StandardTimeZone.CentralAmerica },
                { "America/Tegucigalpa", StandardTimeZone.CentralAmerica },

                // UTC-06:00 - Central Time (US & Canada)
                { "America/Chicago", StandardTimeZone.Central },
                { "America/Winnipeg", StandardTimeZone.Central },
                { "America/Detroit", StandardTimeZone.Central }, // Some areas
                { "America/Indiana/Knox", StandardTimeZone.Central },
                { "America/Indiana/Tell_City", StandardTimeZone.Central },
                { "America/Kentucky/Louisville", StandardTimeZone.Central },
                { "America/Kentucky/Monticello", StandardTimeZone.Central },
                { "America/Menominee", StandardTimeZone.Central },
                { "America/North_Dakota/Beulah", StandardTimeZone.Central },
                { "America/North_Dakota/Center", StandardTimeZone.Central },
                { "America/North_Dakota/New_Salem", StandardTimeZone.Central },

                // UTC-06:00 - Easter Island
                { "Pacific/Easter", StandardTimeZone.EasterIsland },

                // UTC-06:00 - Guadalajara, Mexico City, Monterrey
                { "America/Mexico_City", StandardTimeZone.CentralMexico },
                { "America/Monterrey", StandardTimeZone.CentralMexico },

                // UTC-06:00 - Saskatchewan
                { "America/Regina", StandardTimeZone.CanadaCentral },
                { "America/Swift_Current", StandardTimeZone.CanadaCentral },

                // UTC-05:00 - Bogota, Lima, Quito, Rio Branco
                { "America/Bogota", StandardTimeZone.SouthAmericaPacific },
                { "America/Lima", StandardTimeZone.SouthAmericaPacific },
                { "America/Quito", StandardTimeZone.SouthAmericaPacific },
                { "America/Rio_Branco", StandardTimeZone.SouthAmericaPacific },
                { "America/Eirunepe", StandardTimeZone.SouthAmericaPacific },

                // UTC-05:00 - Chetumal
                { "America/Cancun", StandardTimeZone.EasternMexico },

                // UTC-05:00 - Eastern Time (US & Canada)
                { "America/New_York", StandardTimeZone.Eastern },
                { "America/Toronto", StandardTimeZone.Eastern },
                { "America/Montreal", StandardTimeZone.Eastern },
                { "America/Nassau", StandardTimeZone.Eastern },
                { "America/Nipigon", StandardTimeZone.Eastern },
                { "America/Pangnirtung", StandardTimeZone.Eastern },
                { "America/Thunder_Bay", StandardTimeZone.Eastern },
                { "America/Iqaluit", StandardTimeZone.Eastern },

                // UTC-05:00 - Haiti
                { "America/Port-au-Prince", StandardTimeZone.Haiti },

                // UTC-05:00 - Havana
                { "America/Havana", StandardTimeZone.Cuba },

                // UTC-05:00 - Indiana (East)
                { "America/Indiana/Indianapolis", StandardTimeZone.UnitedStatesEastern },
                { "America/Indiana/Marengo", StandardTimeZone.UnitedStatesEastern },
                { "America/Indiana/Petersburg", StandardTimeZone.UnitedStatesEastern },
                { "America/Indiana/Vevay", StandardTimeZone.UnitedStatesEastern },
                { "America/Indiana/Vincennes", StandardTimeZone.UnitedStatesEastern },
                { "America/Indiana/Winamac", StandardTimeZone.UnitedStatesEastern },

                // UTC-05:00 - Turks and Caicos
                { "America/Grand_Turk", StandardTimeZone.TurksAndCaicos },

                // UTC-04:00 - Asuncion
                { "America/Asuncion", StandardTimeZone.Paraguay },

                // UTC-04:00 - Atlantic Time (Canada)
                { "America/Halifax", StandardTimeZone.Atlantic },
                { "America/Glace_Bay", StandardTimeZone.Atlantic },
                { "America/Goose_Bay", StandardTimeZone.Atlantic },
                { "America/Moncton", StandardTimeZone.Atlantic },
                { "America/Thule", StandardTimeZone.Atlantic },
                { "Atlantic/Bermuda", StandardTimeZone.Atlantic },

                // UTC-04:00 - Caracas
                { "America/Caracas", StandardTimeZone.Venezuela },

                // UTC-04:00 - Cuiaba
                { "America/Cuiaba", StandardTimeZone.CentralBrazilian },
                { "America/Campo_Grande", StandardTimeZone.CentralBrazilian },

                // UTC-04:00 - Georgetown, La Paz, Manaus, San Juan
                { "America/Georgetown", StandardTimeZone.SouthAmericaWestern },
                { "America/La_Paz", StandardTimeZone.SouthAmericaWestern },
                { "America/Manaus", StandardTimeZone.SouthAmericaWestern },
                { "America/Puerto_Rico", StandardTimeZone.SouthAmericaWestern },
                { "America/Boa_Vista", StandardTimeZone.SouthAmericaWestern },
                { "America/Porto_Velho", StandardTimeZone.SouthAmericaWestern },

                // UTC-04:00 - Santiago
                { "America/Santiago", StandardTimeZone.PacificSouthAmerica },

                // UTC-03:30 - Newfoundland
                { "America/St_Johns", StandardTimeZone.Newfoundland },

                // UTC-03:00 - Araguaina
                { "America/Araguaina", StandardTimeZone.Tocantins },

                // UTC-03:00 - Brasilia
                { "America/Sao_Paulo", StandardTimeZone.EasternSouthAmerica },
                { "America/Bahia", StandardTimeZone.Bahia },

                // UTC-03:00 - Cayenne, Fortaleza
                { "America/Cayenne", StandardTimeZone.SouthAmericaEastern },
                { "America/Fortaleza", StandardTimeZone.SouthAmericaEastern },
                { "America/Belem", StandardTimeZone.SouthAmericaEastern },
                { "America/Maceio", StandardTimeZone.SouthAmericaEastern },
                { "America/Recife", StandardTimeZone.SouthAmericaEastern },
                { "America/Santarem", StandardTimeZone.SouthAmericaEastern },

                // UTC-03:00 - City of Buenos Aires
                { "America/Argentina/Buenos_Aires", StandardTimeZone.Argentina },
                { "America/Argentina/Catamarca", StandardTimeZone.Argentina },
                { "America/Argentina/Cordoba", StandardTimeZone.Argentina },
                { "America/Argentina/Jujuy", StandardTimeZone.Argentina },
                { "America/Argentina/La_Rioja", StandardTimeZone.Argentina },
                { "America/Argentina/Mendoza", StandardTimeZone.Argentina },
                { "America/Argentina/Rio_Gallegos", StandardTimeZone.Argentina },
                { "America/Argentina/Salta", StandardTimeZone.Argentina },
                { "America/Argentina/San_Juan", StandardTimeZone.Argentina },
                { "America/Argentina/San_Luis", StandardTimeZone.Argentina },
                { "America/Argentina/Tucuman", StandardTimeZone.Argentina },
                { "America/Argentina/Ushuaia", StandardTimeZone.Argentina },

                // UTC-03:00 - Greenland
                { "America/Nuuk", StandardTimeZone.Greenland }, // New name for Godthab
                { "America/Godthab", StandardTimeZone.Greenland }, // Old name

                // UTC-03:00 - Montevideo
                { "America/Montevideo", StandardTimeZone.Montevideo },

                // UTC-03:00 - Punta Arenas
                { "America/Punta_Arenas", StandardTimeZone.Magallanes },

                // UTC-03:00 - Saint Pierre and Miquelon
                { "America/Miquelon", StandardTimeZone.SaintPierre },

                // UTC-03:00 - Salvador
                { "America/Salvador", StandardTimeZone.Bahia },

                // UTC-02:00 - Mid-Atlantic
                { "Etc/GMT+2", StandardTimeZone.MidAtlantic },

                // UTC-01:00 - Azores
                { "Atlantic/Azores", StandardTimeZone.Azores },

                // UTC-01:00 - Cabo Verde Is.
                { "Atlantic/Cape_Verde", StandardTimeZone.CapeVerde },

                // UTC+00:00 - Dublin, Edinburgh, Lisbon, London
                { "Europe/Dublin", StandardTimeZone.Gmt },
                { "Europe/London", StandardTimeZone.Gmt },
                { "Europe/Lisbon", StandardTimeZone.Gmt },
                { "Atlantic/Canary", StandardTimeZone.Gmt },
                { "Atlantic/Faroe", StandardTimeZone.Gmt },
                { "Atlantic/Madeira", StandardTimeZone.Gmt },

                // UTC+00:00 - Monrovia, Reykjavik
                { "Africa/Monrovia", StandardTimeZone.Greenwich },
                { "Atlantic/Reykjavik", StandardTimeZone.Greenwich },
                { "Africa/Abidjan", StandardTimeZone.Greenwich },
                { "Africa/Accra", StandardTimeZone.Greenwich },
                { "Africa/Bamako", StandardTimeZone.Greenwich },
                { "Africa/Banjul", StandardTimeZone.Greenwich },
                { "Africa/Bissau", StandardTimeZone.Greenwich },
                { "Africa/Conakry", StandardTimeZone.Greenwich },
                { "Africa/Dakar", StandardTimeZone.Greenwich },
                { "Africa/Freetown", StandardTimeZone.Greenwich },
                { "Africa/Lome", StandardTimeZone.Greenwich },
                { "Africa/Nouakchott", StandardTimeZone.Greenwich },
                { "Africa/Ouagadougou", StandardTimeZone.Greenwich },

                // UTC+00:00 - Sao Tome
                { "Africa/Sao_Tome", StandardTimeZone.SaoTome },

                // UTC+01:00 - Casablanca
                { "Africa/Casablanca", StandardTimeZone.Morocco },
                { "Africa/El_Aaiun", StandardTimeZone.Morocco },

                // UTC+01:00 - Amsterdam, Berlin, Bern, Rome, Stockholm, Vienna
                { "Europe/Amsterdam", StandardTimeZone.WesternEurope },
                { "Europe/Berlin", StandardTimeZone.WesternEurope },
                { "Europe/Rome", StandardTimeZone.WesternEurope },
                { "Europe/Stockholm", StandardTimeZone.WesternEurope },
                { "Europe/Vienna", StandardTimeZone.WesternEurope },
                { "Europe/Zurich", StandardTimeZone.WesternEurope },
                { "Europe/Gibraltar", StandardTimeZone.WesternEurope },
                { "Europe/Malta", StandardTimeZone.WesternEurope },
                { "Europe/Monaco", StandardTimeZone.WesternEurope },
                { "Europe/Oslo", StandardTimeZone.WesternEurope },
                { "Europe/San_Marino", StandardTimeZone.WesternEurope },
                { "Europe/Vatican", StandardTimeZone.WesternEurope },
                { "Arctic/Longyearbyen", StandardTimeZone.WesternEurope },

                // UTC+01:00 - Belgrade, Bratislava, Budapest, Ljubljana, Prague
                { "Europe/Belgrade", StandardTimeZone.CentralEurope },
                { "Europe/Bratislava", StandardTimeZone.CentralEurope },
                { "Europe/Budapest", StandardTimeZone.CentralEurope },
                { "Europe/Ljubljana", StandardTimeZone.CentralEurope },
                { "Europe/Prague", StandardTimeZone.CentralEurope },
                { "Europe/Podgorica", StandardTimeZone.CentralEurope },
                { "Europe/Tirane", StandardTimeZone.CentralEurope },

                // UTC+01:00 - Brussels, Copenhagen, Madrid, Paris
                { "Europe/Brussels", StandardTimeZone.Romance },
                { "Europe/Copenhagen", StandardTimeZone.Romance },
                { "Europe/Madrid", StandardTimeZone.Romance },
                { "Europe/Paris", StandardTimeZone.Romance },
                { "Europe/Andorra", StandardTimeZone.Romance },
                { "Europe/Luxembourg", StandardTimeZone.Romance },

                // UTC+01:00 - Sarajevo, Skopje, Warsaw, Zagreb
                { "Europe/Sarajevo", StandardTimeZone.CentralEuropean },
                { "Europe/Skopje", StandardTimeZone.CentralEuropean },
                { "Europe/Warsaw", StandardTimeZone.CentralEuropean },
                { "Europe/Zagreb", StandardTimeZone.CentralEuropean },

                // UTC+01:00 - West Central Africa
                { "Africa/Lagos", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Douala", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Bangui", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Brazzaville", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Kinshasa", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Luanda", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Malabo", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Ndjamena", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Niamey", StandardTimeZone.WesternCentralAfrica },
                { "Africa/Porto-Novo", StandardTimeZone.WesternCentralAfrica },

                // UTC+02:00 - Amman
                { "Asia/Amman", StandardTimeZone.Jordan },

                // UTC+02:00 - Athens, Bucharest
                { "Europe/Athens", StandardTimeZone.Gtb },
                { "Europe/Bucharest", StandardTimeZone.Gtb },

                // UTC+02:00 - Beirut
                { "Asia/Beirut", StandardTimeZone.MiddleEast },

                // UTC+02:00 - Cairo
                { "Africa/Cairo", StandardTimeZone.Egypt },

                // UTC+02:00 - Chisinau
                { "Europe/Chisinau", StandardTimeZone.EasternEurope },

                // UTC+02:00 - Damascus
                { "Asia/Damascus", StandardTimeZone.Syria },

                // UTC+02:00 - Gaza, Hebron
                { "Asia/Gaza", StandardTimeZone.WestBank },
                { "Asia/Hebron", StandardTimeZone.WestBank },

                // UTC+02:00 - Harare, Pretoria
                { "Africa/Harare", StandardTimeZone.SouthAfrica },
                { "Africa/Johannesburg", StandardTimeZone.SouthAfrica },
                { "Africa/Maseru", StandardTimeZone.SouthAfrica },
                { "Africa/Mbabane", StandardTimeZone.SouthAfrica },

                // UTC+02:00 - Helsinki, Kyiv, Riga, Sofia, Tallinn, Vilnius
                { "Europe/Helsinki", StandardTimeZone.Fle },
                { "Europe/Kiev", StandardTimeZone.Fle }, // Old name
                { "Europe/Kyiv", StandardTimeZone.Fle }, // New name
                { "Europe/Riga", StandardTimeZone.Fle },
                { "Europe/Sofia", StandardTimeZone.Fle },
                { "Europe/Tallinn", StandardTimeZone.Fle },
                { "Europe/Vilnius", StandardTimeZone.Fle },
                { "Europe/Mariehamn", StandardTimeZone.Fle },

                // UTC+02:00 - Jerusalem
                { "Asia/Jerusalem", StandardTimeZone.Israel },

                // UTC+02:00 - Juba
                { "Africa/Juba", StandardTimeZone.SouthSudan },

                // UTC+02:00 - Kaliningrad
                { "Europe/Kaliningrad", StandardTimeZone.Kaliningrad },

                // UTC+02:00 - Khartoum
                { "Africa/Khartoum", StandardTimeZone.Sudan },

                // UTC+02:00 - Tripoli
                { "Africa/Tripoli", StandardTimeZone.Libya },

                // UTC+02:00 - Windhoek
                { "Africa/Windhoek", StandardTimeZone.Namibia },

                // UTC+03:00 - Baghdad
                { "Asia/Baghdad", StandardTimeZone.Arabic },

                // UTC+03:00 - Istanbul
                { "Europe/Istanbul", StandardTimeZone.Turkey },

                // UTC+03:00 - Kuwait, Riyadh
                { "Asia/Kuwait", StandardTimeZone.Arab },
                { "Asia/Riyadh", StandardTimeZone.Arab },
                { "Asia/Bahrain", StandardTimeZone.Arab },
                { "Asia/Qatar", StandardTimeZone.Arab },
                { "Asia/Aden", StandardTimeZone.Arab },

                // UTC+03:00 - Minsk
                { "Europe/Minsk", StandardTimeZone.Belarus },

                // UTC+03:00 - Moscow, St. Petersburg
                { "Europe/Moscow", StandardTimeZone.Russian },
                { "Europe/Simferopol", StandardTimeZone.Russian },

                // UTC+03:00 - Nairobi
                { "Africa/Nairobi", StandardTimeZone.EasternAfrica },
                { "Africa/Addis_Ababa", StandardTimeZone.EasternAfrica },
                { "Africa/Asmera", StandardTimeZone.EasternAfrica },
                { "Africa/Dar_es_Salaam", StandardTimeZone.EasternAfrica },
                { "Africa/Djibouti", StandardTimeZone.EasternAfrica },
                { "Africa/Kampala", StandardTimeZone.EasternAfrica },
                { "Africa/Mogadishu", StandardTimeZone.EasternAfrica },
                { "Indian/Antananarivo", StandardTimeZone.EasternAfrica },
                { "Indian/Comoro", StandardTimeZone.EasternAfrica },
                { "Indian/Mayotte", StandardTimeZone.EasternAfrica },

                // UTC+03:00 - Volgograd
                { "Europe/Volgograd", StandardTimeZone.Volgograd },

                // UTC+03:30 - Tehran
                { "Asia/Tehran", StandardTimeZone.Iran },

                // UTC+04:00 - Abu Dhabi, Muscat
                { "Asia/Dubai", StandardTimeZone.Arabian },
                { "Asia/Muscat", StandardTimeZone.Arabian },

                // UTC+04:00 - Astrakhan, Ulyanovsk
                { "Europe/Astrakhan", StandardTimeZone.Astrakhan },
                { "Europe/Ulyanovsk", StandardTimeZone.Astrakhan },

                // UTC+04:00 - Baku
                { "Asia/Baku", StandardTimeZone.Azerbaijan },

                // UTC+04:00 - Port Louis
                { "Indian/Mauritius", StandardTimeZone.Mauritius },
                { "Indian/Reunion", StandardTimeZone.Mauritius },
                { "Indian/Mahe", StandardTimeZone.Mauritius },

                // UTC+04:00 - Saratov
                { "Europe/Saratov", StandardTimeZone.Saratov },

                // UTC+04:00 - Tbilisi
                { "Asia/Tbilisi", StandardTimeZone.Georgian },

                // UTC+04:00 - Yerevan
                { "Asia/Yerevan", StandardTimeZone.Caucasus },

                // UTC+04:30 - Kabul
                { "Asia/Kabul", StandardTimeZone.Afghanistan },

                // UTC+05:00 - Ashgabat, Tashkent
                { "Asia/Ashgabat", StandardTimeZone.WestAsia },
                { "Asia/Tashkent", StandardTimeZone.WestAsia },
                { "Asia/Dushanbe", StandardTimeZone.WestAsia },
                { "Asia/Samarkand", StandardTimeZone.WestAsia },

                // UTC+05:00 - Ekaterinburg
                { "Asia/Yekaterinburg", StandardTimeZone.Ekaterinburg },

                // UTC+05:00 - Islamabad, Karachi
                { "Asia/Karachi", StandardTimeZone.Pakistan },

                // UTC+05:00 - Qyzylorda
                { "Asia/Qyzylorda", StandardTimeZone.Qyzylorda },
                { "Asia/Aqtobe", StandardTimeZone.Qyzylorda },
                { "Asia/Aqtau", StandardTimeZone.Qyzylorda },
                { "Asia/Oral", StandardTimeZone.Qyzylorda },

                // UTC+05:30 - Chennai, Kolkata, Mumbai, New Delhi
                { "Asia/Kolkata", StandardTimeZone.India },

                // UTC+05:30 - Sri Jayawardenepura
                { "Asia/Colombo", StandardTimeZone.SriLanka },

                // UTC+05:45 - Kathmandu
                { "Asia/Kathmandu", StandardTimeZone.Nepal },

                // UTC+06:00 - Astana
                { "Asia/Almaty", StandardTimeZone.CentralAsia },
                { "Asia/Bishkek", StandardTimeZone.CentralAsia },

                // UTC+06:00 - Dhaka
                { "Asia/Dhaka", StandardTimeZone.Bangladesh },
                { "Asia/Thimphu", StandardTimeZone.Bangladesh },

                // UTC+06:00 - Omsk
                { "Asia/Omsk", StandardTimeZone.Omsk },

                // UTC+06:30 - Yangon (Rangoon)
                { "Asia/Rangoon", StandardTimeZone.Myanmar },
                { "Asia/Yangon", StandardTimeZone.Myanmar },
                { "Indian/Cocos", StandardTimeZone.Myanmar },

                // UTC+07:00 - Bangkok, Hanoi, Jakarta
                { "Asia/Bangkok", StandardTimeZone.SoutheastAsia },
                { "Asia/Ho_Chi_Minh", StandardTimeZone.SoutheastAsia },
                { "Asia/Jakarta", StandardTimeZone.SoutheastAsia },
                { "Asia/Phnom_Penh", StandardTimeZone.SoutheastAsia },
                { "Asia/Vientiane", StandardTimeZone.SoutheastAsia },

                // UTC+07:00 - Barnaul, Gorno-Altaysk
                { "Asia/Barnaul", StandardTimeZone.Altai },

                // UTC+07:00 - Hovd
                { "Asia/Hovd", StandardTimeZone.WesternMongolia },

                // UTC+07:00 - Krasnoyarsk
                { "Asia/Krasnoyarsk", StandardTimeZone.NorthAsia },

                // UTC+07:00 - Novosibirsk
                { "Asia/Novosibirsk", StandardTimeZone.NorthernCentralAsia },

                // UTC+07:00 - Tomsk
                { "Asia/Tomsk", StandardTimeZone.Tomsk },

                // UTC+08:00 - Beijing, Chongqing, Hong Kong, Urumqi
                { "Asia/Shanghai", StandardTimeZone.China },
                { "Asia/Hong_Kong", StandardTimeZone.China },
                { "Asia/Urumqi", StandardTimeZone.China },
                { "Asia/Macau", StandardTimeZone.China },

                // UTC+08:00 - Irkutsk
                { "Asia/Irkutsk", StandardTimeZone.NorthAsiaEast },

                // UTC+08:00 - Kuala Lumpur, Singapore
                { "Asia/Kuala_Lumpur", StandardTimeZone.Singapore },
                { "Asia/Singapore", StandardTimeZone.Singapore },
                { "Asia/Brunei", StandardTimeZone.Singapore },
                { "Asia/Kuching", StandardTimeZone.Singapore },

                // UTC+08:00 - Perth
                { "Australia/Perth", StandardTimeZone.WesternAustralia },

                // UTC+08:00 - Taipei
                { "Asia/Taipei", StandardTimeZone.Taipei },

                // UTC+08:00 - Ulaanbaatar
                { "Asia/Ulaanbaatar", StandardTimeZone.Ulaanbaatar },
                { "Asia/Choibalsan", StandardTimeZone.Ulaanbaatar },

                // UTC+08:45 - Eucla
                { "Australia/Eucla", StandardTimeZone.AustraliaCentralWestern },

                // UTC+09:00 - Chita
                { "Asia/Chita", StandardTimeZone.Transbaikal },

                // UTC+09:00 - Osaka, Sapporo, Tokyo
                { "Asia/Tokyo", StandardTimeZone.Tokyo },

                // UTC+09:00 - Pyongyang
                { "Asia/Pyongyang", StandardTimeZone.NorthKorea },

                // UTC+09:00 - Seoul
                { "Asia/Seoul", StandardTimeZone.Korea },

                // UTC+09:00 - Yakutsk
                { "Asia/Yakutsk", StandardTimeZone.Yakutsk },
                { "Asia/Khandyga", StandardTimeZone.Yakutsk },

                // UTC+09:30 - Adelaide
                { "Australia/Adelaide", StandardTimeZone.CentralAustralia },
                { "Australia/Broken_Hill", StandardTimeZone.CentralAustralia },

                // UTC+09:30 - Darwin
                { "Australia/Darwin", StandardTimeZone.AustraliaCentral },

                // UTC+10:00 - Brisbane
                { "Australia/Brisbane", StandardTimeZone.EasternAustralia },
                { "Australia/Lindeman", StandardTimeZone.EasternAustralia },

                // UTC+10:00 - Canberra, Melbourne, Sydney
                { "Australia/Sydney", StandardTimeZone.AustraliaEastern },
                { "Australia/Melbourne", StandardTimeZone.AustraliaEastern },

                // UTC+10:00 - Guam, Port Moresby
                { "Pacific/Guam", StandardTimeZone.WestPacific },
                { "Pacific/Port_Moresby", StandardTimeZone.WestPacific },
                { "Pacific/Saipan", StandardTimeZone.WestPacific },
                { "Pacific/Truk", StandardTimeZone.WestPacific },

                // UTC+10:00 - Hobart
                { "Australia/Hobart", StandardTimeZone.Tasmania },
                { "Australia/Currie", StandardTimeZone.Tasmania },

                // UTC+10:00 - Vladivostok
                { "Asia/Vladivostok", StandardTimeZone.Vladivostok },
                { "Asia/Ust-Nera", StandardTimeZone.Vladivostok },

                // UTC+10:30 - Lord Howe Island
                { "Australia/Lord_Howe", StandardTimeZone.LordHowe },

                // UTC+11:00 - Bougainville Island
                { "Pacific/Bougainville", StandardTimeZone.Bougainville },

                // UTC+11:00 - Magadan
                { "Asia/Magadan", StandardTimeZone.Magadan },

                // UTC+11:00 - Norfolk Island
                { "Pacific/Norfolk", StandardTimeZone.Norfolk },

                // UTC+11:00 - Sakhalin
                { "Asia/Sakhalin", StandardTimeZone.Sakhalin },

                // UTC+11:00 - Solomon Is., New Caledonia
                { "Pacific/Guadalcanal", StandardTimeZone.CentralPacific },
                { "Pacific/Noumea", StandardTimeZone.CentralPacific },
                { "Pacific/Efate", StandardTimeZone.CentralPacific },
                { "Pacific/Ponape", StandardTimeZone.CentralPacific },

                // UTC+12:00 - Auckland, Wellington
                { "Pacific/Auckland", StandardTimeZone.NewZealand },

                // UTC+12:00 - Fiji
                { "Pacific/Fiji", StandardTimeZone.Fiji },

                // UTC+12:00 - Petropavlovsk-Kamchatsky
                { "Asia/Kamchatka", StandardTimeZone.Kamchatka },
                { "Asia/Anadyr", StandardTimeZone.Kamchatka },

                // UTC+12:45 - Chatham Islands
                { "Pacific/Chatham", StandardTimeZone.ChathamIslands },

                // UTC+13:00 - Nuku'alofa
                { "Pacific/Tongatapu", StandardTimeZone.Tonga },

                // UTC+13:00 - Samoa
                { "Pacific/Apia", StandardTimeZone.Samoa },

                // UTC+14:00 - Kiritimati Island
                { "Pacific/Kiritimati", StandardTimeZone.LineIslands },
            };

        /// <summary>
        /// Converts an IANA timezone identifier to a StandardTimeZone enum value.
        /// </summary>
        /// <param name="ianaTimeZoneId">The IANA timezone identifier (e.g., "America/New_York").</param>
        /// <returns>The corresponding StandardTimeZone enum value, or Unknown if no mapping exists.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public static StandardTimeZone ConvertIanaToStandardTimeZone(string ianaTimeZoneId)
        {
            if (string.IsNullOrWhiteSpace(ianaTimeZoneId))
            {
                return StandardTimeZone.Unknown;
            }

            return IanaToStandardTimeZoneMapping.TryGetValue(ianaTimeZoneId, out var standardTimeZone)
                ? standardTimeZone
                : StandardTimeZone.Unknown;
        }

        /// <summary>
        /// Tries to convert an IANA timezone identifier to a StandardTimeZone enum value.
        /// </summary>
        /// <param name="ianaTimeZoneId">The IANA timezone identifier.</param>
        /// <param name="standardTimeZone">When this method returns, contains the StandardTimeZone value if the conversion succeeded.</param>
        /// <returns>true if the conversion succeeded; otherwise, false.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public static bool TryConvertIanaToStandardTimeZone(string ianaTimeZoneId, out StandardTimeZone standardTimeZone)
        {
            if (string.IsNullOrWhiteSpace(ianaTimeZoneId))
            {
                standardTimeZone = StandardTimeZone.Unknown;
                return false;
            }

            return IanaToStandardTimeZoneMapping.TryGetValue(ianaTimeZoneId, out standardTimeZone);
        }

        /// <summary>
        /// Gets all supported IANA timezone identifiers that can be converted to StandardTimeZone values.
        /// </summary>
        /// <returns>A collection of supported IANA timezone identifiers.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Iana", Justification = ObcSuppressBecause.CA1704_IdentifiersShouldBeSpelledCorrectly_SpellingIsCorrectInContextOfTheDomain)]
        public static IEnumerable<string> GetSupportedIanaTimeZoneIds()
        {
            return IanaToStandardTimeZoneMapping.Keys;
        }

        /// <summary>
        /// Gets the count of supported IANA timezone mappings.
        /// </summary>
        /// <returns>The number of supported IANA timezone identifiers.</returns>
        public static int GetSupportedMappingCount()
        {
            return IanaToStandardTimeZoneMapping.Count;
        }
    }
}
