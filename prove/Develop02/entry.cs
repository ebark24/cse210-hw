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

}