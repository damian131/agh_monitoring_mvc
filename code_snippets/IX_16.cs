[Function("Function1")]
public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
{
	_logger.LogInformation("C# HTTP trigger function processed a request.");

	var response = req.CreateResponse(HttpStatusCode.OK);
	response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
	response.WriteString("Hello from Azure Funtion!");

	return response;
}
