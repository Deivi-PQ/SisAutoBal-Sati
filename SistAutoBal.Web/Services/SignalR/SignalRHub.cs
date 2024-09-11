using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using SisAutoBal.BusinessObjects.OfiOper;
using SisAutoBal.Web.Services.OfiSegu;
using SisAutoBal.Web.Models;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace SisAutoBal.Web.Services.SignalR
{
    public class SignalRHub:Hub
    {
        private readonly IHttpContextAccessor contxt;
        private readonly UserTracker _userTracker;
        public SignalRHub(IHttpContextAccessor httpContextAccessor, UserTracker userTracker)
        {
            contxt = httpContextAccessor;
            _userTracker = userTracker;
        }
        public async Task SendMessage(string user, string message)
       {
            string ConnectionId = Context.ConnectionId;
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            _userTracker.AddUser(user, ConnectionId);
        }
        public async Task SendMessageToCaller(string message)
        {
            await Clients.Caller.SendAsync("ReceiveMessage", "Servidor", message);
        }

        public async Task SendMessageToGroup(string groupName, string message)
        {
            await Clients.Group(groupName).SendAsync("ReceiveMessage", "Servidor", message);
        }
        public async Task JoinGroup(string groupName)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
        public async Task SendMessageToUser(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveMessage", message);
        }
    }
}
