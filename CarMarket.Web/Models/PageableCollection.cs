namespace CarMarket.Web.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class PagingViewMOdel
    {
        public PageableCollection MyProperty { get; set; }
        public string BaseUrl { get; set; }
    }

    public class PageableCollection
    {
        public IEnumerable<CarViewModel> CarList { get; set; }

        public IEnumerable<CamperViewModel> CamperList { get; set; }

        public IEnumerable<BusViewModel> BusList { get; set; }

        public IEnumerable<BoatViewModel> BoatList { get; set; }

        public IEnumerable<AgriculturalViewModel> AgroList { get; set; }

        public IEnumerable<ConstructionViewModel> ConstructList { get; set; }

        public IEnumerable<MotoViewModel> MotoList { get; set; }

        public IEnumerable<TruckViewModel> TruckList { get; set; }

        public IEnumerable<MachineCollection> Machines { get; set; }

        public MachineryTypeEnum type { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public PageableCollection Pageabing(MachineCollection[] machine, int id, int count)
        {
            //machine.Reverse();
            var elemetPerPage = 10;
            var page = id;
            var totalPages = (int)Math.Ceiling(count / (decimal)elemetPerPage);
            var itemToSkip = (page - 1) * elemetPerPage;
            //foreach (var item in machine)
            //{
            //    foreach (var i in item.List)
            //    {
            //        count += 1;
            //    }
            //}



            //foreach (var item in machine)
            //{
            //    var list = item.List.Cast<object>().ToList();
            //    if (elemetPerPage == 0)
            //    {
            //        item.List = new List<object>();
            //        continue;
            //    }
            //
            //    if (itemToSkip > 0 && list.Count <= itemToSkip)
            //    {
            //        item.List = new List<object>();
            //        itemToSkip = itemToSkip - list.Count;
            //        continue;
            //    }
            //    else if (itemToSkip > 0 && list.Count > itemToSkip)
            //    {
            //        list.RemoveRange(0, itemToSkip);
            //        itemToSkip = 0;
            //    }
            //
            //    list = list.Take(elemetPerPage).ToList();
            //
            //    item.List = list;
            //
            //    elemetPerPage = elemetPerPage - list.Count;
            //}

            PageableCollection machines = new PageableCollection { Machines = machine, CurrentPage = page, TotalPages = totalPages };

            return (machines);
        }

        public PageableCollection Pageabing2(MachineCollection[] machine, int id)
        {
            var count = 0;
            foreach (var item in machine)
            {
                foreach (var i in item.List)
                {
                    count += 1;
                }
            }

            var elemetPerPage = 10;
            var page = id;
            var totalPages = (int)Math.Ceiling(count / (decimal)elemetPerPage);
            var itemToSkip = (page - 1) * elemetPerPage;

            foreach (var item in machine)
            {
                var list = item.List.Cast<object>().ToList();
                if (elemetPerPage == 0)
                {
                    item.List = new List<object>();
                    continue;
                }
            
                if (itemToSkip > 0 && list.Count <= itemToSkip)
                {
                    item.List = new List<object>();
                    itemToSkip = itemToSkip - list.Count;
                    continue;
                }
                else if (itemToSkip > 0 && list.Count > itemToSkip)
                {
                    list.RemoveRange(0, itemToSkip);
                    itemToSkip = 0;
                }
            
                list = list.Take(elemetPerPage).ToList();
            
                item.List = list;
            
                elemetPerPage = elemetPerPage - list.Count;
            }

            PageableCollection machines = new PageableCollection { Machines = machine, CurrentPage = page, TotalPages = totalPages };

            return (machines);
        }
    }
}