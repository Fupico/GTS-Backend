using Microsoft.AspNetCore.SignalR;

namespace GTSProject.Services.Notification.Hubs
{
    public class NotificationHub : Hub
    {
        /// <summary>
        /// Tüm kullanıcılara mesaj gönderilir.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessageAsync(string message)
        {
            await Clients.All.SendAsync("recevieMessage", message);
        }

        /// <summary>
        /// Belli bir gruba göndermek için kullanılır
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SendMessageForGroupsAsync(string person,string message)
        {
            await Clients.Group(person).SendAsync("recevieGroupMessage", message);
        }
    }
}
