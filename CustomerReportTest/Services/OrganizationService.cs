using CustomerReportTest.Models;


namespace CustomerReportTest.Services
{
    public class OrganizationService
    {
        private readonly HttpClient _httpClient;

        public OrganizationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ActiveOrganization>> GetOrganizationsAsync()
        {
            string absoluteUri = "https://localhost:7220/api/OrganizationStatus/ActiveOrganizations";
            return await _httpClient.GetFromJsonAsync<IEnumerable<ActiveOrganization>>(absoluteUri);
        }

        public async Task<Organization> GetOrganizationDataAsync(string organizationName)
        {
            try
            {
                var encodedName = Uri.EscapeDataString(organizationName);
                var response = await _httpClient.GetFromJsonAsync<Organization>($"https://localhost:7220/OrganizationData/customer/{encodedName}");
                return response;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request exception: {e.Message}");
                return null;
            }
        }
    }
}

