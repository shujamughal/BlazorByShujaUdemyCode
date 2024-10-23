using BWA_JSInterop2Example.Models;
using Microsoft.JSInterop;

namespace BWA_JSInterop2Example.Services
{
    public class ClickHandler
    {
        private int _clickCount = 0;

        [JSInvokable]
        public void TrackClick()
        {
            _clickCount++;
            Console.WriteLine($"Button clicked {_clickCount} times.");
        }
        [JSInvokable]
        public void TrackClickWithDetails(string elementId, double x, double y)
        {
            Console.WriteLine($"Button with ID {elementId} clicked at coordinates ({x}, {y}).");
        }
        [JSInvokable]
        public void TrackClickDetails(ClickDetails clickDetails)
        {
            Console.WriteLine($"Element {clickDetails.ElementId} clicked at ({clickDetails.X}, {clickDetails.Y}) on {clickDetails.Timestamp}");
        }

        [JSInvokable]
        public string GetSimpleMessage()
        {
            return "Button Clicked!";
        }

        [JSInvokable]
        public ClickDetails GetClickDetails()
        {
            return new ClickDetails
            {
                ElementId = "trackButtonDetails",
                X = 100,
                Y = 200,
                Timestamp = DateTime.Now
            };
        }
    }
}
