using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path
{
    public static class ChatGPTImage
    {

        public static Bitmap MakeRequestStoryImage(string keyword, string summary)
        {
            string message;
            if (keyword != "")
            {
                message = "Una imagen que refleje el siguiente texto:" + summary + "Con el siguiente estilo: " + keyword;
            }
            else
            {
                message = "Una imagen que represente el siguiente texto:" + summary;
            }
            const string url = "https://api.openai.com/v1/images/generations";
            const string apiKey = "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";

            var httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);


            var requestData =
                "{\"model\": \"dall-e-2\",\"prompt\": \"" + message + "\",\"n\": 1,\"size\": \"1024x1024\",\"response_format\":\"b64_json\"}";
            var response = httpClient.PostAsync(url, new StringContent(requestData, Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {

                string contentString = response.Content.ReadAsStringAsync().Result;
                dynamic gptResponse = JsonConvert.DeserializeObject<dynamic>(contentString);

                string base64 = gptResponse.data[0].b64_json;
                Bitmap img = Base64ToBitmap(base64);

                return img;

            }
            else
            {
                MessageBox.Show("No se puede generar la foto. Inténtalo otra vez cambiando alguno de los textos.");
                return null;
            }

        }

        public static Bitmap MakeResponseEventImage(string keyword)
        {
            string message = "un paisaje que representa este texto " + keyword;
            const string url = "https://api.openai.com/v1/images/generations";
            const string apiKey = "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";

            var httpClient = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            httpClient.DefaultRequestHeaders.Accept.Add(contentType);
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);


            var requestData =
                "{\"model\": \"dall-e-2\",\"prompt\": \"" + message + "\",\"n\": 1,\"size\": \"1024x1024\",\"response_format\":\"b64_json\"}";
            var response = httpClient.PostAsync(url, new StringContent(requestData, Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {

                string contentString = response.Content.ReadAsStringAsync().Result;
                dynamic gptResponse = JsonConvert.DeserializeObject<dynamic>(contentString);

                string base64 = gptResponse.data[0].b64_json;
                Bitmap img = Base64ToBitmap(base64);

                return img;

            }
            else
            {
                MessageBox.Show("No se puede generar la foto");
                return null;
            }
        }

        public static Bitmap Base64ToBitmap(string base64String)
        {
            // Decodificar la cadena Base64 en un array de bytes
            byte[] bytes = Convert.FromBase64String(base64String);

            // Crear un flujo de memoria a partir de los bytes decodificados
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                // Utilizar el constructor de Bitmap que acepta un Stream como parámetro para crear el objeto Bitmap
                Bitmap bitmap = new Bitmap(stream);
                return bitmap;
            }
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
