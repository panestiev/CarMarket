namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public static class Mapper
    {
        public static void Update<T, K>(T updateModel, K currentModel)
        {
            var updateProperties = updateModel.GetType().GetProperties();
            var currentPorperties = currentModel.GetType().GetProperties();

            //var momo = new Dictionary<string, object>();
            //
            //foreach (var item in updateProperties)
            //{
            //   var value = item.GetValue(updateModel);
            //   var key = item.Name;
            //
            //    momo.Add(key,value);
            //}
            //
            //
            //foreach (var item in currentPorperties)
            //{
            //            var value = momo[item.Name];
            //            item.SetValue(currentModel, value);
            //}

            foreach (var item in updateProperties)
            {
                foreach (var prop in currentPorperties)
                {
                    if (item.Name == prop.Name)
                    {
                         if (item.PropertyType == typeof(string) && item.GetValue(updateModel) != null
                            || item.PropertyType == typeof(int) && (int)item.GetValue(updateModel) > 0
                            || item.PropertyType == typeof(int?) && (int?)item.GetValue(updateModel) > 0
                            )
                        {
                            var value = item.GetValue(updateModel);
                            prop.SetValue(currentModel, value);
                       }
                    }
                }
            }
        }
        public static void UpdateList<T, K>(List<T> updateModel, List<K> currentModel)
        {

            //var getType = typeof(K);
            //var newInstance = Activator.CreateInstance(getType);
            //
            //foreach (var update in updateModel)
            //{
            //    Mapper.Update(update, newInstance);
            //    currentModel.Add((K)newInstance);
            //}
            //


            foreach (var update in updateModel)
            {
                var updateProperties = update.GetType().GetProperties();
                var ssss = typeof(K);
                var rrr = Activator.CreateInstance(ssss);

                foreach (var item in updateProperties)
                {
                    foreach (var prop in rrr.GetType().GetProperties())
                    {
                        if (item.Name == prop.Name)
                        {
                            var value = item.GetValue(update);
                            prop.SetValue(rrr, value);
                        }
                    }
                }
                currentModel.Add((K)rrr);
            }
        }
    }
}