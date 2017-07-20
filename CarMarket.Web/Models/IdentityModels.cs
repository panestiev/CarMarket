namespace CarMarket.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Linq;
    using System;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Area { get; set; }
        [Required]
        public string City { get; set; }

        public string Adress { get; set; }

        public virtual ICollection<CarEntityViewModel> CarS { get; set; }

        public virtual ICollection<BusEntityViewModel> BusS { get; set; }

        public virtual ICollection<MotoEntityViewModel> MotoS { get; set; }

        public virtual ICollection<TruckEntityViewModel> TruckS { get; set; }

        public virtual ICollection<CamperEntityViewModel> CamperS { get; set; }

        public virtual ICollection<BoatEntityViewModel> BoatS { get; set; }

        public virtual ICollection<ConstructionEntityViewModel> ConstructionEquipmentS { get; set; }

        public virtual ICollection<AgriculturalEntityViewModel> AgriculturalS { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<CarEntityViewModel> Car { get; set; }

        public DbSet<BusEntityViewModel> Bus { get; set; }

        public DbSet<Images> Image { get; set; }

        public DbSet<MotoEntityViewModel> Moto { get; set; }

        public DbSet<TruckEntityViewModel> Truck { get; set; }

        public DbSet<CamperEntityViewModel> Camper { get; set; }

        public DbSet<BoatEntityViewModel> Boat { get; set; }

        public DbSet<ConstructionEntityViewModel> Construction { get; set; }

        public DbSet<AgriculturalEntityViewModel> Agricultural { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public MachineEntityViewModel GetMachineById(int id, MachineryTypeEnum type)
        {
            if (type == MachineryTypeEnum.Car)
            {
                return this.Car.Find(id);
            }
            else if (type == MachineryTypeEnum.Bus)
            {
                return this.Bus.Find(id);
            }
            else if (type == MachineryTypeEnum.Moto)
            {
                return this.Moto.Find(id);
            }
            else if (type == MachineryTypeEnum.Camper)
            {
                return this.Camper.Find(id);
            }
            else if (type == MachineryTypeEnum.Truck)
            {
                return this.Truck.Find(id);
            }
            else if (type == MachineryTypeEnum.Boat)
            {
                return this.Boat.Find(id);
            }

            else if (type == MachineryTypeEnum.Construction)
            {
                return this.Construction.Find(id);
            }
            else if (type == MachineryTypeEnum.Agricultural)
            {
                return this.Agricultural.Find(id);
            }

            return null;
        }

        public void Delete(string type, int id)
        {
            var context = ApplicationDbContext.Create();

            if (type == MachineryTypeEnum.Car.ToString())
            {
                var machine = context.Car.Where(x => x.MachineId == id);
                context.Car.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Bus.ToString())
            {
                var machine = context.Bus.Where(x => x.MachineId == id);
                context.Bus.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Moto.ToString())
            {
                var machine = context.Moto.Where(x => x.MachineId == id);
                context.Moto.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Camper.ToString())
            {
                var machine = context.Camper.Where(x => x.MachineId == id);
                context.Camper.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Truck.ToString())
            {
                var machine = context.Truck.Where(x => x.MachineId == id);
                context.Truck.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Boat.ToString())
            {
                var machine = context.Boat.Where(x => x.MachineId == id);
                context.Boat.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Construction.ToString())
            {
                var machine = context.Construction.Where(x => x.MachineId == id);
                context.Construction.RemoveRange(machine);
                context.SaveChanges();
            }
            else if (type == MachineryTypeEnum.Agricultural.ToString())
            {
                var machine = context.Agricultural.Where(x => x.MachineId == id);
                context.Agricultural.RemoveRange(machine);
                context.SaveChanges();
            }

            return;
        }

        public List<MachineViewModel> GetMachinesByUserId(string Id)
        {
            var machines = new List<MachineEntityViewModel>();
            List<MachineViewModel> machineList = new List<MachineViewModel>(); 

            var list = this.Users
                .Include(x => x.CarS)
                .Include(x => x.BusS)
                .Include(x => x.MotoS)
                .Include(x => x.TruckS)
                .Include(x => x.CamperS)
                .Include(x => x.BoatS)
                .Include(x => x.AgriculturalS)
                .Include(x => x.ConstructionEquipmentS)
                .Where(x => x.Id == Id)
                .First();

            machines.AddRange(list.CarS);
            machines.AddRange(list.BusS);
            machines.AddRange(list.MotoS);
            machines.AddRange(list.TruckS);
            machines.AddRange(list.CamperS);
            machines.AddRange(list.BoatS);
            machines.AddRange(list.AgriculturalS);
            machines.AddRange(list.ConstructionEquipmentS);

            Mapper.UpdateList(machines, machineList);

            return machineList;
        }

        public bool ValidateMachine(string type, int id)
        {
            if (type == MachineryTypeEnum.Car.ToString())
            {
                var machine = this.Car.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Bus.ToString())
            {
                var machine = this.Bus.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Moto.ToString())
            {
                var machine = this.Moto.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Camper.ToString())
            {
                var machine = this.Camper.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Truck.ToString())
            {
                var machine = this.Truck.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Boat.ToString())
            {
                var machine = this.Boat.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Construction.ToString())
            {
                var machine = this.Construction.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }
            else if (type == MachineryTypeEnum.Agricultural.ToString())
            {
                var machine = this.Agricultural.Where(x => x.MachineId == id).Include(x => x.ApplicationUserId);
                return machine.Count() > 0;
            }

            return false;
        }
    }
}