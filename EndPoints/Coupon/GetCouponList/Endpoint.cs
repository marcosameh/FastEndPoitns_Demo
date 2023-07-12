namespace Coupon.GetCouponList
{
    public class Endpoint : EndpointWithoutRequest<List<ResponseCoupon>>
    {
        public Data CouponData { get; set; }
        public override void Configure()
        {
            Get("/api/coupon");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken c)
        {
            var coupons= await CouponData.GetCouponsAsync();
            
            await SendAsync(coupons);
        }
    }
}