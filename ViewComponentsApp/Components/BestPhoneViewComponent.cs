using System.Collections.Generic;
using System.Linq;
using ViewComponentsApp.Models;

namespace ViewComponentsApp.Components
{
    public class BestPhoneViewComponent
    {
        List<Phone> phones;
        public BestPhoneViewComponent()
        {
            phones = new List<Phone>
            {
                new Phone {Title="iPhone 7", Price=56000},
                new Phone {Title="Idol S4", Price=26000 },
                new Phone {Title="Elite x3", Price=55000 },
                new Phone {Title="Honor 8", Price=23000 }
            };
        }
        public string Invoke()
        {
            var item = phones.OrderByDescending(x => x.Price).Take(1).FirstOrDefault();

            return $"Самый дорогой телефон: {item.Title}  Цена: {item.Price}";
        }
    }
}