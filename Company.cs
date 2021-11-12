using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_Reservation.Models
{
    public class Company
    {
        [Key]
        public int company_id { get; set; }
        public string company_name { get; set; }
        public string company_address { get; set; }
        public string email { get; set; }
        public string details { get; set; }
        public int city_id { get; set; }
    }

    public class CompanyPlan
    {
        [Key]
        public int plan_id { get; set; }
        public int company_id { get; set; }
        public DateTime is_created { get; set; }
        public int rooms_min { get; set; }
        public int rooms_max { get; set; }
    }

    public class UserAccount
    {
        [Key]
        public int user_id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int company_id { get; set; }
        public DateTime is_created { get; set; }
        public DateTime is_updated { get; set; }
    }

    public class City
    {
        [Key]
        public int city_id { get; set; }
        public string city_name { get; set; }
        public string postal_code { get; set; }
        public int country_id { get; set; }
    }

    public class Country
    {
        [Key]
        public int country_id { get; set; }
        public string country_name { get; set; }
    }

    public class Hotel
    {
        [Key]
        public int hotel_id { get; set; }
        public string hotel_name { get; set; }
        public string description { get; set; }
        public int company_id { get; set; }
        public int city_id { get; set; }
        public string hotel_category { get; set; }
    }

    public class Room
    {
        [Key]
        public int room_id { get; set; }
        public string room_name { get; set; }
        public string room_type { get; set; }
        public int current_price { get; set; }
    }

    public class Reservation
    {
        [Key]
        public int reservation_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public DateTime is_created { get; set; }
        public DateTime is_updated { get; set; }
        public int discount_percent { get; set; }
        public int total { get; set; }
        public int guest_id { get; set; }
        public string guest_name { get; set; }
    }

    public class ReservationStatus
    {
        [Key]
        public int status_id { get; set; }
        public int reservation_id { get; set; }
        public bool is_reserved { get; set; }
    }

    public class Guests
    {
        [Key]
        public int guest_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

}
