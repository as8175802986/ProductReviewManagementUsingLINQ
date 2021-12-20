using System;
using System.Collections.Generic;

namespace ProductReviewMgmt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management using LINQ\n");
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ProductId=1,UserId=1,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=2,UserId=2,Rating=4,Review="Average",isLike=true},
                new ProductReview(){ProductId=3,UserId=3,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=4,UserId=4,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=5,UserId=5,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=6,UserId=6,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=7,UserId=7,Rating=4,Review="Average",isLike=true},
                new ProductReview(){ProductId=8,UserId=8,Rating=5,Review="Excellent",isLike=true},
                new ProductReview(){ProductId=9,UserId=9,Rating=3,Review="Good",isLike=true},
                new ProductReview(){ProductId=10,UserId=10,Rating=5,Review="Excellent",isLike=true}
            };
            Management management = new Management();
            //UC1
            management.TopRecords(productReviewList);
           
            



        }
    }
}
