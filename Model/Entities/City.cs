using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdmin.Model.Entities {
    
    // список городов в базе
    public class City {

        public int Id { get; set; }

        public string Name { get; set; }
        
        // связь с таблицей клиентов
        public List<Client> Clients { get; set; } = new List<Client>();

    }
}
