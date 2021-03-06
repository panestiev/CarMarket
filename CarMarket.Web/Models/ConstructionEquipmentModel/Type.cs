﻿namespace CarMarket.Web.Models.ConstructionEquipmentModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Type
    {
        public static readonly Dictionary<string, string> TypeList = new Dictionary<string, string>
        {
            { "1", "Асвалтополагаща машина" },
            { "2", "Автовишка" },
            { "3", "Автокран" },
            { "4", "Багер" },
            { "5", "Бетон миксер" },
            { "6", "Бетон помпа" },
            { "7", "Валяк" },
            { "8", "Челен товарач" },
            { "9", "Допълнително оборудване" },
            { "10", "Дъмпери" },
            { "11", "Кари" },
            { "12", "Вишки и работни платформи" }
        };
    }
}