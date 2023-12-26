using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDEorkShop.Entities.BookingV1
{
    /// <summary>
    /// تاریخ شروع باید قبل از پایان باشد
    /// حداقل زمان مجاز توقف باید چک شود
    /// 
    /// </summary>
    public class HolidayBooking
    {
        public string Id { get; set; }
        public int TravelerId { get; set; }
        public DateTime FirstNight { get; set; }
        public DateTime LastNight { get; set; }
        public DateTime Booked { get; set; }

        public HolidayBooking(int travelerId, DateTime firstNight,
        DateTime lastNight, DateTime booked)
        {
            this.TravelerId = travelerId;
            this.FirstNight = firstNight;
            this.LastNight = lastNight;
            this.Booked = booked;
            this.Id = GenerareId(travelerId, firstNight, lastNight, booked);
        }

        private string GenerareId(int travelerId, DateTime firstNight,
            DateTime lastNight, DateTime booked)
        {
            return string.Format("{0}-{1}-{2}-{3}",
                travelerId, ToIdFormat(firstNight),
                ToIdFormat(lastNight), ToIdFormat(booked));
        }
        private string ToIdFormat(DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }
    }
}
