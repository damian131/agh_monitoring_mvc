[HttpGet]
public ActionResult<string> GetText()
{
    return new OkObjectResult("Success!");
}