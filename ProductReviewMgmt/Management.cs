using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReviewMgmt
{
    class Management
    {
        public void TopRecords(List<ProductReview> listProductReview)
        {
            var recordedData = (from ProductReview in listProductReview orderby ProductReview.Rating descending select ProductReview).Take(3);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId" + list.ProductId +"-"+ "UserId" + list.UserId + "-" + "Rating" + list.Rating + "-" + "Review" + list.Review + "-"+ "isLike" + list.isLike);
            }
        }
        public void SelectRecords(List<ProductReview> listproductReview)
        {
            var recordedData = from ProductReviews in listproductReview where (ProductReviews.ProductId == 1 || ProductReviews.ProductId == 4 || ProductReviews.ProductId == 9) && ProductReviews.Rating >= 3 select ProductReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId" + list.ProductId + "-" + "UserId" + list.UserId + "-" + "Rating" + list.Rating + "-" + "Review" + list.Review + "-" + "isLike" + list.isLike);
            }
        }
        public void RetriveRecords(List<ProductReview> listproductReview)
        {
            var recordedData = listproductReview.GroupBy(A => A.ProductId).Select(A => new { ProductId = A.Key, Count = A.Count() });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ProductId + "_____" + list.Count);
            }
        }



    }
}
