using _8._06._2023dz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._06._2023dz
{
    public class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }


        public static List<Device> CreateDevicesList1()
        {
            return new List<Device>
        {
            new Device { Name = "Смартфон", Manufacturer = "Samsung", Price = 5000 },
            new Device { Name = "Ноутбук", Manufacturer = "Apple", Price = 20000 },
            new Device { Name = "Телевізор", Manufacturer = "LG", Price = 15000 }
        };
        }

        public static List<Device> CreateDevicesList2()
        {
            return new List<Device>
        {
            new Device { Name = "Смартфон", Manufacturer = "Samsung", Price = 900 },
            new Device { Name = "Телевізор", Manufacturer = "Sony", Price = 12000 },
            new Device { Name = "Монітор", Manufacturer = "Dell", Price = 500 }
        };
        }

        public static List<Device> GetDifference(List<Device> devices1, List<Device> devices2)
        {
            return devices1.Where(d1 => !devices2.Any(d2 => d1.Manufacturer == d2.Manufacturer)).ToList();
        }

        public static List<Device> GetIntersection(List<Device> devices1, List<Device> devices2)
        {
            return devices1.Where(d1 => devices2.Any(d2 => d1.Manufacturer == d2.Manufacturer)).ToList();
        }

        public static List<Device> GetUnion(List<Device> devices1, List<Device> devices2)
        {
            return devices1.Union(devices2, new DeviceComparer()).ToList();
        }

        public static void PrintDevices(List<Device> devices)
        {
            foreach (var device in devices)
            {
                Console.WriteLine($"Назва: {device.Name}, Виробник: {device.Manufacturer}, Вартість: {device.Price}");
            }
        }
    }
}
public class DeviceComparer : IEqualityComparer<Device>
{
    public bool Equals(Device x, Device y)
    {
        return x.Manufacturer == y.Manufacturer;
    }

    public int GetHashCode(Device obj)
    {
        return obj.Manufacturer.GetHashCode();
    }


}