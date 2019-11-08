using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

public class DoSomething : MonoBehaviour
{

    static HttpClient c = new HttpClient();
    async void Start()
    {
        Debug.Log("Script has started!");
        var res = await GetAsync("http://127.0.0.1:5000/?length=100&power=33");
        Debug.Log(res.ToString());
    }

    void Update()
    {
    }

    static async Task<string> GetAsync(string path)
    {
        string result = "";
        HttpResponseMessage response = await c.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            result = await response.Content.ReadAsStringAsync();
        }
        return result;
    }
}
