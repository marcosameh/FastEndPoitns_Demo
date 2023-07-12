using Dom;
using Microsoft.EntityFrameworkCore;

namespace Coupon.GetCouponList
{
    public static class Data
    {
        private readonly static FastEndPoints_DemoContext _context;

        static Data()
        {
            // Initialize the FastEndPoints_DemoContext instance using the DI container
            _context = new FastEndPoints_DemoContext();
        }

        internal static async Task<List<ResponseCoupon>> GetCouponsAsync()
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