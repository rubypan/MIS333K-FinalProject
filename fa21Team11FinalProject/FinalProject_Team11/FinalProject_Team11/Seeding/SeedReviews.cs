using System;
using System.Collections.Generic;
using System.Linq;
using FinalProject_Team11.DAL;
using FinalProject_Team11.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_Team11.Seeding
{
    public static class SeedReviews
    {
        public static void SeedAllReview(AppDbContext db)
        {
            if (db.Reviews.Count() == 21)
            {
                throw new NotSupportedException("The database already contains all 21 reviews!");
            }

            Int32 intReviewsAdded = 0;
            Int32 intreviewnum = 0; //helps to keep track of error on books


            try
            {
                List<Review> Reviews = new List<Review>();

                Review r1 = new Review()
                {
                    reviewnum = 1,
                    rating = 4,
                    TextReivew = ""

                };
                r1.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "588 Alan Rest");
                r1.User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com");

                Reviews.Add(r1);

                Review r2 = new Review()
                {
                    reviewnum = 2,
                    rating = 3,
                    TextReivew = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator."

                };
                r2.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "1168 Gary Fords Apt. 308");
                r2.User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");

                Reviews.Add(r2);

                Review r3 = new Review()
                {
                    reviewnum = 3,
                    rating = 4,
                    TextReivew = ""

                };
                r3.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "03541 Ryan Islands Apt. 562");
                r3.User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com");

                Reviews.Add(r3);

                Review r4 = new Review()
                {
                    reviewnum = 4,
                    rating = 2,
                    TextReivew = ""

                };
                r4.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "588 Alan Rest");
                r4.User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com");

                Reviews.Add(r4);

                Review r5 = new Review()
                {
                    reviewnum = 5,
                    rating = 3,
                    TextReivew = "Nebraska was... interesting"

                };
                r5.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
                r5.User = db.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com");

                Reviews.Add(r5);

                Review r6 = new Review()
                {
                    reviewnum = 6,
                    rating = 1,
                    TextReivew = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN"

                };
                r6.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
                r6.User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com");

                Reviews.Add(r6);

                Review r7 = new Review()
                {
                    reviewnum = 7,
                    rating = 1,
                    TextReivew = "Worst. Stay. Ever. Never using BevoBnB again"

                };
                r7.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
                r7.User = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com");

                Reviews.Add(r7);

                Review r8 = new Review()
                {
                    reviewnum = 8,
                    rating = 5,
                    TextReivew = ""

                };
                r8.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
                r8.User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");

                Reviews.Add(r8);

                Review r9 = new Review()
                {
                    reviewnum = 9,
                    rating = 2,
                    TextReivew = ""

                };
                r9.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "457 Vargas Island Suite 853");
                r9.User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");

                Reviews.Add(r9);

                Review r10 = new Review()
                {
                    reviewnum = 10,
                    rating = 1,
                    TextReivew = "It was SO hard to book this place. Who coded this site anyway? ;)"

                };
                r10.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
                r10.User = db.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com");

                Reviews.Add(r10);

                Review r11 = new Review()
                {
                    reviewnum = 11,
                    rating = 4,
                    TextReivew = ""

                };
                r11.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "71664 Kim Throughway");
                r11.User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com");

                Reviews.Add(r11);

                Review r12 = new Review()
                {
                    reviewnum = 12,
                    rating = 5,
                    TextReivew = "This place rocked!"

                };
                r12.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
                r12.User = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com");

                Reviews.Add(r12);

                Review r13 = new Review()
                {
                    reviewnum = 13,
                    rating = 4,
                    TextReivew = ""

                };
                r13.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
                r13.User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com");

                Reviews.Add(r13);

                Review r14 = new Review()
                {
                    reviewnum = 14,
                    rating = 4,
                    TextReivew = ""

                };
                r14.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "457 Vargas Island Suite 853");
                r14.User = db.Users.FirstOrDefault(u => u.Email == "lamemartin.Martin@aool.com");

                Reviews.Add(r14);

                Review r15 = new Review()
                {
                    reviewnum = 15,
                    rating = 1,
                    TextReivew = "There were 1...5...22 roaches? I lost count."

                };
                r15.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
                r15.User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com");

                Reviews.Add(r15);

                Review r16 = new Review()
                {
                    reviewnum = 16,
                    rating = 1,
                    TextReivew = ""

                };
                r16.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "1168 Gary Fords Apt. 308");
                r16.User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com");

                Reviews.Add(r16);

                Review r17 = new Review()
                {
                    reviewnum = 17,
                    rating = 4,
                    TextReivew = "I LOVED the place! Had a nice view of the mountains"

                };
                r17.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "1220 Heidi Rue Apt. 998");
                r17.User = db.Users.FirstOrDefault(u => u.Email == "fd@puppy.com");

                Reviews.Add(r17);

                Review r18 = new Review()
                {
                    reviewnum = 18,
                    rating = 5,
                    TextReivew = ""

                };
                r18.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "1220 Heidi Rue Apt. 998");
                r18.User = db.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com");

                Reviews.Add(r18);

                Review r19 = new Review()
                {
                    reviewnum = 19,
                    rating = 5,
                    TextReivew = "My stay was amazing! Saved my marriage"

                };
                r19.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "588 Alan Rest");
                r19.User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");

                Reviews.Add(r19);

                Review r20 = new Review()
                {
                    reviewnum = 20,
                    rating = 2,
                    TextReivew = ""

                };
                r20.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "457 Vargas Island Suite 853");
                r20.User = db.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com");

                Reviews.Add(r20);

                Review r21 = new Review()
                {
                    reviewnum = 21,
                    rating = 2,
                    TextReivew = "My wife's attitude was the only thing rougher than the sand at the nearby beaches"

                };
                r21.Property = db.Properties.FirstOrDefault(p => p.PropertyAddress == "03541 Ryan Islands Apt. 562");
                r21.User = db.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");

                Reviews.Add(r21);


                foreach (Review reviewToAdd in Reviews)
                {
                    intreviewnum = reviewToAdd.reviewnum;
                    Review dbReview = db.Reviews.FirstOrDefault(r => r.reviewnum == reviewToAdd.reviewnum);
                    if (dbReview == null)
                    {
                        db.Reviews.Add(reviewToAdd);
                        db.SaveChanges();
                        intReviewsAdded += 1;
                    }
                    else
                    {
                        dbReview.reviewnum = reviewToAdd.reviewnum;
                        db.Update(dbReview);
                        db.SaveChanges();
                        intReviewsAdded += 1;
                    }
                }
            }

            catch (Exception ex)
            {
                String msg = "Repositories added:" + intReviewsAdded + "; Error on " + intreviewnum;
                throw new InvalidOperationException(ex.Message + msg);
            }
        }
    }
}
