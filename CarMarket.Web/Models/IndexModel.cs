namespace CarMarket.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    // TODO refactor
    public class IndexModel
    {
        public int MachineId { get; set; }

        public MachineryTypeEnum MachineType { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required]
        public string Gear { get; set; }

        [Required]
        public string Carriage { get; set; }

        [Required]
        public string NumberOfDoors { get; set; }

        [Required]
        public string Years { get; set; }

        [Required]
        public string Months { get; set; }

        [Required]
        public int? Price { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Category { get; set; }

        public string Modification { get; set; }

        public int HorsePower { get; set; }

        public int Cubage { get; set; }

        [Required]
        public int Km { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string EuroStandart { get; set; }

        public string MoreInformation { get; set; }

        [Required]
        public string Cargo { get; set; }

        [Required]
        public string NumberOfSeats { get; set; }

        [Required]
        public string TypeOfEngine { get; set; }

        [Required]
        public int NumberOfBerths { get; set; }

        [Required]
        public string Heat { get; set; }

        [Required]
        public string Length { get; set; }

        [Required]
        public string Axle { get; set; }

        [Required]
        public string NumberOfEngines { get; set; }

        [Required]
        public int HoursOfOperation { get; set; }

        [Required]
        public string Material { get; set; }

        [Required]
        public string Width { get; set; }

        [Required]
        public string Wade { get; set; }

        public string Displacement { get; set; }

        public string CarryingCapacity { get; set; }

        public string WorkingHeight { get; set; }

        public string Operation { get; set; }

        public string TotalWeight { get; set; }

        public bool AirConditioning { get; set; }

        public bool JustClimate { get; set; }

        public bool LeatherSeats { get; set; }

        public bool PowerWindows { get; set; }

        public bool ElectricMirrors { get; set; }

        public bool PowerSeats { get; set; }

        public bool HeatedSeats { get; set; }

        public bool Sunroof { get; set; }

        public bool Stereo { get; set; }

        public bool AlloyWheels { get; set; }

        public bool Dvd { get; set; }

        public bool MultifunctionalSteeringWheel { get; set; }

        public bool FourXFour { get; set; }

        public bool Abs { get; set; }

        public bool Esp { get; set; }

        public bool Airbag { get; set; }

        public bool XenonLights { get; set; }

        public bool HalogenHeadlights { get; set; }

        public bool Asr { get; set; }

        public bool Parktronic { get; set; }

        public bool Alarm { get; set; }

        public bool Immobilizer { get; set; }

        public bool Insurance { get; set; }

        public bool Armored { get; set; }

        public bool StartStopSystem { get; set; }

        public bool KeylessIgnition { get; set; }

        public bool Tiptronic { get; set; }

        public bool Autopilot { get; set; }

        public bool PowerSteering { get; set; }

        public bool TripComputer { get; set; }

        public bool ServiceBook { get; set; }

        public bool Guaranty { get; set; }

        public bool NavigationSystem { get; set; }

        public bool Tuning { get; set; }

        public bool PanoramicRoof { get; set; }

        public bool Taxi { get; set; }

        public bool Retro { get; set; }

        public bool Rod { get; set; }

        public bool Places { get; set; }

        public bool Refrigerated { get; set; }

        public bool AirCushion { get; set; }

        public bool AutoStarter { get; set; }

        public bool ProtectiveGlass { get; set; }

        public bool TvDvd { get; set; }

        public bool AirCondition { get; set; }

        public bool WC { get; set; }

        public bool SolarEnergySystem { get; set; }

        public bool Heater { get; set; }

        public bool SleepingCabin { get; set; }

        public bool ASD { get; set; }

        public bool Retarder { get; set; }

        public bool Winch { get; set; }

        public bool CentralLocking { get; set; }

        public bool EPD { get; set; }

        public bool EPS { get; set; }

        public bool Climat { get; set; }

        public bool Radar { get; set; }

        public void UpdateFromDb(MachineEntityViewModel machine)
        {
            var updateProperties = machine.GetType().GetProperties();
            var currentPorperties = this.GetType().GetProperties();

            foreach (var item in updateProperties)
            {
                foreach (var prop in currentPorperties)
                {
                    if (item.Name == prop.Name)
                    {
                        if (item.PropertyType == typeof(string) && item.GetValue(machine) != null
                            || item.PropertyType == typeof(int) && (int)item.GetValue(machine) > 0
                            || item.PropertyType == typeof(int?) && (int?)item.GetValue(machine) > 0
                            || item.PropertyType == typeof(MachineryTypeEnum)
                            || item.PropertyType == typeof(bool))
                        {
                            var value = item.GetValue(machine);
                            prop.SetValue(this, value);
                        }
                    }
                }
            }
        }
    }
}