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
            var recordedData = (from ProductReview in listProductReview orderby ProductReview.Rating descending select ProductReview).Take(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId" + list.ProductId +"-"+ "UserId" + list.UserId + "-" + "Rating" + list.Rating + "-" + "Review" + list.Review + "-"+ "isLike" + list.isLike);
            }
        }

        
    }
}
