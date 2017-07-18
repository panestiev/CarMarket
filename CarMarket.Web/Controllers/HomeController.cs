namespace CarMarket.Web.Controllers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CarMarket.Web.Models;
    using Microsoft.AspNet.Identity;

    public class HomeController : Controller
    {
        public string BaseImagesFolderVirtualPath
        {
            get
            {
                return "~/Files/";
            }
        }

        public string BaseImagesFolderPhysicalPath
        {
            get
            {
                return Server.MapPath(BaseImagesFolderVirtualPath);
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Searched(int id = 1, MachineryTypeEnum type = MachineryTypeEnum.Car)
            {
                SearchingViewModel mod = TempData["Search"] as SearchingViewModel;
                TempData["Search"] = mod;

            if (type == MachineryTypeEnum.Car)
            {
                var car = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List =  car as IEnumerable, DataType = typeof(CarEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = car as IEnumerable, DataType = typeof(CarViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Bus)
            {
                var bus = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = bus as IEnumerable, DataType = typeof(BusEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = bus as IEnumerable, DataType = typeof(BusViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Moto)
            {
                var moto = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = moto as IEnumerable, DataType = typeof(MotoEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = moto as IEnumerable, DataType = typeof(MotoViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Truck)
            {
                var truck = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = truck as IEnumerable, DataType = typeof(TruckEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = truck as IEnumerable, DataType = typeof(TruckViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Camper)
            {
                var camper = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = camper as IEnumerable, DataType = typeof(CamperEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = camper as IEnumerable, DataType = typeof(CamperViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Boat)
            {
                var boat = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = boat as IEnumerable, DataType = typeof(BoatEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = boat as IEnumerable, DataType = typeof(BoatViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Construction)
            {
                var construct = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = construct as IEnumerable, DataType = typeof(ConstructionEntityViewModel) };
                var machines = new MachineCollection[]
                {
                new MachineCollection { List = construct as IEnumerable, DataType = typeof(ConstructionViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else if (type == MachineryTypeEnum.Agricultural)
            {
                var agro = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = agro as IEnumerable, DataType = typeof(AgriculturalEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = agro as IEnumerable, DataType = typeof(AgriculturalViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, id);
                return View(machine);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Searched(SearchingViewModel mod)
        {
            TempData["Search"] = mod;

            if (mod.MachineType == MachineryTypeEnum.Car)
            {
                var car = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List =  car as IEnumerable, DataType = typeof(CarEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = car as IEnumerable, DataType = typeof(CarViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Bus)
            {
                var bus = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = bus as IEnumerable, DataType = typeof(BusEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = bus as IEnumerable, DataType = typeof(BusViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Moto)
            {
                var moto = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = moto as IEnumerable, DataType = typeof(MotoEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = moto as IEnumerable, DataType = typeof(MotoViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Truck)
            {
                var truck = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = truck as IEnumerable, DataType = typeof(TruckEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = truck as IEnumerable, DataType = typeof(TruckViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Camper)
            {
                var camper = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = camper as IEnumerable, DataType = typeof(CamperEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = camper as IEnumerable, DataType = typeof(CamperViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Boat)
            {
                var boat = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = boat as IEnumerable, DataType = typeof(BoatEntityViewModel) };

                var machines = new MachineCollection[]
                {
                new MachineCollection { List = boat as IEnumerable, DataType = typeof(BoatViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Construction)
            {
                var construct = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = construct as IEnumerable, DataType = typeof(ConstructionEntityViewModel) };
                var machines = new MachineCollection[]
                {
                new MachineCollection { List = construct as IEnumerable, DataType = typeof(ConstructionViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else if (mod.MachineType == MachineryTypeEnum.Agricultural)
            {
                var agro = SearchMachines(mod);
                //MachineCollection machine = new MachineCollection { List = agro as IEnumerable, DataType = typeof(AgriculturalEntityViewModel) };
                
                var machines = new MachineCollection[]
                {
                new MachineCollection { List = agro as IEnumerable, DataType = typeof(AgriculturalViewModel)}
                };

                PageableCollection machine = new PageableCollection().Pageabing2(machines, 1);
                return View(machine);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult CreateCar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCar(CarViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            CarEntityViewModel car = new CarEntityViewModel();
            Mapper.Update(mod, car);

            car.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            car.MachineType = MachineryTypeEnum.Car;
            car.SellerName = User.Identity.Name;
            car.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(car);
            if (!ModelState.IsValid)
            {
                return View(car);
            }

            var context = ApplicationDbContext.Create();
            context.Car.Add(car);
            context.SaveChanges();

            var carContext = context.Car.ToList();
            var id = carContext[carContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Car.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateBus()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBus(BusViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            BusEntityViewModel bus = new BusEntityViewModel();
            Mapper.Update(mod, bus);

            bus.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            bus.MachineType = MachineryTypeEnum.Bus;
            bus.SellerName = User.Identity.Name;
            bus.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(bus);
            if (!ModelState.IsValid)
            {
                return View(bus);
            }

            var context = ApplicationDbContext.Create();
            context.Bus.Add(bus);
            context.SaveChanges();

            var busContext = context.Bus.ToList();
            var id = busContext[busContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Bus.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateMoto()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateMoto(MotoViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            MotoEntityViewModel moto = new MotoEntityViewModel();
            Mapper.Update(mod, moto);

            moto.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            moto.MachineType = MachineryTypeEnum.Moto;
            moto.SellerName = User.Identity.Name;
            moto.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(moto);
            if (!ModelState.IsValid)
            {
                return View(moto);
            }

            var context = ApplicationDbContext.Create();
            context.Moto.Add(moto);

            context.SaveChanges();

            var motoContext = context.Moto.ToList();
            var id = motoContext[motoContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Moto.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateCamper()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCamper(CamperViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            CamperEntityViewModel camper = new CamperEntityViewModel();
            Mapper.Update(mod, camper);

            camper.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            camper.MachineType = MachineryTypeEnum.Camper;
            camper.SellerName = User.Identity.Name;
            camper.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(camper);
            if (!ModelState.IsValid)
            {
                return View(camper);
            }

            var context = ApplicationDbContext.Create();
            context.Camper.Add(camper);

            context.SaveChanges();

            var campContext = context.Camper.ToList();
            var id = campContext[campContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Camper.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateTruck()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTruck(TruckViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            TruckEntityViewModel truck = new TruckEntityViewModel();
            Mapper.Update(mod, truck);

            truck.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            truck.MachineType = MachineryTypeEnum.Truck;
            truck.SellerName = User.Identity.Name;
            truck.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(truck);
            if (!ModelState.IsValid)
            {
                return View(truck);
            }

            var context = ApplicationDbContext.Create();
            context.Truck.Add(truck);

            context.SaveChanges();

            var truckContext = context.Truck.ToList();
            var id = truckContext[truckContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Truck.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateBoat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateBoat(BoatViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            BoatEntityViewModel boat = new BoatEntityViewModel();
            Mapper.Update(mod, boat);

            boat.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            boat.MachineType = MachineryTypeEnum.Boat;
            boat.SellerName = User.Identity.Name;
            boat.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(boat);
            if (!ModelState.IsValid)
            {
                return View(boat);
            }

            var context = ApplicationDbContext.Create();
            context.Boat.Add(boat);

            context.SaveChanges();

            var boatContext = context.Boat.ToList();
            var id = boatContext[boatContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Boat.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateAgricultural()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAgricultural(AgriculturalViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            AgriculturalEntityViewModel agricultural = new AgriculturalEntityViewModel();
            Mapper.Update(mod, agricultural);

            agricultural.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            agricultural.MachineType = MachineryTypeEnum.Agricultural;
            agricultural.SellerName = User.Identity.Name;
            agricultural.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(agricultural);
            if (!ModelState.IsValid)
            {
                return View(agricultural);
            }

            var context = ApplicationDbContext.Create();
            context.Agricultural.Add(agricultural);

            context.SaveChanges();

            var agriculturalContext = context.Agricultural.ToList();
            var id = agriculturalContext[agriculturalContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Agricultural.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult CreateConstruction()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateConstruction(ConstructionViewModel mod, HttpPostedFileBase[] files, string button)
        {
            ModelState.Clear();
            ConstructionEntityViewModel construction = new ConstructionEntityViewModel();
            Mapper.Update(mod, construction);

            construction.YearOfManufacture = Convert.ToDateTime(mod.Months + "." + mod.Months + "." + Models.MachineModel.Years.YearsList[mod.Years]);
            construction.MachineType = MachineryTypeEnum.Construction;
            construction.SellerName = User.Identity.Name;
            construction.ApplicationUserId = User.Identity.GetUserId();

            TryValidateModel(construction);
            if (!ModelState.IsValid)
            {
                return View(construction);
            }

            var context = ApplicationDbContext.Create();
            context.Construction.Add(construction);

            context.SaveChanges();

            var contructionContext = context.Construction.ToList();
            var id = contructionContext[contructionContext.Count - 1].MachineId;

            SaveImagesForMachinerie(id, MachineryTypeEnum.Construction.ToString(), files);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Edit(IndexModel mod, string button1)
        {
            IndexModel machine = (IndexModel)EditMachine(mod, button1);

            return View(machine);
        }

        [HttpPost]
        public ActionResult Edit(IndexModel modd, int id)
        {
            SaveMachine(modd, id);
            return RedirectToAction("Profile");
        }

        [HttpGet]
        public ActionResult Profile(int id = 1)
        {
            var machine = (MachineCollection[])UserAllMachines();
            var machines = new PageableCollection().Pageabing2(machine, id);

            return View(machines);
        }

        [HttpPost]
        public ActionResult Profile(string button, string button1, int id = 1)
        {
            if (button != null)
            {
                DeleteMachine(button);
            }
            else if (button1 != null)
            {
                return RedirectToAction("Edit", new { button1 = button1 });
            }

            return RedirectToAction("Profile");
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            string fileFolderVirtualPath = "~/Files/" + User.Identity.Name;
            string fileFolderPhysicalPath = Server.MapPath(fileFolderVirtualPath);

            if (!Directory.Exists(fileFolderPhysicalPath))
            {
                Directory.CreateDirectory(fileFolderPhysicalPath);
            }

            string fileVirtualPath = string.Format("{0}/{1}", fileFolderVirtualPath, file.FileName);
            string filePhysicalPath = Server.MapPath(fileVirtualPath);

            file.SaveAs(filePhysicalPath);

            string fileUrl = Url.Content(fileVirtualPath);

            return View("UploadFile", fileUrl as object);
        }

        public void SaveImagesForMachinerie(int machineriesId, string type, HttpPostedFileBase[] files)
        {
            string imagesFolderPhyscalPath = Path.Combine(BaseImagesFolderPhysicalPath, string.Format(@"{0}\{1}\{2}", type, User.Identity.GetUserName(), machineriesId));
            if (!Directory.Exists(imagesFolderPhyscalPath))
            {
                Directory.CreateDirectory(imagesFolderPhyscalPath);
            }

            foreach (var file in files)
            {
                if (file != null)
                {
                    string filePhysicalPath = Path.Combine(imagesFolderPhyscalPath, string.Format("{0}-{1}", DateTime.Now.Ticks, file.FileName));
                    file.SaveAs(filePhysicalPath);
                }
            }
        }

        public string[] GetImagesForMachinerie(int machineriesId, string type, string userName)
        {
            string imagesFolderPhyscalPath = Path.Combine(BaseImagesFolderPhysicalPath, string.Format(@"{0}\{1}\{2}", type, userName, machineriesId));

            if (!Directory.Exists(imagesFolderPhyscalPath))
            {
                Directory.CreateDirectory(imagesFolderPhyscalPath);
            }

            string[] filePhysicalPaths = Directory.GetFiles(imagesFolderPhyscalPath);

            string[] fileVIrtualPaths = new string[filePhysicalPaths.Length];

            for (int i = 0; i < filePhysicalPaths.Length; i++)
            {
                string physicalPAth = filePhysicalPaths[i];

                string partialPhysicalPAth = physicalPAth.Replace(BaseImagesFolderPhysicalPath, string.Empty);

                string virtualPAth = string.Format("{0}{1}", BaseImagesFolderVirtualPath, partialPhysicalPAth.Replace(@"\", "/"));

                fileVIrtualPaths[i] = virtualPAth;
            }

            return fileVIrtualPaths;
        }

        [HttpGet]
        public ActionResult ViewDetails(int id, MachineryTypeEnum type)
        {
            object result = MachineDetails(id, type);

            if (result == null)
            {
                return View("Message", string.Format("Machine with id '{0}' is not found."));
            }

            return View(result);
        }

        [HttpGet]
        public ActionResult ViewMachines(int id = 1, MachineryTypeEnum type = MachineryTypeEnum.Car)
        {
            int elementPerPage = 10;
            int elementToSkip = (id - 1) * elementPerPage;

            int count = 0;
            var context = ApplicationDbContext.Create();
            MachineCollection[] machine = new MachineCollection[8];

            if (type.ToString() == Models.MachineryTypeEnum.Car.ToString())
            {

                List<CarViewModel> cars = new List<CarViewModel>();
                var newCar = context.Car.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
               {
                   MachineId = p.MachineId,
                   Model = p.Model,
                   Brand = p.Brand,
                   SellerName = p.SellerName,
                   Price = p.Price,
                   MachineType = p.MachineType,
                   HorsePower = p.HorsePower,
                   Gear = p.Gear,
                   Km = p.Km,
                   Fuel = p.Fuel,
                   Months = p.Months,
                   Years = p.Years
               }).ToList();

                count = context.Car.Count();
                Mapper.UpdateList(newCar, cars);

                foreach (var car in cars)
                {
                    var carId = car.MachineId;
                    var name = car.SellerName;
                    var types = car.MachineType.ToString();
                    car.ImageVirtualPaths = GetImagesForMachinerie(carId, types, name);
                    car.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = cars as IEnumerable, DataType = typeof(CarViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Bus.ToString())
            {
                List<BusViewModel> buses = new List<BusViewModel>();
                var newBuses = context.Bus.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Bus.Count();
                Mapper.UpdateList(newBuses, buses);

                foreach (var bus in buses)
                {
                    var busId = bus.MachineId;
                    var name = bus.SellerName;
                    var types = bus.MachineType.ToString();
                    bus.ImageVirtualPaths = GetImagesForMachinerie(busId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = buses as IEnumerable, DataType = typeof(BusViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Moto.ToString())
            {
                List<MotoViewModel> motos = new List<MotoViewModel>();
                var newMotos = context.Moto.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                 {
                     MachineId = p.MachineId,
                     Model = p.Model,
                     Brand = p.Brand,
                     SellerName = p.SellerName,
                     Price = p.Price,
                     MachineType = p.MachineType,
                     HorsePower = p.HorsePower,
                     Gear = p.Gear,
                     Km = p.Km,
                     Fuel = p.Fuel,
                     Months = p.Months,
                     Years = p.Years
                 }).ToList();

                count = context.Moto.Count();
                Mapper.UpdateList(newMotos, motos);

                foreach (var moto in motos)
                {
                    var motoId = moto.MachineId;
                    var name = moto.SellerName;
                    var types = moto.MachineType.ToString();
                    moto.ImageVirtualPaths = GetImagesForMachinerie(motoId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = motos as IEnumerable, DataType = typeof(MotoViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Truck.ToString())
            {
                List<TruckViewModel> trucks = new List<TruckViewModel>();
                var newTrucks = context.Truck.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Truck.Count();
                Mapper.UpdateList(newTrucks, trucks);

                foreach (var truck in trucks)
                {
                    var motoId = truck.MachineId;
                    var name = truck.SellerName;
                    var types = truck.MachineType.ToString();
                    truck.ImageVirtualPaths = GetImagesForMachinerie(motoId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = trucks as IEnumerable, DataType = typeof(TruckViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Camper.ToString())
            {
                List<CamperViewModel> campers = new List<CamperViewModel>();
                var newCampers = context.Camper.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                 {
                     MachineId = p.MachineId,
                     Model = p.Model,
                     Brand = p.Brand,
                     SellerName = p.SellerName,
                     Price = p.Price,
                     MachineType = p.MachineType,
                     HorsePower = p.HorsePower,
                     Gear = p.Gear,
                     Km = p.Km,
                     Fuel = p.Fuel,
                     Months = p.Months,
                     Years = p.Years
                 }).ToList();

                count = context.Camper.Count();
                Mapper.UpdateList(newCampers, campers);

                foreach (var camper in campers)
                {
                    var busId = camper.MachineId;
                    var name = camper.SellerName;
                    var types = camper.MachineType.ToString();
                    camper.ImageVirtualPaths = GetImagesForMachinerie(busId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = campers as IEnumerable, DataType = typeof(CamperViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Boat.ToString())
            {
                List<BoatViewModel> boats = new List<BoatViewModel>();
                var newBoats = context.Boat.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Boat.Count();
                Mapper.UpdateList(newBoats, boats);

                foreach (var boat in boats)
                {
                    var boatId = boat.MachineId;
                    var name = boat.SellerName;
                    var types = boat.MachineType.ToString();
                    boat.ImageVirtualPaths = GetImagesForMachinerie(boatId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = boats as IEnumerable, DataType = typeof(BoatViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Agricultural.ToString())
            {
                List<AgriculturalViewModel> agriculturals = new List<AgriculturalViewModel>();
                var newAgriculturals = context.Agricultural.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Agricultural.Count();
                Mapper.UpdateList(newAgriculturals, agriculturals);

                foreach (var agricultural in agriculturals)
                {
                    var agroId = agricultural.MachineId;
                    var name = agricultural.SellerName;
                    var types = agricultural.MachineType.ToString();
                    agricultural.ImageVirtualPaths = GetImagesForMachinerie(agroId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = agriculturals as IEnumerable, DataType = typeof(AgriculturalViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Construction.ToString())
            {
                List<ConstructionViewModel> constructions = new List<ConstructionViewModel>();
                var newConstructions = context.Construction.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    Km = p.Km,
                    HorsePower = p.HorsePower,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Construction.Count();
                Mapper.UpdateList(newConstructions, constructions);

                foreach (var construction in constructions)
                {
                    var constructId = construction.MachineId;
                    var name = construction.SellerName;
                    var types = construction.MachineType.ToString();
                    construction.ImageVirtualPaths = GetImagesForMachinerie(constructId, types, name);
                }

                machine = new MachineCollection[] { new MachineCollection { List = constructions as IEnumerable, DataType = typeof(ConstructionViewModel) } };
            }

            PageableCollection machines = new PageableCollection().Pageabing(machine, id, count);

            return View(machines);
        }

        [HttpPost]
        public ActionResult ViewMachines(MachineryTypeEnum type = MachineryTypeEnum.Car)
        {
            int count = 0;
            int id = 1;
            int elementPerPage = 10;
            int elementToSkip = (id - 1) * elementPerPage;
            var context = ApplicationDbContext.Create();

            MachineCollection[] machine = new MachineCollection[8];

            if (type.ToString() == Models.MachineryTypeEnum.Car.ToString())
            {

                List<CarViewModel> cars = new List<CarViewModel>();
                var newCar = context.Car.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Car.Count();
                Mapper.UpdateList(newCar, cars);

                foreach (var car in cars)
                {
                    var carId = car.MachineId;
                    var name = car.SellerName;
                    var types = car.MachineType.ToString();
                    car.ImageVirtualPaths = GetImagesForMachinerie(carId, types, name);
                    car.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = cars as IEnumerable, DataType = typeof(CarViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Bus.ToString())
            {
                List<BusViewModel> buses = new List<BusViewModel>();
                var newBuses = context.Bus.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Bus.Count();
                Mapper.UpdateList(newBuses, buses);

                foreach (var bus in buses)
                {
                    var busId = bus.MachineId;
                    var name = bus.SellerName;
                    var types = bus.MachineType.ToString();
                    bus.ImageVirtualPaths = GetImagesForMachinerie(busId, types, name);
                    bus.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = buses as IEnumerable, DataType = typeof(BusViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Moto.ToString())
            {
                List<MotoViewModel> motos = new List<MotoViewModel>();
                var newMotos = context.Moto.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Moto.Count();
                Mapper.UpdateList(newMotos, motos);

                foreach (var moto in motos)
                {
                    var motoId = moto.MachineId;
                    var name = moto.SellerName;
                    var types = moto.MachineType.ToString();
                    moto.ImageVirtualPaths = GetImagesForMachinerie(motoId, types, name);
                    moto.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = motos as IEnumerable, DataType = typeof(MotoViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Truck.ToString())
            {
                List<TruckViewModel> trucks = new List<TruckViewModel>();
                var newTrucks = context.Truck.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Truck.Count();
                Mapper.UpdateList(newTrucks, trucks);

                foreach (var truck in trucks)
                {
                    var motoId = truck.MachineId;
                    var name = truck.SellerName;
                    var types = truck.MachineType.ToString();
                    truck.ImageVirtualPaths = GetImagesForMachinerie(motoId, types, name);
                    truck.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = trucks as IEnumerable, DataType = typeof(TruckViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Camper.ToString())
            {
                List<CamperViewModel> campers = new List<CamperViewModel>();
                var newCampers = context.Camper.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Gear = p.Gear,
                    Km = p.Km,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Camper.Count();
                Mapper.UpdateList(newCampers, campers);

                foreach (var camper in campers)
                {
                    var busId = camper.MachineId;
                    var name = camper.SellerName;
                    var types = camper.MachineType.ToString();
                    camper.ImageVirtualPaths = GetImagesForMachinerie(busId, types, name);
                    camper.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = campers as IEnumerable, DataType = typeof(CamperViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Boat.ToString())
            {
                List<BoatViewModel> boats = new List<BoatViewModel>();
                var newBoats = context.Boat.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    HorsePower = p.HorsePower,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Boat.Count();
                Mapper.UpdateList(newBoats, boats);

                foreach (var boat in boats)
                {
                    var boatId = boat.MachineId;
                    var name = boat.SellerName;
                    var types = boat.MachineType.ToString();
                    boat.ImageVirtualPaths = GetImagesForMachinerie(boatId, types, name);
                    boat.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = boats as IEnumerable, DataType = typeof(BoatViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Agricultural.ToString())
            {
                List<AgriculturalViewModel> agriculturals = new List<AgriculturalViewModel>();
                var newAgriculturals = context.Agricultural.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Agricultural.Count();
                Mapper.UpdateList(newAgriculturals, agriculturals);

                foreach (var agricultural in agriculturals)
                {
                    var agroId = agricultural.MachineId;
                    var name = agricultural.SellerName;
                    var types = agricultural.MachineType.ToString();
                    agricultural.ImageVirtualPaths = GetImagesForMachinerie(agroId, types, name);
                    agricultural.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = agriculturals as IEnumerable, DataType = typeof(AgriculturalViewModel) } };
            }
            else if (type.ToString() == Models.MachineryTypeEnum.Construction.ToString())
            {
                List<ConstructionViewModel> constructions = new List<ConstructionViewModel>();
                var newConstructions = context.Construction.OrderByDescending(x => x.MachineId).Skip(elementToSkip).Take(elementPerPage).Select(p => new
                {
                    MachineId = p.MachineId,
                    Model = p.Model,
                    Brand = p.Brand,
                    SellerName = p.SellerName,
                    Price = p.Price,
                    MachineType = p.MachineType,
                    Km = p.Km,
                    HorsePower = p.HorsePower,
                    Fuel = p.Fuel,
                    Months = p.Months,
                    Years = p.Years
                }).ToList();

                count = context.Construction.Count();
                Mapper.UpdateList(newConstructions, constructions);

                foreach (var construction in constructions)
                {
                    var constructId = construction.MachineId;
                    var name = construction.SellerName;
                    var types = construction.MachineType.ToString();
                    construction.ImageVirtualPaths = GetImagesForMachinerie(constructId, types, name);
                    construction.Update();
                }

                machine = new MachineCollection[] { new MachineCollection { List = constructions as IEnumerable, DataType = typeof(ConstructionViewModel) } };
            }

            PageableCollection machines = new PageableCollection().Pageabing(machine, id, count);

            return View(machines);
        }

        [HttpPost]
        public JsonResult GetCarsModel(string valueOfModel)
        {
            return Json(new SelectList(CarMarket.Web.Models.CarModel.Model.ModelList[valueOfModel]).Items);
        }

        [HttpPost]
        public JsonResult GetBusesModel(string valueOfModel)
        {
            return Json(new SelectList(CarMarket.Web.Models.BusModel.Model.ModelList[valueOfModel]).Items);
        }

        private object SearchMachines(SearchingViewModel mod)
        {
            ApplicationDbContext context = ApplicationDbContext.Create();

            if (mod.MachineType == MachineryTypeEnum.Car)
            {
                IQueryable<CarEntityViewModel> cars = context.Car.AsQueryable();

                if (mod.Model != null)
                {
                    mod.Model = CarMarket.Web.Models.CarModel.Model.ModelList[mod.Brand][mod.Model];
                    cars = cars.Where(x => x.Model == mod.Model);
                }

                if (mod.Brand != null)
                {
                    mod.Brand = CarMarket.Web.Models.CarModel.Brand.BrandList[mod.Brand];
                    cars = cars.Where(x => x.Brand == mod.Brand);
                }

                if (mod.Carriage != null)
                {
                    mod.Carriage = CarMarket.Web.Models.CarModel.Carriage.CarriageList[mod.Carriage];
                    cars = cars.Where(x => x.Carriage == mod.Carriage);
                }

                if (mod.Fuel != null)
                {
                    mod.Fuel = CarMarket.Web.Models.MachineModel.Fuel.FuelList[mod.Fuel];
                    cars = cars.Where(x => x.Fuel == mod.Fuel);
                }

                if (mod.NumberOfDoors != null)
                {
                    mod.NumberOfDoors = CarMarket.Web.Models.MachineModel.NumberOfDoors.DoorList[mod.NumberOfDoors];
                    cars = cars.Where(x => x.NumberOfDoors == mod.NumberOfDoors);
                }

                if (mod.Gear != null)
                {
                    mod.Gear = CarMarket.Web.Models.MachineModel.Gear.GearList[mod.Gear];
                    cars = cars.Where(x => x.Gear == mod.Gear);
                }

                List<CarEntityViewModel> machinesList = cars.ToList();
                List<CarViewModel> newCar = new List<CarViewModel>();
                Mapper.UpdateList(machinesList, newCar);

                foreach (var car in newCar)
                {
                    var id = car.MachineId;
                    var name = car.SellerName;
                    var type = car.MachineType.ToString();
                    car.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    car.Update();
                }

                return newCar;
            }
            else if (mod.MachineType == MachineryTypeEnum.Bus)
            {
                IQueryable<BusEntityViewModel> buses = context.Bus.AsQueryable();

                if (mod.Type != null)
                {
                    mod.Type = CarMarket.Web.Models.BusModel.Type.TypeList[mod.Type];
                    buses = buses.Where(x => x.Type == mod.Type);
                }
                else if (mod.Model != null)
                {
                    mod.Model = CarMarket.Web.Models.BusModel.Model.ModelList[mod.Brand][mod.Model];
                    buses = buses.Where(x => x.Model == mod.Model);
                }
                else if (mod.Brand != null)
                {
                    mod.Brand = CarMarket.Web.Models.BusModel.Brand.BrandList[mod.Brand];
                    buses = buses.Where(x => x.Brand == mod.Brand);
                }
                else if (mod.Fuel != null)
                {
                    mod.Fuel = CarMarket.Web.Models.MachineModel.Fuel.FuelList[mod.Fuel];
                    buses = buses.Where(x => x.Fuel == mod.Fuel);
                }
                else if (mod.Gear != null)
                {
                    mod.Gear = CarMarket.Web.Models.MachineModel.Gear.GearList[mod.Gear];
                    buses = buses.Where(x => x.Gear == mod.Gear);
                }

                List<BusEntityViewModel> machinesList = buses.ToList();
                List<BusViewModel> newBus = new List<BusViewModel>();
                Mapper.UpdateList(machinesList, newBus);

                foreach (var bus in newBus)
                {
                    var id = bus.MachineId;
                    var name = bus.SellerName;
                    var type = bus.MachineType.ToString();
                    bus.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    bus.Update();
                }

                return newBus;
            }
            else if (mod.MachineType == MachineryTypeEnum.Moto)
            {
                IQueryable<MotoEntityViewModel> motos = context.Moto.AsQueryable();

                if (mod.Category != null)
                {
                    mod.Category = CarMarket.Web.Models.MotoModel.Category.CategoryList[mod.Category];
                    motos = motos.Where(x => x.Category == mod.Category);
                }
                else if (mod.Model != null)
                {
                    motos = motos.Where(x => x.Model == mod.Model);
                }
                else if (mod.Brand != null)
                {
                    mod.Brand = CarMarket.Web.Models.MotoModel.Brand.MotoList[mod.Brand];
                    motos = motos.Where(x => x.Brand == mod.Brand);
                }

                List<MotoEntityViewModel> machinesList = motos.ToList();
                List<MotoViewModel> newMoto = new List<MotoViewModel>();
                Mapper.UpdateList(machinesList,newMoto);

                foreach (var moto in newMoto)
                {
                    var id = moto.MachineId;
                    var name = moto.SellerName;
                    var type = moto.MachineType.ToString();
                    moto.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    moto.Update();
                }

                return newMoto;
            }
            else if (mod.MachineType == MachineryTypeEnum.Truck)
            {
                IQueryable<TruckEntityViewModel> trucks = context.Truck.AsQueryable();

                if (mod.Category != null)
                {
                    mod.Category = CarMarket.Web.Models.TruckModel.Category.CategoryList[mod.Category];
                    trucks.Where(x => x.Category == mod.Category);
                }
                else if (mod.Model != null)
                {
                    trucks.Where(x => x.Model == mod.Model);
                }
                else if (mod.Brand != null)
                {
                    mod.Brand = CarMarket.Web.Models.TruckModel.Brand.BrandList[mod.Brand];
                    trucks.Where(x => x.Brand == mod.Brand);
                }

                List<TruckEntityViewModel> machinesList = trucks.ToList();
                List<TruckViewModel> newTruck = new List<TruckViewModel>();
                Mapper.UpdateList(machinesList,newTruck);

                foreach (var truck in newTruck)
                {
                    var id = truck.MachineId;
                    var name = truck.SellerName;
                    var type = truck.MachineType.ToString();
                    truck.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    truck.Update();
                }

                return newTruck;
            }
            else if (mod.MachineType == MachineryTypeEnum.Camper)
            {
                IQueryable<CamperEntityViewModel> campers = context.Camper.AsQueryable();

                if (mod.Type != null)
                {
                    mod.Type = CarMarket.Web.Models.CamperModel.Type.TypeList[mod.Type];
                    campers = campers.Where(x => x.Type == mod.Type);
                }
                else if (mod.Model != null)
                {
                    campers = campers.Where(x => x.Model == mod.Model);
                }
                else if (mod.Brand != null)
                {
                    mod.Brand = CarMarket.Web.Models.CamperModel.Brand.BrandList[mod.Brand];
                    campers = campers.Where(x => x.Brand == mod.Brand);
                }

                List<CamperEntityViewModel> machinesList = campers.ToList();
                List<CamperViewModel> newCamp = new List<CamperViewModel>();
                Mapper.UpdateList(machinesList,newCamp);

                foreach (var camper in newCamp)
                {
                    var id = camper.MachineId;
                    var name = camper.SellerName;
                    var type = camper.MachineType.ToString();
                    camper.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    camper.Update();
                }

                return newCamp;
            }
            else if (mod.MachineType == MachineryTypeEnum.Boat)
            {
                IQueryable<BoatEntityViewModel> boats = context.Boat.AsQueryable();

                if (mod.Type != null)
                {
                    mod.Type = CarMarket.Web.Models.BoatModel.Type.TypeList[mod.Type];
                    boats = boats.Where(x => x.Type == mod.Type);
                }
                else if (mod.Brand != null)
                {
                    boats = boats.Where(x => x.Brand == mod.Brand);
                }
                else if (mod.Model != null)
                {
                    boats = boats.Where(x => x.Model == mod.Model);
                }

                List<BoatEntityViewModel> machinesList = boats.ToList();
                List<BoatViewModel> newBoat = new List<BoatViewModel>();
                Mapper.UpdateList(machinesList,newBoat);

                foreach (var boat in newBoat)
                {
                    var id = boat.MachineId;
                    var name = boat.SellerName;
                    var type = boat.MachineType.ToString();
                    boat.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    boat.Update();
                }

                return newBoat;
            }
            else if (mod.MachineType == MachineryTypeEnum.Construction)
            {
                IQueryable<ConstructionEntityViewModel> constructs = context.Construction.AsQueryable();

                if (mod.Type != null)
                {
                    mod.Type = CarMarket.Web.Models.ConstructionEquipmentModel.Type.TypeList[mod.Type];
                    constructs = constructs.Where(x => x.Type == mod.Type);
                }
                else if (mod.Brand != null)
                {
                    constructs = constructs.Where(x => x.Brand == mod.Brand);
                }
                else if (mod.Model != null)
                {
                    constructs = constructs.Where(x => x.Model == mod.Model);
                }

                List<ConstructionEntityViewModel> machinesList = constructs.ToList();
                List<ConstructionViewModel> newConstruct = new List<ConstructionViewModel>();
                Mapper.UpdateList(machinesList, newConstruct);

                foreach (var construct in newConstruct)
                {
                    var id = construct.MachineId;
                    var name = construct.SellerName;
                    var type = construct.MachineType.ToString();
                    construct.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    construct.Update();
                }

                return newConstruct;
            }
            else if (mod.MachineType == MachineryTypeEnum.Agricultural)
            {
                IQueryable<AgriculturalEntityViewModel> agricults = context.Agricultural.AsQueryable();

                if (mod.Category != null)
                {
                    mod.Category = CarMarket.Web.Models.AgriculturalMachineryModel.Category.CategoryList[mod.Category];
                    agricults = agricults.Where(x => x.Category == mod.Category);
                }
                else if (mod.Brand != null)
                {
                    agricults = agricults.Where(x => x.Brand == mod.Brand);
                }
                else if (mod.Model != null)
                {
                    agricults = agricults.Where(x => x.Model == mod.Model);
                }

                List<AgriculturalEntityViewModel> machinesList = agricults.ToList();
                List<AgriculturalViewModel> newAgro = new List<AgriculturalViewModel>();
                Mapper.UpdateList(machinesList,newAgro);

                foreach (var agricult in newAgro)
                {
                    var id = agricult.MachineId;
                    var name = agricult.SellerName;
                    var type = agricult.MachineType.ToString();
                    agricult.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
                    agricult.Update();
                }

                return newAgro;
            }

            return 1;
        }

        private void DeleteMachine(string str)
        {
            var stringlist = str.Split(',').Select(s => s.Trim()).ToArray();
            var id = int.Parse(stringlist[0]);
            var type = stringlist[1];
            var currentUserId = User.Identity.GetUserId();

            var context = ApplicationDbContext.Create();
            var validate = context.ValidateMachine(type, id);

            if (validate)
            {
                context.Delete(type, id);
            }
        }

        private void SaveMachine(IndexModel modd, int id)
        {
            var context = ApplicationDbContext.Create();

            if (modd.MachineType == MachineryTypeEnum.Car)
            {
                var car = (CarEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, car);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Bus)
            {
                var bus = (BusEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, bus);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Moto)
            {
                var moto = (MotoEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, moto);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Camper)
            {
                var camper = (CamperEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, camper);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Truck)
            {
                var truck = (TruckEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, truck);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Boat)
            {
                var boat = (BoatEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, boat);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Construction)
            {
                var construct = (ConstructionEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, construct);
                    context.SaveChanges();
                }

                return;
            }

            if (modd.MachineType == MachineryTypeEnum.Agricultural)
            {
                var agricult = (AgriculturalEntityViewModel)context.GetMachineById(id, modd.MachineType);
                var validate = context.ValidateMachine(modd.MachineType.ToString(), id);

                if (validate)
                {
                    Mapper.Update(modd, agricult);
                    context.SaveChanges();
                }

                return;
            }
        }

        private object UserAllMachines()
        {
            var context = ApplicationDbContext.Create();
            var userID = User.Identity.GetUserId();

            List<MachineViewModel> allMachines = context.GetMachinesByUserId(userID);

            var machine = ImageLoaded(allMachines);

            return machine;
        }

        private object MachineDetails(int id, MachineryTypeEnum type)
        {
            var context = ApplicationDbContext.Create();
            MachineEntityViewModel machine = context.GetMachineById(id, type);
            machine.ImageVirtualPaths = GetImagesForMachinerie(id, type.ToString(), machine.SellerName);
            
            return machine;
        }

        private object EditMachine(IndexModel mod, string str)
        {
            var stringlist = str.Split(',').Select(s => s.Trim()).ToArray();
            var id = stringlist[0];
            var type = stringlist[1];

            var currentId = int.Parse(id);
            var context = ApplicationDbContext.Create();

            if (type == MachineryTypeEnum.Car.ToString())
            {
                var car = context.GetMachineById(currentId, MachineryTypeEnum.Car);
                mod.UpdateFromDb(car);
                return mod;
            }

            if (type == MachineryTypeEnum.Bus.ToString())
            {
                var bus = context.GetMachineById(currentId, MachineryTypeEnum.Bus);
                mod.UpdateFromDb(bus);
                return mod;
            }

            if (type == MachineryTypeEnum.Moto.ToString())
            {
                var moto = context.GetMachineById(currentId, MachineryTypeEnum.Moto);
                mod.UpdateFromDb(moto);
                return mod;
            }

            if (type == MachineryTypeEnum.Camper.ToString())
            {
                var camper = context.GetMachineById(currentId, MachineryTypeEnum.Camper);
                mod.UpdateFromDb(camper);
                return mod;
            }

            if (type == MachineryTypeEnum.Truck.ToString())
            {
                var truck = context.GetMachineById(currentId, MachineryTypeEnum.Truck);
                mod.UpdateFromDb(truck);
                return mod;
            }

            if (type == MachineryTypeEnum.Boat.ToString())
            {
                var boat = context.GetMachineById(currentId, MachineryTypeEnum.Boat);
                mod.UpdateFromDb(boat);
                return mod;
            }

            if (type == MachineryTypeEnum.Construction.ToString())
            {
                var construct = context.GetMachineById(currentId, MachineryTypeEnum.Construction);
                mod.UpdateFromDb(construct);
                return mod;
            }

            if (type == MachineryTypeEnum.Agricultural.ToString())
            {
                var agricult = context.GetMachineById(currentId, MachineryTypeEnum.Agricultural);
                mod.UpdateFromDb(agricult);
                return mod;
            }

            return null;
        }

        private MachineCollection[] ImageLoaded(List<MachineViewModel> mod)
        {
            foreach (var machine in mod)
            {
                var id = machine.MachineId;
                var name = machine.SellerName;
                var type = machine.MachineType.ToString();
                machine.ImageVirtualPaths = GetImagesForMachinerie(id, type, name);
            }

            var machines = new MachineCollection[]
            {
                new MachineCollection { List = mod as IEnumerable, DataType = typeof(MachineViewModel)}
            };

            return machines;
        }
    }
}