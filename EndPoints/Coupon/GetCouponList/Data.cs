using Dom;
using Microsoft.EntityFrameworkCore;

namespace Coupon.GetCouponList
{
    public class Data
    {
        private readonly FastEndPoints_DemoContext _context;

        public Data(FastEndPoints_DemoContext context)
        {
            _context = context;
        }

        
        public   async Task<List<ResponseCoupon>> GetCouponsAsync()
        {
            // Use the FastEndPoints_DemoContext instance to retrieve data from the database
            var coupons = await _context.Coupon.Select(a => new ResponseCoupon
            {
                Id = a.Id,
                Name = a.Name,
                Percent = a.Percent,
                IsActive = a.IsActive,            
            })
            .ToListAsync();

            return coupons;
        }
    }
}