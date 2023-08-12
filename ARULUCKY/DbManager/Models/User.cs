using Shared;
using Shared.Enums;
using System.Globalization;

namespace DbManager.Models
{
    public class User
    {
        public ulong InnerID { get; set; }

        public ulong TelegramID { get; set; }

        public string? FirstPullTime { get; set; }

        public virtual DateTime? FirstPullTimeWrap
        {
            get
            {
                if (DateTime.TryParseExact(FirstPullTime, ConfigurationWrap.DATETIME_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out DateTime result))
                    return result;
                else
                    return null;
            }
            set
            {
                FirstPullTime = value?.ToString(ConfigurationWrap.DATETIME_FORMAT);
            }
        }

        public string? LastPullTime { get; set; }

        public virtual DateTime? LastPullTimeWrap
        {
            get
            {
                if (DateTime.TryParseExact(LastPullTime, ConfigurationWrap.DATETIME_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out DateTime result))
                    return result;
                else
                    return null;
            }
            set
            {
                LastPullTime = value?.ToString(ConfigurationWrap.DATETIME_FORMAT);
            }
        }

        public Role Role { get; set; }
    }
}
