namespace Krishna.Web.Utility
{
    public class SD
    {
        public static string CouponApiBase { get; set; }
        public static string AuthApiBase { get; set; }
        public static string ProductApiBase { get; set; }
        public static string ShoppingCartApiBase { get; set; }

        public const string RoleAdmin = "ADMIN";
        public const string RoleCUSTOMER = "CUSTOMER";
        public const string TokenCookie = "JWTToken";
        public enum ApiType
        {
            GET,POST, PUT, DELETE, TRACE,
        }
    }
}
