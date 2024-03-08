using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ARventure_Path
{
    public class ChatGPTClient

    {
        private const string url = "https://api.openai.com/v1/chat/completions";
        private const string apiKey = "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";

       

        public static List<string> generateFragments(string titulo, int fragmentCount) 
        {
            List<string> fragments = new List<string>();

            string messageString = "genera un fragmento de menos de 100 caracteres de la historia " + titulo ;

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

            var requestData =
                "{\"model\": \"gpt-3.5-turbo\", \"n\": " + fragmentCount + " , \"messages\": [{\"role\": \"user\",\"content\": \"" + messageString + "\"}]}";
            var response = httpClient.PostAsync(url, new StringContent(requestData, Encoding.UTF8, "application/json")).Result;


            if (response.IsSuccessStatusCode)
            {
                string contentString = response.Content.ReadAsStringAsync().Result;
                var gptResponse = JsonConvert.DeserializeObject<GPTResponse>(contentString);

                foreach (var choice in gptResponse?.choices) 
                {
                    fragments.Add(choice.message.content);
                }
            }
            else
            {
                fragments.Add(response.Content.ReadAsStringAsync().Result);
            }

            return fragments;

        }

        public static string makeRequestEventText() 
        {
            string messageString = "dame un título de una historia , y un resumen de 200 caracteres";


            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

            var requestData =
                "{\"model\": \"gpt-3.5-turbo\",\"messages\": [{\"role\": \"user\",\"content\": \"" + messageString + "\"}]}";
            var response = httpClient.PostAsync(url, new StringContent(requestData, Encoding.UTF8, "application/json")).Result;


            if (response.IsSuccessStatusCode)
            {
                string contentString = response.Content.ReadAsStringAsync().Result;
                var gptResponse = JsonConvert.DeserializeObject<GPTResponse>(contentString);

                return gptResponse?.choices[0].message.content;
            }
            else
            {
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        public static string MakeRequest(string keywords)
        {
            string messageString = "dame un título de una historia" + keywords + " , y un resumen de 200 caracteres";
            

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

            var requestData =
                "{\"model\": \"gpt-3.5-turbo\",\"messages\": [{\"role\": \"user\",\"content\": \"" + messageString + "\"}]}";
            var response = httpClient.PostAsync(url, new StringContent(requestData, Encoding.UTF8, "application/json")).Result;


            if (response.IsSuccessStatusCode)
            {
                string contentString = response.Content.ReadAsStringAsync().Result;
                var gptResponse = JsonConvert.DeserializeObject<GPTResponse>(contentString);

                return gptResponse?.choices[0].message.content;
            }
            else
            {
                return response.Content.ReadAsStringAsync().Result;
            }

        }

        public class GPTResponse
        {
            public string id { get; set; }
            public string @object { get; set; }
            public int created { get; set; }
            public string model { get; set; }
            public List<Choice> choices { get; set; }
            public Usage usage { get; set; }
            public string system_fingerprint { get; set; }

            public class Usage
            {
                public int prompt_tokens { get; set; }
                public int completion_tokens { get; set; }
                public int total_tokens { get; set; }
            }

            public class Message
            {
                public string role { get; set; }
                public string content { get; set; }
            }

            public class Choice
            {
                public int index { get; set; }
                public Message message { get; set; }
                public object logprobs { get; set; }
                public string finish_reason { get; set; }
            }
        }
    }
}
