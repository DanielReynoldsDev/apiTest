using Newtonsoft.Json;



class Program
{
    HttpClient client = new HttpClient();

    static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.GetJoke();
    }

    public async Task GetJoke()
    {
        string response = await client.GetStringAsync("https://v2.jokeapi.dev/joke/Programming?blacklistFlags=nsfw,religious,political,racist,sexist,explicit&type=single");

        Joke joke = JsonConvert.DeserializeObject<Joke>(response);
        Console.WriteLine(joke.joke);

    }


}

class Joke
{
    public string joke { get; set; }

}

