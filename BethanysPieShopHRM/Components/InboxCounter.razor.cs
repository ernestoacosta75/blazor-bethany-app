using BethanysPieShopHRM.Application.State;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.Components
{
    public partial class InboxCounter
    {
        [Inject] 
        public ApplicationState ApplicationState { get; set; }

        public int MessageCount { get; set; } = 0;

        protected override void OnInitialized()
        {
            MessageCount = new Random().Next(10);
            ApplicationState.NumberOfMessages = MessageCount;
        }
    }
}
