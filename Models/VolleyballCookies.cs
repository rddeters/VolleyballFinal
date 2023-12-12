namespace VolleyballFinal.Models
{
    public class VolleyballCookies
    {
        private const string TeamsKey = "myteams";
        private const string Delimeter = "-";

        private IRequestCookieCollection requestCookies { get; set; } = null;
        private IResponseCookies responseCookies { get; set; } = null;

        public VolleyballCookies(IRequestCookieCollection cookies)
        {
            requestCookies = cookies;
        }

        public VolleyballCookies(IResponseCookies cookies)
        {
            responseCookies = cookies;
        }

        public void SetMyTeamIds(List<Team> myteams)
        {
            List<int> ids = myteams.Select(t => t.Id).ToList();
            string idsString = String.Join(Delimeter, ids);
            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddDays(30)
            };
        }
    }
}
