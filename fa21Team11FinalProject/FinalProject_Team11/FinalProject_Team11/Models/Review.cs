using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject_Team11.Models
{
    //rejected by default until disputed
    public enum ReviewStatus { Pending, Confirmed, Rejected}

    public class Review
    {

        public Int32 ReviewID { get; set; }

        //scalar properties
        [Required(ErrorMessage = "You must specify a rating number")]
        [Range(1, 5, ErrorMessage = "Rating scale is from 1-5 only")]
        public Int32 rating { get; set; }

        //TODO: maximum character length?
        [MaxLength(280)]
        public String? TextReivew { get; set; }

        //TODO: dispute review
        [MaxLength(280)]
        public String DisputeReview { get; set; }

        public Int32 reviewnum { get; set; }

        //TODO: each customer only allowed review once


        //navigational properties
        public AppUser User { get; set; }
        public Property Property { get; set; }
    
    }
}
