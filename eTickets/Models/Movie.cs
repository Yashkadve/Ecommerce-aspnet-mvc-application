﻿using eTickets.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public double Price { get; set; }
        public string CinemaName { get; set; }
        public string MovieActors { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public string MovieProducer { get; set; }
        public string IamgeURL { get; set; }
    }
}
