using Microsoft.Extensions.Options;

namespace Less15_API
{
    public class RoomServise
    {
        private readonly ServerSettings _settings;
        public RoomServise(IOptions<ServerSettings> opts)
        {
            _settings = opts.Value;
        }

        public string GetDescription()
        {
            return $"Max meeting time (minutes): {_settings.MaxMeetingTimeMins}, Capacity: {_settings.MaxUsersPerRoom}, Amount of rooms: {_settings.MaxRooms}";
        }
    }
}
