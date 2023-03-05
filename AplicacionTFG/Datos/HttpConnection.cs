using System.IO;
using System.Net;

namespace Datos
{
    /// <summary>
    /// Clase HTTPConection encargada de hacer las llamadas a la API y obtener las respuestas.
    /// </summary>
    public static class HttpConnection
    {
        /// <summary>
        /// URL de la API.
        /// </summary>
        static readonly string Url = $"https://localhost:7033/";

        /// <summary>
        /// Método encargado de enviar las llamadas a la API
        /// </summary>
        /// <param name="json">JSON con los datos, se utiliza en todos los casos excepto en las llamadas con el método GET.</param>
        /// <param name="method">Método de la llamada de la API, pueden ser: GET, POST, PUT, DELETE</param>
        /// <param name="endPoint">Endpoint que llamamos de la API</param>
        /// <returns></returns>
        public static WebResponse Send(string json, string method, string endPoint)
        {

            var request = (HttpWebRequest)WebRequest.Create(Url + endPoint);
            request.Method = method;
            request.ContentType = "application/json";
            request.Accept = "application/json";

            //Para evitar usar ssl
            /*
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };*/

            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            try
            {
                if (method != "GET")
                {
                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    {
                        streamWriter.Write(json);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }


                return request.GetResponse();

            }
            catch (WebException ex)
            {
                HttpStatusCode statusCode = ((HttpWebResponse)ex.Response).StatusCode;

            }
            return null;//Modificar

        }

        /// <summary>
        /// Método encargado de traducir la respuesta de la API a un JSON.
        /// </summary>
        /// <param name="response">Respuesta de la API.</param>
        /// <returns>Una cadena de texto convertida a un JSON.</returns>
        public static string ResponseToJson(WebResponse response)
        {
            using (response)
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return null;
                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        // Do something with responseBody
                        return responseBody;
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certification"></param>
        /// <param name="chain"></param>
        /// <param name="sslPolicyErrors"></param>
        /// <returns></returns>
        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}