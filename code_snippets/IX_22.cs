[HttpGet]
public async Task<ActionResult<string>> GetText()
{
	var functionUrl = "<func-url>";
	var client = new HttpClient();
	var response = await client.GetAsync(functionUrl);
	var text = await response.Content.ReadAsStringAsync();
	return new OkObjectResult(text);
}
