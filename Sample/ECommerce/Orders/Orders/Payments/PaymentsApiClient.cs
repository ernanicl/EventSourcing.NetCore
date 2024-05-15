using System.Net.Http.Json;
using System.Text.Json;
using Orders.Payments.RequestingPayment;

namespace Orders.Payments;

public class PaymentsApiClient(HttpClient client)
{
    public  Task<HttpResponseMessage> Request(RequestPayment command, CancellationToken ct)
    {
        return client.PostAsJsonAsync("/api/payments", command, ct);
    }
}
