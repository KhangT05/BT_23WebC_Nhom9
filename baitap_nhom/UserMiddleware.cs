namespace baitap_nhom
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;
        
        public UserMiddleware(RequestDelegate next)
        { 
            _next = next;

        }
        public async Task InvokeAsync(HttpContext context, DataLoader loader)
        {
            var user = loader.LoadUsers();
            context.Items["Users"]= user;
            await _next(context);
        }
    }
}
