using System.Collections.Generic;
using System.Threading.Tasks;

namespace Soq._68219262.Console
{
    public class MySettingService
    {

        public static async Task<IEnumerable<IMySetting>> GetCollectionAsync()
        {
            // some long running stuff happens
            await Task.FromResult(false);

            return new[]
            {
                new MySetting
                {
                    SettingName = "MySetting1",
                    SettingValue = "MyValue1"
                },
                new MySetting
                {
                    SettingName = "MySetting2",
                    SettingValue = "MyValue2"
                }
            };
        }
    }
}
