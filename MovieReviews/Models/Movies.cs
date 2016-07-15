using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieReviews.Models
{
    public class Movies
    {
        public int ID { get; set; }

        public string MemberName { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string YearOfRelease { get; set; }

        public string Review { get; set; }

        public string TrailerLink { get; set; }
    }
}