using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeCsharp
{
    class Reservation {

        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int NumberofNights { get; set; }

        public const double Price = 145.00;

        public DateTime GetArrivalDate() {
            return ArrivalDate;
        }

        public string GetArrivalDateFormatted() {
            return ArrivalDate.ToShortDateString();
        }

        public void SetArrivalDate(DateTime ArrivalDate) {
            this.ArrivalDate = ArrivalDate;
        }

        public DateTime GetDepartureDate() {
            return DepartureDate;
        }

        public string GetDepartureDateFormatted() {
            return DepartureDate.ToShortDateString();
        }

        public void SetDepartureDate(DateTime DepartureDate) {
            this.DepartureDate = DepartureDate;
        }

        public int GetNumberofNights() {
            return  DepartureDate.Day - ArrivalDate.Day;
        }

        public string GetPricePerNightFormatted() {
            return "$" + Price;
        }

        public double GetTotalPrice() {
            return GetNumberofNights() * Price;
        }

        public string GetTotalPriceFormatted() {
            return "$" + GetTotalPrice();
        }


    }
}
