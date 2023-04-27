﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Apprisal.BlazorApp.Model
{
    public class ApprisalModel
    {
        [Key]
        [Display(Name = "App Id")]
        public int ApprisalId { get; set; }

        [Required]
        [Display(Name = "Evoluvation Period")]
        public string? EvoluvationPeriod { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Join")]
        public DateTime? DateOfJoin { get; set; }
        [Required]
        [Display(Name = "Number Of Leaves Taken")]
        public double NumberOfLeavesTaken { get; set; }



        [Required]
        [Display(Name = "Client Delivery")]
        public ClientDelivery ClientDelivery { get; set; }

        [Required]
        [Display(Name = "Client Delivery Feed")]
        public string? ClientDeliveryFeed { get; set; }


        [Required]
        public Responsibilities Responsibility { get; set; }


        [Required]
        [Display(Name = "Responsibilities")]
        public string? ResponsibilitiesFeed { get; set; }

        [Required]
        public Skills Skills { get; set; }


        [Required]
        [Display(Name = "Skills Feed")]
        public string? SkillsFeed { get; set; }


        [Display(Name = "Certificates")]
        public string? Certifiate { get; set; }
        [Display(Name = "About Course")]
        public string? AboutCourse { get; set; }
        [Required]
        public string? Feedback { get; set; }
    }

    public enum ClientDelivery
    {
        Exceed,
        Good,
        Achieves,
        NeedImprovment
    }
    public enum Responsibilities
    {
        Exceed,
        Good,
        Achieves,
        NeedImprovment
    }
    public enum Skills
    {
        Good,
        AboveAverage,
        Achieves,
        NeedImprovment
    }
}
