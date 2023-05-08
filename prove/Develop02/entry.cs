namespace Develop02
{
    
}
public class Entry 
{
    public string _response = "";
    public string _prompt = "";
    public string _date = "";

    public string convert_to_string()
    {
        string _entry = ($"Date: {_date} - Prompt: {_prompt} \n{_response}");
        return _entry;
    }

    public void hold(string _prompt, string _response, string _date)
    {
        this._prompt = _prompt;
        this._response = _response;
        this._date = _date;
    }

}