namespace CarMarket.Web.Models.BoatModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Type
    {
        public static readonly Dictionary<string, string> TypeList = new Dictionary<string, string>
        {
            { "1", "Моторна яхта" }, { "2", "Ветроходна лодка" }, { "3", "Джет" }, { "4", "Лодка" }, { "5", "Надуваема лодка" }, { "6", "Извънбордов двигател" }, { "7", "Каяк" }, { "8", "Кану" }, { "9", "Катер" }, { "10", "Водно колело" }, { "11", "Водни спортове" }, { "12", "Допълнително оборудване" }
        };
    }
}