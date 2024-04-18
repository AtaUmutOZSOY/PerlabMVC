namespace Core.Utilities.Security.Jwt
{
    public class RefreshToken:Entity.Concretes.Entity
    {
        public int UserId { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }

        
    }
}
