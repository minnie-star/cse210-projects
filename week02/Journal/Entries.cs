//get; set; refrence https://www.w3schools.com/cs/cs_properties.php
class Entries
{
    public string _prompt { get; set; }
    public string _response { get; set; }
    public DateTime _date { get; set; }

    public Entries(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{_date}: {_prompt}\nResponse: {_response}\n";
    }
}