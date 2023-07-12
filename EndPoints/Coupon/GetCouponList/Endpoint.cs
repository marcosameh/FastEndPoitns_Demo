namespace Coupon.GetCouponList
{
    public class Endpoint : EndpointWithoutRequest<List<ResponseCoupon>>
    {
        public override void Configure()
        {
            Get("/api/coupon");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken c)
        {
            var coupons= await Data.GetCouponsAsync();
            
            await SendAsync(coupons);
        }
    }
}