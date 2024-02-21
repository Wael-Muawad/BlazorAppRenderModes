using BlazorAppAutoRender.Client.Services;

namespace BlazorAppAutoRender.Services
{
    public class SomeRandomData : ISomeRandomData
    {
        public async Task<string[]> GetDummyData()
        {
            Console.WriteLine("From Server");

            string[] randomArray = new string[10];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = Guid.NewGuid().ToString();
            }

            return randomArray;
        }
    }
}
